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
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using WindowsFormsApp1.ServiceReference2;

namespace PuntuApp.UserControls
{
    public partial class HomePage : UserControl
    {
        private string username;
        private string role;
        private JObject userDetails;
        private Timer timer;

        public HomePage(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
            LoadUserStats();
            InitializeTimer();
        }

        private void LoadUserStats()
        {

            lblRequiredMonth.Text = "208 hrs";
            if (role == "Administrador") {
                try
                {
                    DateTime now = DateTime.Now;
                    string monthYear = now.ToString("yyyy-MM");

                    var client = new UserServiceClient();
                    string jsonResponse = client.getMonthlyRecords(username, monthYear);

                    var records = JObject.Parse(jsonResponse);

                    TimeSpan workedMonth = TimeSpan.Zero;

                    foreach (var record in records["data"])
                    {
                        if (record["horaEntrada"] != null && record["horaSalida"] != null && record["horaSalida"].ToString() != "null")
                        {
                            DateTime entrada = DateTime.Parse(record["horaEntrada"].ToString());
                            DateTime salida = DateTime.Parse(record["horaSalida"].ToString());
                            workedMonth += salida - entrada;
                        }
                    }

                    lblWorkedMonth.Text = workedMonth.ToString(@"hh\:mm\:ss");

                    DateTime selectedDate = monthCalendar1.SelectionStart.Date;
                    var todayRecords = records["data"].Where(r =>
                        DateTime.Parse(r["fecha"].ToString()).Date == selectedDate);

                    lblLastEntryToday.Text = todayRecords
                        .OrderBy(r => DateTime.Parse(r["horaEntrada"].ToString()))
                        .LastOrDefault()?["horaEntrada"]?.ToString() ?? "N/A";

                    lblLastExitToday.Text = todayRecords
                        .OrderBy(r => DateTime.Parse(r["horaSalida"].ToString()))
                        .LastOrDefault()?["horaSalida"]?.ToString() ?? "N/A";

                    UpdateWorkedToday(todayRecords);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;//1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan workedToday = TimeSpan.Zero;
            TimeSpan workedMonth = TimeSpan.Zero;

            string monthYear = now.ToString("yyyy-MM");

            var client = new UserServiceClient();
            string jsonResponse = client.getMonthlyRecords(username, monthYear);

            var records = JObject.Parse(jsonResponse);

            foreach (var record in records["data"])
            {
                if (record["horaEntrada"] != null && record["horaSalida"] != null && record["horaSalida"].ToString() != "null")
                {
                    DateTime entrada = DateTime.Parse(record["horaEntrada"].ToString());
                    DateTime salida = DateTime.Parse(record["horaSalida"].ToString());
                    workedMonth += salida - entrada;
                }
            }

            lblWorkedMonth.Text = workedMonth.ToString(@"hh\:mm\:ss");

            DateTime selectedDate = monthCalendar1.SelectionStart.Date;
            var todayRecords = records["data"].Where(r =>
                DateTime.Parse(r["fecha"].ToString()).Date == selectedDate);

            UpdateWorkedToday(todayRecords);
        }

        private void UpdateWorkedToday(IEnumerable<JToken> todayRecords)
        {
            DateTime now = DateTime.Now;
            TimeSpan workedToday = TimeSpan.Zero;

            foreach (var record in todayRecords)
            {
                DateTime entrada = DateTime.Parse(record["horaEntrada"].ToString());
                DateTime salida = record["horaSalida"] != null && record["horaSalida"].ToString() != "null"
                    ? DateTime.Parse(record["horaSalida"].ToString())
                    : now;

                workedToday += salida - entrada;
            }

            lblWorkedToday.Text = workedToday.ToString(@"hh\:mm\:ss");
        }
        private void btnCheckInNow_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new UserServiceClient();
                string response = client.checkInOrOutNow(username);

                if (response.Contains("registrada correctamente"))
                {
                    MessageBox.Show(response);
                    LoadUserStats();
                }
                else
                {
                    MessageBox.Show("Error al fichar: " + response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al fichar: " + ex.Message);
            }
        }
        private void btnCheckInCustom_Click(object sender, EventArgs e)
        {
            using (var timePicker = new DateTimePicker())
            {
                timePicker.Format = DateTimePickerFormat.Time;
                timePicker.ShowUpDown = true;

                var form = new Form
                {
                    Text = "Seleccione la hora",
                    StartPosition = FormStartPosition.CenterParent,
                    Width = 200,
                    Height = 100
                };
                form.Controls.Add(timePicker);
                timePicker.Dock = DockStyle.Fill;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    string selectedTime = timePicker.Value.ToString("HH:mm:ss");

                    try
                    {
                        var client = new UserServiceClient();
                        string response = client.checkInOrOutCustom(username, selectedTime);

                        if (response.Contains("registrada correctamente"))
                        {
                            MessageBox.Show(response);
                            LoadUserStats();
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar: " + response);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar: " + ex.Message);
                    }
                }
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new UserServiceClient();
                string response = client.breakTime(username);

                if (response == "Descanso registrado correctamente.")
                {
                    MessageBox.Show(response);
                    LoadUserStats();
                }
                else
                {
                    MessageBox.Show("Error al registrar descanso: " + response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar descanso: " + ex.Message);
            }
        }
    }
}
