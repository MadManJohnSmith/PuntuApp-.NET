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

            List<UserControl> userControls = new List<UserControl>()
            {
                new HomePage(username, role),//0
                new EmployeesPage(navigationControl, username, role),//1
                new UserPage(username, role), //2
                new addUserPage(navigationControl, username, role),//3
                new editUserPage(navigationControl, username, role)//4
            };


            navigationControl.SetUserControls(userControls);

            navigationControl.Display(0);
            navigationButtons.Highlight(btnHome);
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { btnHome, btnEmpleados, btnUsuario};
            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedtColor);
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

                byte[] fotoBytes = null;

                if (userDetails.Length >= 9 && !string.IsNullOrEmpty(userDetails[8]))
                {
                    fotoBytes = Convert.FromBase64String(userDetails[8]);
                    using (var ms = new MemoryStream(fotoBytes))
                    {
                        pictureBox1.BackgroundImage = Image.FromStream(ms);
                        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    }
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

            if (isClosing) return;

            isClosing = true;

            switch (MessageBox.Show(this, "�Seguro que quieres salir?", "Cerrando...", MessageBoxButtons.YesNo))
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
                navigationControl.Display(2);
                navigationButtons.Highlight(btnUsuario);
            }
        }
    }
}
