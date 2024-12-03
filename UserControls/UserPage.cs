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
    public partial class UserPage : UserControl
    {
        private string username;
        private string role;

        public UserPage(string username, string role) // Modified constructor
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
            // ...additional initialization if needed...
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
