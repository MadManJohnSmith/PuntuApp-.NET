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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Logo = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSignOut = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.Controls.Add(this.Logo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 488);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.Logo.Location = new System.Drawing.Point(3, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(165, 65);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "PunctuApp";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnUsuario, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnHome, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEmpleados, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(165, 133);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("PT Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.btnUsuario.Location = new System.Drawing.Point(3, 89);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(161, 41);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Text = "Mi Información";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("PT Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(161, 37);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Inicio";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("PT Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.btnEmpleados.Location = new System.Drawing.Point(3, 46);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(161, 37);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel3.Controls.Add(this.lblSignOut, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblState, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblUserInfo, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(174, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(595, 59);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.account_circle_24dp_1B1925_FILL0_wght400_GRAD0_opsz24;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = global::WindowsFormsApp1.Properties.Resources.account_circle_24dp_133E87_FILL0_wght400_GRAD0_opsz24;
            this.pictureBox1.InitialImage = global::WindowsFormsApp1.Properties.Resources.account_circle_24dp_133E87_FILL0_wght400_GRAD0_opsz24;
            this.pictureBox1.Location = new System.Drawing.Point(536, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblState
            // 
            this.lblState.Font = new System.Drawing.Font("PT Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.lblState.Location = new System.Drawing.Point(3, 0);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new System.Windows.Forms.Padding(2);
            this.lblState.Size = new System.Drawing.Size(202, 59);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Estado: ";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Font = new System.Drawing.Font("PT Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.lblUserInfo.Location = new System.Drawing.Point(208, 0);
            this.lblUserInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Padding = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.lblUserInfo.Size = new System.Drawing.Size(208, 59);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "Nombre de Usuario: MadManJohnSmith\r\nID: 00000001\r\n";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(174, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 417);
            this.panel1.TabIndex = 4;
            // 
            // lblSignOut
            // 
            this.lblSignOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSignOut.Font = new System.Drawing.Font("PT Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.lblSignOut.Location = new System.Drawing.Point(416, 0);
            this.lblSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.lblSignOut.Name = "lblSignOut";
            this.lblSignOut.Padding = new System.Windows.Forms.Padding(2, 6, 2, 2);
            this.lblSignOut.Size = new System.Drawing.Size(120, 59);
            this.lblSignOut.TabIndex = 3;
            this.lblSignOut.Text = "Cerrar Sesion";
            this.lblSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSignOut.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(775, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(791, 525);
            this.MinimumSize = new System.Drawing.Size(791, 525);
            this.Name = "MainPage";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PuntuApp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private Label lblSignOut;
    }
}
