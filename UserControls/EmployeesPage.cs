using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using WindowsFormsApp1.ServiceReference2;

namespace PuntuApp.UserControls
{
    partial class EmployeesPage : UserControl
    {
        Color btnDefaultColor = Color.Transparent;
        Color btnSelectedtColor = Color.FromArgb(203, 220, 235);
        private NavigationControl navigationControl;
        private string username;
        private string role;
        private DataTable employeesData;
        public EmployeesPage(NavigationControl navigationControl, string username, string role)
        {
            InitializeComponent();
            this.navigationControl = navigationControl;
            this.role = role;
            HighlightButton(btnID);
            btnID.Click += (s, e) => OrdenarColumna("Username");
            btnNombre.Click += (s, e) => OrdenarColumna("Nombre");
            btnEstado.Click += (s, e) => OrdenarColumna("Rol");
            btnEntrada.Click += (s, e) => OrdenarColumna("Última Entrada");
            btnSalida.Click += (s, e) => OrdenarColumna("Última Salida");
            searchBar.TextChanged += searchBar_TextChanged;
            //FilterSelection.SelectedIndexChanged += FilterSelection_SelectedIndexChanged;
            //txtFilter.TextChanged += txtFilter_TextChanged;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            LoadUsers();
        }

        private void HighlightButton(Button clickedButton)
        {
            btnSalida.BackColor = btnDefaultColor;
            btnEntrada.BackColor = btnDefaultColor;
            btnEstado.BackColor = btnDefaultColor;
            btnNombre.BackColor = btnDefaultColor;
            btnID.BackColor = btnDefaultColor;
            clickedButton.BackColor = btnSelectedtColor;
        }
        private void EmployeesPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }

        public void LoadUsers()
        {
            try
            {

                var client = new UserServiceClient();
                string jsonResponse = client.getUsersWithAttendance();

                JArray userDataArray = JArray.Parse(jsonResponse);
                DataTable userTable = new DataTable();

                userTable.Columns.Add("Username", typeof(string));
                userTable.Columns.Add("Nombre", typeof(string));
                userTable.Columns.Add("Rol", typeof(string));
                userTable.Columns.Add("Última Entrada", typeof(string));
                userTable.Columns.Add("Última Salida", typeof(string));
                userTable.Columns.Add("Estado", typeof(string));

                foreach (var user in userDataArray)
                {
                    String username = (string)user["username"];
                    string name = (string)user["name"];
                    string rol = (string)user["rol"];
                    string estado = (string)user["estado"];
                    string lastEntry = $"{user["lastEntryDate"]} {user["lastEntryTime"]}";
                    string lastExit = $"{user["lastExitDate"]} {user["lastExitTime"]}";

                    userTable.Rows.Add(username, name, rol, lastEntry, lastExit, estado);
                }

                dataGridView1.DataSource = userTable;

                dataGridView1.Columns["Username"].HeaderText = "Nombre de Usuario";
                dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["Rol"].HeaderText = "Rol";
                dataGridView1.Columns["Última Entrada"].HeaderText = "Última Entrada";
                dataGridView1.Columns["Última Salida"].HeaderText = "Última Salida";
                dataGridView1.Columns["Estado"].HeaderText = "Estado";

                dataGridView1.Columns["Nombre"].FillWeight = 22f;
                dataGridView1.Columns["Username"].FillWeight = 17f;
                dataGridView1.Columns["Rol"].FillWeight = 10f;
                dataGridView1.Columns["Última Entrada"].FillWeight = 20f;
                dataGridView1.Columns["Última Salida"].FillWeight = 20f;
                dataGridView1.Columns["Estado"].FillWeight = 10f;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string userEdit = Convert.ToString(row.Cells["Username"].Value);
                var editPage = navigationControl.GetControl<editUserPage>(4);

                editPage.SetUserToEdit(userEdit);

                navigationControl.Display(4);
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            if (employeesData != null)
            {
                string filterExpression = string.Format(
                    "Convert(ID, 'System.String') LIKE '%{0}%' OR " +
                    "name LIKE '%{0}%' OR " +
                    "Username LIKE '%{0}%' OR " +
                    "Estado LIKE '%{0}%'",
                    searchBar.Text);

                DataView dv = new DataView(employeesData);
                dv.RowFilter = filterExpression;
                dataGridView1.DataSource = dv;
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void FilterSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (employeesData != null)
            {
                string selectedField = "";
                string filterText = txtFilter.Text.Replace("'", "''");

                switch (FilterSelection.SelectedItem?.ToString())
                {
                    case "Nombre":
                        selectedField = "name";
                        break;
                    case "Nombre de Usuario":
                        selectedField = "Username";
                        break;
                    case "Estado":
                        selectedField = "Estado";
                        break;
                    default:
                        dataGridView1.DataSource = employeesData;
                        return;
                }

                if (!string.IsNullOrEmpty(filterText))
                {
                    string filterExpression = string.Format("{0} LIKE '%{1}%'", selectedField, filterText);
                    DataView dv = new DataView(employeesData);
                    dv.RowFilter = filterExpression;
                    dataGridView1.DataSource = dv;
                }
            }
            else
            {
                dataGridView1.DataSource = employeesData;
            }
        }

        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            var editPage = navigationControl.GetControl<editUserPage>(4);
            editPage.ClearForm();
            navigationControl.Display(3);
        }

        private void btnID_Click_1(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
        }

        private void btnNombre_Click_1(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
        }

        private void btnEstado_Click_1(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
        }

        private void btnEntrada_Click_1(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
        }

        private void btnSalida_Click_1(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
        }
        private void OrdenarColumna(string columnName)
        {
            try
            {
                if (dataGridView1.Columns[columnName] != null)
                {
                    var sortDirection = dataGridView1.SortOrder == SortOrder.Ascending ?
                        System.ComponentModel.ListSortDirection.Descending :
                        System.ComponentModel.ListSortDirection.Ascending;

                    dataGridView1.Sort(dataGridView1.Columns[columnName], sortDirection);
                }
                else
                {
                    MessageBox.Show($"La columna '{columnName}' no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al ordenar la columna '{columnName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
