using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntuApp.UserControls
{
    public partial class HomePage : UserControl
    {
        private string username;
        private string role;

        public HomePage(string username, string role) // Modified constructor
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
            // ...additional initialization if needed...
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
