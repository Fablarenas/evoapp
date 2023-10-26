namespace PlayerUI
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSideMenu = new Panel();
            btnUm = new Button();
            btnUrm = new Button();
            btnDevice = new Button();
            btnSim = new Button();
            btnContrato = new Button();
            btnCups = new Button();
            btnClientes = new Button();
            btnExit = new Button();
            btnGrupos = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelChildForm = new Panel();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.White;
            panelSideMenu.Controls.Add(btnUm);
            panelSideMenu.Controls.Add(btnUrm);
            panelSideMenu.Controls.Add(btnDevice);
            panelSideMenu.Controls.Add(btnSim);
            panelSideMenu.Controls.Add(btnContrato);
            panelSideMenu.Controls.Add(btnCups);
            panelSideMenu.Controls.Add(btnClientes);
            panelSideMenu.Controls.Add(btnExit);
            panelSideMenu.Controls.Add(btnGrupos);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 561);
            panelSideMenu.TabIndex = 0;
            // 
            // btnUm
            // 
            btnUm.BackColor = Color.White;
            btnUm.Dock = DockStyle.Top;
            btnUm.FlatAppearance.BorderSize = 0;
            btnUm.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnUm.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnUm.FlatStyle = FlatStyle.Flat;
            btnUm.ForeColor = Color.Black;
            btnUm.Image = (Image)resources.GetObject("btnUm.Image");
            btnUm.ImageAlign = ContentAlignment.MiddleLeft;
            btnUm.Location = new Point(0, 407);
            btnUm.Name = "btnUm";
            btnUm.Padding = new Padding(5, 0, 0, 0);
            btnUm.Size = new Size(250, 45);
            btnUm.TabIndex = 16;
            btnUm.Text = "  Um";
            btnUm.TextAlign = ContentAlignment.MiddleLeft;
            btnUm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += btnUm_Click;
            // 
            // btnUrm
            // 
            btnUrm.BackColor = Color.White;
            btnUrm.Dock = DockStyle.Top;
            btnUrm.FlatAppearance.BorderSize = 0;
            btnUrm.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnUrm.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnUrm.FlatStyle = FlatStyle.Flat;
            btnUrm.ForeColor = Color.Black;
            btnUrm.Image = (Image)resources.GetObject("btnUrm.Image");
            btnUrm.ImageAlign = ContentAlignment.MiddleLeft;
            btnUrm.Location = new Point(0, 362);
            btnUrm.Name = "btnUrm";
            btnUrm.Padding = new Padding(5, 0, 0, 0);
            btnUrm.Size = new Size(250, 45);
            btnUrm.TabIndex = 15;
            btnUrm.Text = "  Urm";
            btnUrm.TextAlign = ContentAlignment.MiddleLeft;
            btnUrm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUrm.UseVisualStyleBackColor = false;
            btnUrm.Click += btnUrm_Click;
            // 
            // btnDevice
            // 
            btnDevice.BackColor = Color.White;
            btnDevice.Dock = DockStyle.Top;
            btnDevice.FlatAppearance.BorderSize = 0;
            btnDevice.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnDevice.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnDevice.FlatStyle = FlatStyle.Flat;
            btnDevice.ForeColor = Color.Black;
            btnDevice.Image = (Image)resources.GetObject("btnDevice.Image");
            btnDevice.ImageAlign = ContentAlignment.MiddleLeft;
            btnDevice.Location = new Point(0, 317);
            btnDevice.Name = "btnDevice";
            btnDevice.Padding = new Padding(5, 0, 0, 0);
            btnDevice.Size = new Size(250, 45);
            btnDevice.TabIndex = 14;
            btnDevice.Text = "  Dispositivos";
            btnDevice.TextAlign = ContentAlignment.MiddleLeft;
            btnDevice.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDevice.UseVisualStyleBackColor = false;
            btnDevice.Click += btnDevice_Click;
            // 
            // btnSim
            // 
            btnSim.BackColor = Color.White;
            btnSim.Dock = DockStyle.Top;
            btnSim.FlatAppearance.BorderSize = 0;
            btnSim.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnSim.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnSim.FlatStyle = FlatStyle.Flat;
            btnSim.ForeColor = Color.Black;
            btnSim.Image = (Image)resources.GetObject("btnSim.Image");
            btnSim.ImageAlign = ContentAlignment.MiddleLeft;
            btnSim.Location = new Point(0, 272);
            btnSim.Name = "btnSim";
            btnSim.Padding = new Padding(5, 0, 0, 0);
            btnSim.Size = new Size(250, 45);
            btnSim.TabIndex = 13;
            btnSim.Text = "  Sim-Card";
            btnSim.TextAlign = ContentAlignment.MiddleLeft;
            btnSim.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSim.UseVisualStyleBackColor = false;
            btnSim.Click += btnSim_Click;
            // 
            // btnContrato
            // 
            btnContrato.BackColor = Color.White;
            btnContrato.Dock = DockStyle.Top;
            btnContrato.FlatAppearance.BorderSize = 0;
            btnContrato.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnContrato.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnContrato.FlatStyle = FlatStyle.Flat;
            btnContrato.ForeColor = Color.Black;
            btnContrato.Image = (Image)resources.GetObject("btnContrato.Image");
            btnContrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnContrato.Location = new Point(0, 227);
            btnContrato.Name = "btnContrato";
            btnContrato.Padding = new Padding(5, 0, 0, 0);
            btnContrato.Size = new Size(250, 45);
            btnContrato.TabIndex = 12;
            btnContrato.Text = "  Tipos de contrato";
            btnContrato.TextAlign = ContentAlignment.MiddleLeft;
            btnContrato.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnContrato.UseVisualStyleBackColor = false;
            btnContrato.Click += btnContrato_Click;
            // 
            // btnCups
            // 
            btnCups.BackColor = Color.White;
            btnCups.Dock = DockStyle.Top;
            btnCups.FlatAppearance.BorderSize = 0;
            btnCups.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnCups.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnCups.FlatStyle = FlatStyle.Flat;
            btnCups.ForeColor = Color.Black;
            btnCups.Image = (Image)resources.GetObject("btnCups.Image");
            btnCups.ImageAlign = ContentAlignment.MiddleLeft;
            btnCups.Location = new Point(0, 182);
            btnCups.Name = "btnCups";
            btnCups.Padding = new Padding(5, 0, 0, 0);
            btnCups.Size = new Size(250, 45);
            btnCups.TabIndex = 11;
            btnCups.Text = "  Cups";
            btnCups.TextAlign = ContentAlignment.MiddleLeft;
            btnCups.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCups.UseVisualStyleBackColor = false;
            btnCups.Click += btnCups_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.White;
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = Color.Black;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 137);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(5, 0, 0, 0);
            btnClientes.Size = new Size(250, 45);
            btnClientes.TabIndex = 10;
            btnClientes.Text = "  Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Silver;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 516);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(5, 0, 0, 0);
            btnExit.Size = new Size(250, 45);
            btnExit.TabIndex = 9;
            btnExit.Text = "  Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnGrupos
            // 
            btnGrupos.BackColor = Color.White;
            btnGrupos.Dock = DockStyle.Top;
            btnGrupos.FlatAppearance.BorderSize = 0;
            btnGrupos.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnGrupos.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnGrupos.FlatStyle = FlatStyle.Flat;
            btnGrupos.ForeColor = Color.Black;
            btnGrupos.Image = (Image)resources.GetObject("btnGrupos.Image");
            btnGrupos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGrupos.Location = new Point(0, 92);
            btnGrupos.Name = "btnGrupos";
            btnGrupos.Padding = new Padding(5, 0, 0, 0);
            btnGrupos.Size = new Size(250, 45);
            btnGrupos.TabIndex = 5;
            btnGrupos.Text = "  Grupos";
            btnGrupos.TextAlign = ContentAlignment.MiddleLeft;
            btnGrupos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGrupos.UseCompatibleTextRendering = true;
            btnGrupos.UseVisualStyleBackColor = false;
            btnGrupos.Click += btnGrupos_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(86, 130, 112);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 92);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.White;
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(684, 561);
            panelChildForm.TabIndex = 2;
            panelChildForm.Paint += panelChildForm_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(934, 561);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(950, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Button btnGrupos;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Panel panelChildForm;
        private Button btnUrm;
        private Button btnDevice;
        private Button btnSim;
        private Button btnContrato;
        private Button btnCups;
        private Button btnClientes;
        private Button btnUm;
    }
}

