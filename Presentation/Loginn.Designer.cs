namespace Presentation
{
    partial class Loginn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginn));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtuser = new TextBox();
            txtpass = new TextBox();
            label1 = new Label();
            btnlogin = new Button();
            linkpass = new LinkLabel();
            btncerrar = new PictureBox();
            btnminimizar = new PictureBox();
            lblErrorMessagge = new Label();
            btnregistro = new Button();
            Pbocultar = new PictureBox();
            Pbmostrar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pbocultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pbmostrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pato;
            pictureBox3.Location = new Point(12, 60);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(205, 197);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.Black;
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtuser.ForeColor = Color.DimGray;
            txtuser.Location = new Point(345, 101);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(351, 20);
            txtuser.TabIndex = 1;
            txtuser.Text = "USUARIO";
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.Black;
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.ForeColor = Color.DimGray;
            txtpass.Location = new Point(345, 144);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(351, 20);
            txtpass.TabIndex = 2;
            txtpass.Text = "CONTRASEÑA";
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(469, 32);
            label1.Name = "label1";
            label1.Size = new Size(105, 36);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(40, 40, 40);
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.ForeColor = Color.LightGray;
            btnlogin.Location = new Point(345, 217);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(190, 40);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "ACCEDER";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // linkpass
            // 
            linkpass.ActiveLinkColor = Color.Indigo;
            linkpass.AutoSize = true;
            linkpass.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkpass.LinkColor = Color.DimGray;
            linkpass.Location = new Point(417, 272);
            linkpass.Name = "linkpass";
            linkpass.Size = new Size(199, 17);
            linkpass.TabIndex = 0;
            linkpass.TabStop = true;
            linkpass.Text = "¿Ha olvidado su contraseña?";
            linkpass.LinkClicked += linkpass_LinkClicked;
            // 
            // btncerrar
            // 
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(753, 12);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(15, 15);
            btncerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btncerrar.TabIndex = 6;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(734, 14);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(14, 14);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 7;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // lblErrorMessagge
            // 
            lblErrorMessagge.AutoSize = true;
            lblErrorMessagge.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorMessagge.ForeColor = Color.DimGray;
            lblErrorMessagge.Image = (Image)resources.GetObject("lblErrorMessagge.Image");
            lblErrorMessagge.ImageAlign = ContentAlignment.MiddleLeft;
            lblErrorMessagge.Location = new Point(345, 182);
            lblErrorMessagge.Name = "lblErrorMessagge";
            lblErrorMessagge.Size = new Size(37, 16);
            lblErrorMessagge.TabIndex = 9;
            lblErrorMessagge.Text = "Error";
            lblErrorMessagge.Visible = false;
            // 
            // btnregistro
            // 
            btnregistro.BackColor = Color.FromArgb(40, 40, 40);
            btnregistro.FlatAppearance.BorderSize = 0;
            btnregistro.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnregistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnregistro.FlatStyle = FlatStyle.Flat;
            btnregistro.ForeColor = Color.LightGray;
            btnregistro.Location = new Point(541, 217);
            btnregistro.Name = "btnregistro";
            btnregistro.Size = new Size(190, 40);
            btnregistro.TabIndex = 10;
            btnregistro.Text = "REGISTRO";
            btnregistro.UseVisualStyleBackColor = false;
            btnregistro.Click += btnregistro_Click;
            // 
            // Pbocultar
            // 
            Pbocultar.Image = (Image)resources.GetObject("Pbocultar.Image");
            Pbocultar.Location = new Point(711, 144);
            Pbocultar.Name = "Pbocultar";
            Pbocultar.Size = new Size(20, 20);
            Pbocultar.SizeMode = PictureBoxSizeMode.Zoom;
            Pbocultar.TabIndex = 11;
            Pbocultar.TabStop = false;
            Pbocultar.Click += Pbocultar_Click;
            // 
            // Pbmostrar
            // 
            Pbmostrar.Image = (Image)resources.GetObject("Pbmostrar.Image");
            Pbmostrar.Location = new Point(711, 144);
            Pbmostrar.Name = "Pbmostrar";
            Pbmostrar.Size = new Size(20, 20);
            Pbmostrar.SizeMode = PictureBoxSizeMode.Zoom;
            Pbmostrar.TabIndex = 12;
            Pbmostrar.TabStop = false;
            Pbmostrar.Click += pictureBox2_Click;
            // 
            // Loginn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(780, 330);
            Controls.Add(Pbocultar);
            Controls.Add(Pbmostrar);
            Controls.Add(btnregistro);
            Controls.Add(lblErrorMessagge);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(linkpass);
            Controls.Add(btnlogin);
            Controls.Add(label1);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loginn";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pbocultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pbmostrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtuser;
        private TextBox txtpass;
        private Label label1;
        private Button btnlogin;
        private LinkLabel linkpass;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
        private PictureBox pictureBox3;
        private Label lblErrorMessagge;
        private Button btnregistro;
        private PictureBox Pbocultar;
        private PictureBox Pbmostrar;
    }
}