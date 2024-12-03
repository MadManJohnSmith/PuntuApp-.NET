using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using PuntuApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntuApp
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        WindowsFormsApp1.ServiceReference1.AuthClient client = new WindowsFormsApp1.ServiceReference1.AuthClient();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            try
            {
                bool isValidUser = client.validarUsuario(username, password);
                if (isValidUser == true)
                {
                    string userConnectionString = $"server=localhost;database=puntuapp;uid={username};pwd={password};";
                    this.Hide();
                    MainPage home = new MainPage(userConnectionString, 1);
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar iniciar sesión: {ex.Message}");
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
