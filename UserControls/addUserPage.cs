using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json.Linq;
using WindowsFormsApp1.ServiceReference2;

namespace PuntuApp.UserControls
{
    public partial class addUserPage : UserControl
    {
        private NavigationControl navigationControl;
        private string username;
        private string role;
        public addUserPage(NavigationControl navigationControl, string username, string role)
        {
            InitializeComponent();
            this.navigationControl = navigationControl;
            this.username = username;
            this.role = role;
        }

        private byte[] GetPhotoBytes()
        {
            if (pbPhoto.Image == null) return null;

            using (var ms = new System.IO.MemoryStream())
            {
                pbPhoto.Image.Save(ms, pbPhoto.Image.RawFormat);
                return ms.ToArray();
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
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearForm();
            navigationControl.Display(1);
            var employeesPage = navigationControl.GetControl<EmployeesPage>(1);
            employeesPage.LoadUsers();
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
                    pbPhoto.Image = Image.FromFile(filePath);
                    pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtPassVeri.Text) ||
                cbUserType.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (txtPassword.Text != txtPassVeri.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Desea agregar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                string name = txtName.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string role = cbUserType.SelectedItem.ToString();
                byte[] photo = GetPhotoBytes();

                string photoBase64 = photo != null ? Convert.ToBase64String(photo) : null;

                var client = new UserServiceClient();
                string response = client.addUser(name, username, password, role, photoBase64);

                if (response == "Success")
                {
                    MessageBox.Show("Usuario agregado correctamente.");
                    ClearForm();
                    btnCancelar_Click(sender, e);// Regresar al menú anterior
                }
                else
                {
                    MessageBox.Show($"Error al agregar el usuario: {response}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
