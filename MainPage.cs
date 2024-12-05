using Calculadora_Areas_Perimetros;
using PuntuApp.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference2;


namespace PuntuApp
{
    public partial class MainPage : Form
    {
        private bool isClosing = false;
        private bool isLoggingOut = false;

        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btnDefaultColor = Color.Transparent;
        Color btnSelectedtColor = Color.FromArgb(203, 220, 235);

        private string username;
        private string role;
        public MainPage(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
            InitializeNavigationButtons();
            InitializeNavigationControl();
            LoadUserDetails(username);
        }
        private void InitializeNavigationControl()
        {
            navigationControl = new NavigationControl(new List<UserControl>(), panel1);

            if (role == "Administrador")
            {
                List<UserControl> userControls = new List<UserControl>()
                {
                    new HomePage(username, role),// 0
                    new EmployeesPage(navigationControl, username, role),// 1
                    new UserPage(username, role),// 2
                    new addUserPage(navigationControl, username, role),// 3
                    new editUserPage(navigationControl, username, role)// 4
                };
                navigationControl.SetUserControls(userControls);
            }
            else if (role == "Empleado")
            {
                List<UserControl> userControls = new List<UserControl>()
                {
                    new HomePage(username, role),// 0
                    new UserPage(username, role)// 1
                };
                navigationControl.SetUserControls(userControls);
            }

            navigationControl.Display(0);
            navigationButtons.Highlight(btnHome);
        }

        private void InitializeNavigationButtons()
        {
            if (role == "Administrador")
            {
                List<Button> buttons = new List<Button>()
                { 
                    btnHome, btnEmpleados, btnUsuario
                };
                navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedtColor);
            }
            else if (role == "Empleado")
            {
                List<Button> buttons = new List<Button>()
                { 
                    btnHome, btnUsuario
                };
                navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedtColor);
                btnEmpleados.Visible = false;
            }
        }

        public void LoadUserDetails(string username)
        {
            try
            {
                var client = new UserServiceClient();
                string[] userDetails = client.getUserDetails(username);

                if (userDetails != null && userDetails.Length >= 4)
                {
                    
                    lblState.Text = "Estado: " + userDetails[3];
                    lblUserInfo.Text = "Usuario: " + userDetails[0] + "\n" + userDetails[2];
                }
                else
                {
                    MessageBox.Show("No se encontraron detalles para el usuario.");
                }

                if (userDetails.Length >= 9 && !string.IsNullOrEmpty(userDetails[8]))
                {
                    try
                    {
                        byte[] fotoBytes = Convert.FromBase64String(userDetails[8]);
                        using (var ms = new MemoryStream(fotoBytes))
                        {
                            pictureBox1.BackgroundImage = Image.FromStream(ms);
                            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }
                    catch (Exception ex)
                    {
                        pictureBox1.BackgroundImage = null;
                        Console.WriteLine("Error al cargar la foto de usuario: " + ex.Message);
                    }
                }
                else
                {
                    pictureBox1.BackgroundImage = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles del usuario: " + ex.Message);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (isLoggingOut)
            {
                return;
            }

            if (isClosing) return;

            isClosing = true;

            switch (MessageBox.Show(this, "¿Seguro que quieres salir?", "Cerrando...", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    isClosing = false;
                    break;
                default:
                    break;
            }
        }

        private void btnEmpleados_Click_1(object sender, EventArgs e)
        {
            if (role != "Administrador")
            {
                MessageBox.Show("No tienes acceso a esta página.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (navigationControl != null)
            {
                navigationControl.Display(1);
                navigationButtons.Highlight(btnEmpleados);
            }
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            if (navigationControl != null)
            {
                navigationControl.Display(0);
                navigationButtons.Highlight(btnHome);
            }
        }

        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            if (navigationControl != null)
            {
                if (role == "Administrador")
                {
                    navigationControl.Display(2);//UserPage Administrador
                }
                else if (role == "Empleado")
                {
                    navigationControl.Display(1);//UserPage Empleado
                }
                navigationButtons.Highlight(btnUsuario);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            isLoggingOut = true;//Se agrega para evitar que se cierre por completo la app al cerrar sesión
            this.Close();

            var loginPage = this.Owner as LoginPage;
            if (loginPage != null)
            {
                loginPage.ClearFields();
                loginPage.Show();
            }
            else
            {
                loginPage = new LoginPage();
                loginPage.Show();
            }
        }
    }
}
