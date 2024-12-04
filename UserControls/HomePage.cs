using System;
using System.Windows.Forms;

namespace PuntuApp.UserControls
{
    public partial class HomePage : UserControl
    {
        WindowsFormsApp1.ServiceReference2.UserServiceClient client = new WindowsFormsApp1.ServiceReference2.UserServiceClient();
        private string username;
        private string role;

        public HomePage(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
