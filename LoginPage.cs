using Newtonsoft.Json;
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
                string jsonResponse = client.validarUsuario(username, password);
                if (jsonResponse != null)
                {
                    // Parse the JSON response
                    var loginData = JsonConvert.DeserializeObject<LoginData>(jsonResponse);
                    // Pass username and role to MainPage
                    this.Hide();
                    MainPage home = new MainPage(loginData.username, loginData.rol);
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
        
        // Define a class to deserialize the JSON response
        private class LoginData
        {
            public string username { get; set; }
            public string rol { get; set; }
        }
    }
}
