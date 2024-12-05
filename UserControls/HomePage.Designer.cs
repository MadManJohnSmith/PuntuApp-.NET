using System.Drawing;
using System.Windows.Forms;

namespace PuntuApp.UserControls
{
    partial class HomePage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWorkedMonth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRequiredMonth = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLastEntryToday = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWorkedToday = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLastExitToday = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.lblWorkShift = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnCheckInCustom = new System.Windows.Forms.Button();
            this.btnCheckInNow = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(596, 418);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.monthCalendar1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(590, 142);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(339, 3);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(3);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(289, 136);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(139)))), ((int)(((byte)(193)))));
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.lblWorkedMonth, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(283, 62);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // lblWorkedMonth
            // 
            this.lblWorkedMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkedMonth.Font = new System.Drawing.Font("PT Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWorkedMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.lblWorkedMonth.Location = new System.Drawing.Point(3, 0);
            this.lblWorkedMonth.Name = "lblWorkedMonth";
            this.lblWorkedMonth.Size = new System.Drawing.Size(277, 37);
            this.lblWorkedMonth.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("PT Sans", 9.749998F);
            this.label6.Location = new System.Drawing.Point(3, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Trabajado";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(139)))), ((int)(((byte)(193)))));
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.lblRequiredMonth, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 71);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(283, 62);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // lblRequiredMonth
            // 
            this.lblRequiredMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRequiredMonth.Font = new System.Drawing.Font("PT Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRequiredMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.lblRequiredMonth.Location = new System.Drawing.Point(3, 0);
            this.lblRequiredMonth.Name = "lblRequiredMonth";
            this.lblRequiredMonth.Size = new System.Drawing.Size(277, 37);
            this.lblRequiredMonth.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("PT Sans", 9.749998F);
            this.label8.Location = new System.Drawing.Point(3, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Requerido";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel12, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel13, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel14, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 203);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(590, 142);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(139)))), ((int)(((byte)(193)))));
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.lblLastEntryToday, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(289, 65);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // lblLastEntryToday
            // 
            this.lblLastEntryToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastEntryToday.Font = new System.Drawing.Font("PT Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblLastEntryToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.lblLastEntryToday.Location = new System.Drawing.Point(3, 0);
            this.lblLastEntryToday.Name = "lblLastEntryToday";
            this.lblLastEntryToday.Size = new System.Drawing.Size(283, 39);
            this.lblLastEntryToday.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("PT Sans", 9.749998F);
            this.label10.Location = new System.Drawing.Point(3, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Hora Entrada";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(139)))), ((int)(((byte)(193)))));
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.lblWorkedToday, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 74);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(289, 65);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // lblWorkedToday
            // 
            this.lblWorkedToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkedToday.Font = new System.Drawing.Font("PT Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkedToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.lblWorkedToday.Location = new System.Drawing.Point(3, 0);
            this.lblWorkedToday.Name = "lblWorkedToday";
            this.lblWorkedToday.Size = new System.Drawing.Size(283, 39);
            this.lblWorkedToday.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("PT Sans", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(283, 26);
            this.label14.TabIndex = 1;
            this.label14.Text = "Tiempo Total";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(139)))), ((int)(((byte)(193)))));
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.lblLastExitToday, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(298, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(289, 65);
            this.tableLayoutPanel13.TabIndex = 2;
            // 
            // lblLastExitToday
            // 
            this.lblLastExitToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastExitToday.Font = new System.Drawing.Font("PT Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblLastExitToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.lblLastExitToday.Location = new System.Drawing.Point(3, 0);
            this.lblLastExitToday.Name = "lblLastExitToday";
            this.lblLastExitToday.Size = new System.Drawing.Size(283, 39);
            this.lblLastExitToday.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("PT Sans", 9.749998F);
            this.label12.Location = new System.Drawing.Point(3, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(283, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "Hora Salida";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(139)))), ((int)(((byte)(193)))));
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.lblWorkShift, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(298, 74);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(289, 65);
            this.tableLayoutPanel14.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("PT Sans", 9.749998F);
            this.label15.Location = new System.Drawing.Point(3, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(283, 26);
            this.label15.TabIndex = 0;
            this.label15.Text = "Horario Laboral";
            // 
            // lblWorkShift
            // 
            this.lblWorkShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkShift.Font = new System.Drawing.Font("PT Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWorkShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.lblWorkShift.Location = new System.Drawing.Point(3, 0);
            this.lblWorkShift.Name = "lblWorkShift";
            this.lblWorkShift.Size = new System.Drawing.Size(283, 39);
            this.lblWorkShift.TabIndex = 1;
            this.lblWorkShift.Text = "9:00am - 5:00pm";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.31999F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.31999F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.36002F));
            this.tableLayoutPanel8.Controls.Add(this.btnBreak, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnCheckInCustom, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnCheckInNow, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 351);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(590, 64);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.btnBreak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBreak.FlatAppearance.BorderSize = 0;
            this.btnBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreak.Font = new System.Drawing.Font("PT Sans", 8.249999F);
            this.btnBreak.Location = new System.Drawing.Point(395, 3);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(192, 58);
            this.btnBreak.TabIndex = 4;
            this.btnBreak.Text = "Empezar Descanso";
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnCheckInCustom
            // 
            this.btnCheckInCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.btnCheckInCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckInCustom.FlatAppearance.BorderSize = 0;
            this.btnCheckInCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckInCustom.Font = new System.Drawing.Font("PT Sans", 8.249999F);
            this.btnCheckInCustom.Location = new System.Drawing.Point(3, 3);
            this.btnCheckInCustom.Name = "btnCheckInCustom";
            this.btnCheckInCustom.Size = new System.Drawing.Size(190, 58);
            this.btnCheckInCustom.TabIndex = 3;
            this.btnCheckInCustom.Text = "Fichar y Seleccionar Hora";
            this.btnCheckInCustom.UseVisualStyleBackColor = false;
            this.btnCheckInCustom.Click += new System.EventHandler(this.btnCheckInCustom_Click);
            // 
            // btnCheckInNow
            // 
            this.btnCheckInNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.btnCheckInNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckInNow.FlatAppearance.BorderSize = 0;
            this.btnCheckInNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckInNow.Font = new System.Drawing.Font("PT Sans", 8.249999F);
            this.btnCheckInNow.Location = new System.Drawing.Point(199, 3);
            this.btnCheckInNow.Name = "btnCheckInNow";
            this.btnCheckInNow.Size = new System.Drawing.Size(190, 58);
            this.btnCheckInNow.TabIndex = 2;
            this.btnCheckInNow.Text = "Fichar Entrada/Salida";
            this.btnCheckInNow.UseVisualStyleBackColor = false;
            this.btnCheckInNow.Click += new System.EventHandler(this.btnCheckInNow_Click);
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Impact", 15.75F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(590, 26);
            this.label17.TabIndex = 3;
            this.label17.Text = "Resumen Mes";
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Impact", 15.75F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.label18.Location = new System.Drawing.Point(3, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(590, 26);
            this.label18.TabIndex = 4;
            this.label18.Text = "Resumen Hoy";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(596, 418);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private MonthCalendar monthCalendar1;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel9;
        private Label lblWorkedMonth;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel10;
        private Label lblRequiredMonth;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel11;
        private Label lblLastEntryToday;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel12;
        private Label lblWorkedToday;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel13;
        private Label lblLastExitToday;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label15;
        private Label lblWorkShift;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label17;
        private Label label18;
        private Button btnCheckInCustom;
        private Button btnCheckInNow;
        private Button btnBreak;
    }
}
