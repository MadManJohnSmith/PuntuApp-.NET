using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference2;

namespace PuntuApp.UserControls
{
    public partial class editUserPage : UserControl
    {
        private NavigationControl navigationControl;
        private string username;
        private string role;
        private string userToEdit;
        private bool isEditing = false;
        private JObject userDetails;

        public editUserPage(NavigationControl navigationControl, string username, string role)
        {
            InitializeComponent();
            this.navigationControl = navigationControl;
            this.username = username;
            this.role = role;
            cbUserType.SelectedIndex = 0;
        }

        public void SetUserToEdit(string userToEdit)
        {
            this.userToEdit = userToEdit;
            isEditing = true;
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                var client = new UserServiceClient();
                string jsonResponse = client.getUserDetailsJSON(userToEdit);

                userDetails = JObject.Parse(jsonResponse);

                if (userDetails.ContainsKey("error"))
                {
                    MessageBox.Show("Error al obtener los detalles del usuario: " + (string)userDetails["error"]);
                    return;
                }

                txtUsername.Text = (string)userDetails["username"];
                txtName.Text = (string)userDetails["name"];
                cbUserType.SelectedItem = (string)userDetails["rol"];


                if (userDetails["foto"] != null && !string.IsNullOrEmpty(userDetails["foto"].ToString()))
                {
                    byte[] fotoBytes = Convert.FromBase64String(userDetails["foto"].ToString());
                    using (var ms = new MemoryStream(fotoBytes))
                    {
                        pbPhoto.BackgroundImage = Image.FromStream(ms);
                        pbPhoto.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                else
                {
                    pbPhoto.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles del usuario: " + ex.Message);
            }
        }
        public void ClearForm()
        {
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPassVeri.Clear();
            cbUserType.SelectedIndex = 0;
            pbPhoto.BackgroundImage = null;
            pbPhoto.Image = null;
            isEditing = false;
        }
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pbPhoto.BackgroundImage = Image.FromFile(filePath);
                    pbPhoto.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            ClearForm();
            navigationControl.Display(1);
            var employeesPage = navigationControl.GetControl<EmployeesPage>(1);
            employeesPage.LoadUsers();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userToEdit))
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show($"¿Estás seguro de que deseas eliminar al usuario {userToEdit}?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var client = new UserServiceClient();
                    string response = client.deleteUser(userToEdit);

                    if (response == "Success")
                    {
                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        navigationControl.Display(1);
                        var employeesPage = navigationControl.GetControl<EmployeesPage>(1);
                        employeesPage.LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show($"Error al eliminar el usuario: {response}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPhoto_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pbPhoto.BackgroundImage = Image.FromFile(filePath);
                    pbPhoto.BackgroundImageLayout = ImageLayout.Zoom;

                }
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userToEdit))
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var changes = new Dictionary<string, object>();

            if (txtName.Text != (string)userDetails["name"]) changes.Add("name", txtName.Text);
            if (txtUsername.Text != (string)userDetails["username"]) changes.Add("username", txtUsername.Text);
            if (cbUserType.SelectedItem.ToString() != (string)userDetails["rol"]) changes.Add("rol", cbUserType.SelectedItem.ToString());
            if (!string.IsNullOrEmpty(txtPassword.Text) && txtPassword.Text == txtPassVeri.Text)
                changes.Add("password", txtPassword.Text);

            if (pbPhoto.BackgroundImage != null)
            {
                using (var ms = new MemoryStream())
                {
                    pbPhoto.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    string base64Image = Convert.ToBase64String(ms.ToArray());
                    changes.Add("foto", base64Image);
                }
            }

            if (changes.Count == 0)
            {
                MessageBox.Show("No se detectaron cambios para guardar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Construir la cadena de cambios en el formato clave=valor;clave=valor
            var changeList = changes.Select(kvp => $"{kvp.Key}={kvp.Value}");
            string changesString = string.Join(";", changeList);

            try
            {
                var client = new UserServiceClient();
                string response = client.updateUser(userToEdit, changesString);

                if (response == "Success")
                {
                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    navigationControl.Display(1);
                    var employeesPage = navigationControl.GetControl<EmployeesPage>(1);
                    employeesPage.LoadUsers();
                }
                else
                {
                    MessageBox.Show($"Error al actualizar el usuario: {response}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
