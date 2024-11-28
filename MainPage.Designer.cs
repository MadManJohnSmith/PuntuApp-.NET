using System.Drawing;
using System.Windows.Forms;

namespace PuntuApp
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            Logo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnUsuario = new Button();
            btnHome = new Button();
            btnEmpleados = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            lblState = new Label();
            lblUserInfo = new Label();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Controls.Add(Logo, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Location = new Point(2, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(901, 563);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.Font = new Font("Bauhaus 93", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logo.ForeColor = Color.FromArgb(19, 62, 135);
            Logo.Location = new Point(3, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(194, 75);
            Logo.TabIndex = 0;
            Logo.Text = "PunctuApp";
            Logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(btnUsuario, 0, 2);
            tableLayoutPanel2.Controls.Add(btnHome, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEmpleados, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 78);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(194, 154);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnUsuario
            // 
            btnUsuario.Dock = DockStyle.Fill;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("PT Sans", 11.9999981F, FontStyle.Bold);
            btnUsuario.ForeColor = Color.FromArgb(19, 62, 135);
            btnUsuario.Location = new Point(3, 103);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(188, 48);
            btnUsuario.TabIndex = 2;
            btnUsuario.Text = "Mi Información";
            btnUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("PT Sans", 11.9999981F, FontStyle.Bold);
            btnHome.ForeColor = Color.FromArgb(19, 62, 135);
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(188, 44);
            btnHome.TabIndex = 0;
            btnHome.Text = "Inicio";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Dock = DockStyle.Fill;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("PT Sans", 11.9999981F, FontStyle.Bold);
            btnEmpleados.ForeColor = Color.FromArgb(19, 62, 135);
            btnEmpleados.Location = new Point(3, 53);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(188, 44);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69F));
            tableLayoutPanel3.Controls.Add(pictureBox1, 2, 0);
            tableLayoutPanel3.Controls.Add(lblState, 0, 0);
            tableLayoutPanel3.Controls.Add(lblUserInfo, 1, 0);
            tableLayoutPanel3.Location = new Point(203, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(695, 69);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(626, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblState
            // 
            lblState.Font = new Font("PT Sans", 11.9999981F, FontStyle.Bold);
            lblState.ForeColor = Color.FromArgb(19, 62, 135);
            lblState.Location = new Point(3, 0);
            lblState.Name = "lblState";
            lblState.Padding = new Padding(2);
            lblState.Size = new Size(307, 69);
            lblState.TabIndex = 2;
            lblState.Text = "Estado: ";
            lblState.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUserInfo
            // 
            lblUserInfo.Font = new Font("PT Sans", 11.9999981F, FontStyle.Bold);
            lblUserInfo.ForeColor = Color.FromArgb(19, 62, 135);
            lblUserInfo.Location = new Point(313, 0);
            lblUserInfo.Margin = new Padding(0);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Padding = new Padding(2, 7, 2, 2);
            lblUserInfo.Size = new Size(313, 69);
            lblUserInfo.TabIndex = 1;
            lblUserInfo.Text = "Nombre de Usuario: MadManJohnSmith\r\nID: 00000001\r\n";
            lblUserInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(203, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 482);
            panel1.TabIndex = 4;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 224);
            ClientSize = new Size(904, 561);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(920, 600);
            MinimumSize = new Size(920, 600);
            Name = "MainPage";
            Opacity = 0.99D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PuntuApp";
            Load += MainPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Logo;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox1;
        private Label lblUserInfo;
        private Label lblState;
        private Panel panel1;
        private Button btnHome;
        private Button btnEmpleados;
        private Button btnUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}
