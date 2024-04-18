namespace Registro
{
    partial class Register
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtuser2 = new TextBox();
            txtpass2 = new TextBox();
            label1 = new Label();
            btnregistro = new Button();
            btncerrar = new PictureBox();
            btnminimizar = new PictureBox();
            txtname2 = new TextBox();
            txtapellido2 = new TextBox();
            txtemail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbluser = new Label();
            label8 = new Label();
            btnvolver = new Button();
            label6 = new Label();
            label7 = new Label();
            txtCedula = new TextBox();
            lblSaldo = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 381);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(69, 136);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(133, 104);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtuser2
            // 
            txtuser2.BackColor = Color.Black;
            txtuser2.BorderStyle = BorderStyle.None;
            txtuser2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtuser2.ForeColor = Color.DimGray;
            txtuser2.Location = new Point(691, 167);
            txtuser2.Margin = new Padding(4, 3, 4, 3);
            txtuser2.Name = "txtuser2";
            txtuser2.Size = new Size(105, 20);
            txtuser2.TabIndex = 5;
            txtuser2.Text = "Usuario";
            txtuser2.Enter += txtuser_Enter;
            txtuser2.Leave += txtuser_Leave;
            // 
            // txtpass2
            // 
            txtpass2.BackColor = Color.Black;
            txtpass2.BorderStyle = BorderStyle.None;
            txtpass2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass2.ForeColor = Color.DimGray;
            txtpass2.Location = new Point(734, 214);
            txtpass2.Margin = new Padding(4, 3, 4, 3);
            txtpass2.Name = "txtpass2";
            txtpass2.Size = new Size(119, 20);
            txtpass2.TabIndex = 6;
            txtpass2.Text = "Contraseña";
            txtpass2.Enter += txtpass_Enter;
            txtpass2.Leave += txtpass_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(507, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 4;
            label1.Text = "REGISTRO";
            // 
            // btnregistro
            // 
            btnregistro.BackColor = Color.FromArgb(40, 40, 40);
            btnregistro.FlatAppearance.BorderSize = 0;
            btnregistro.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnregistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnregistro.FlatStyle = FlatStyle.Flat;
            btnregistro.ForeColor = Color.LightGray;
            btnregistro.Location = new Point(602, 295);
            btnregistro.Margin = new Padding(4, 3, 4, 3);
            btnregistro.Name = "btnregistro";
            btnregistro.Size = new Size(194, 46);
            btnregistro.TabIndex = 7;
            btnregistro.Text = "REGISTRARSE";
            btnregistro.UseVisualStyleBackColor = false;
            btnregistro.Click += btnregistro_Click;
            // 
            // btncerrar
            // 
            btncerrar.Cursor = Cursors.Hand;
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(888, 3);
            btncerrar.Margin = new Padding(4, 3, 4, 3);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(18, 17);
            btncerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btncerrar.TabIndex = 7;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Cursor = Cursors.Hand;
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(863, 3);
            btnminimizar.Margin = new Padding(4, 3, 4, 3);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(16, 16);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 8;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // txtname2
            // 
            txtname2.BackColor = Color.Black;
            txtname2.BorderStyle = BorderStyle.None;
            txtname2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtname2.ForeColor = Color.DimGray;
            txtname2.Location = new Point(451, 118);
            txtname2.Margin = new Padding(4, 3, 4, 3);
            txtname2.Name = "txtname2";
            txtname2.Size = new Size(119, 20);
            txtname2.TabIndex = 1;
            txtname2.Text = "Nombre";
            // 
            // txtapellido2
            // 
            txtapellido2.BackColor = Color.Black;
            txtapellido2.BorderStyle = BorderStyle.None;
            txtapellido2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtapellido2.ForeColor = Color.DimGray;
            txtapellido2.Location = new Point(452, 166);
            txtapellido2.Margin = new Padding(4, 3, 4, 3);
            txtapellido2.Name = "txtapellido2";
            txtapellido2.Size = new Size(119, 20);
            txtapellido2.TabIndex = 2;
            txtapellido2.Text = "Apellido";
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.Black;
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.ForeColor = Color.DimGray;
            txtemail.Location = new Point(691, 117);
            txtemail.Margin = new Padding(4, 3, 4, 3);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(119, 20);
            txtemail.TabIndex = 4;
            txtemail.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(602, 166);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 12;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(602, 214);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 13;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(354, 117);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 14;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(354, 167);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 15;
            label5.Text = "Apellido:";
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.BackColor = Color.Black;
            lbluser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbluser.ForeColor = Color.IndianRed;
            lbluser.Location = new Point(428, 351);
            lbluser.Margin = new Padding(4, 0, 4, 0);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(66, 21);
            lbluser.TabIndex = 5;
            lbluser.Text = "Usuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(602, 117);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(67, 21);
            label8.TabIndex = 18;
            label8.Text = "Correo:";
            // 
            // btnvolver
            // 
            btnvolver.BackColor = Color.FromArgb(40, 40, 40);
            btnvolver.FlatAppearance.BorderSize = 0;
            btnvolver.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnvolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnvolver.FlatStyle = FlatStyle.Flat;
            btnvolver.ForeColor = Color.LightGray;
            btnvolver.Location = new Point(376, 295);
            btnvolver.Margin = new Padding(4, 3, 4, 3);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(194, 46);
            btnvolver.TabIndex = 8;
            btnvolver.Text = "VOLVER";
            btnvolver.UseVisualStyleBackColor = false;
            btnvolver.Click += btnvolver_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(344, 350);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 16;
            label6.Text = "Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(354, 219);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 21;
            label7.Text = "Cédula:";
            // 
            // txtCedula
            // 
            txtCedula.BackColor = Color.Black;
            txtCedula.BorderStyle = BorderStyle.None;
            txtCedula.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCedula.ForeColor = Color.DimGray;
            txtCedula.Location = new Point(443, 219);
            txtCedula.Margin = new Padding(4, 3, 4, 3);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(119, 20);
            txtCedula.TabIndex = 3;
            txtCedula.Text = "Cédula";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.Black;
            lblSaldo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.IndianRed;
            lblSaldo.Location = new Point(587, 350);
            lblSaldo.Margin = new Padding(4, 0, 4, 0);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(19, 21);
            lblSaldo.TabIndex = 22;
            lblSaldo.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Black;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.IndianRed;
            label10.Location = new Point(522, 349);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(57, 21);
            label10.TabIndex = 23;
            label10.Text = "Saldo:";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(910, 381);
            Controls.Add(lblSaldo);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(txtCedula);
            Controls.Add(btnvolver);
            Controls.Add(label8);
            Controls.Add(lbluser);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtemail);
            Controls.Add(txtapellido2);
            Controls.Add(txtname2);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(btnregistro);
            Controls.Add(label1);
            Controls.Add(txtpass2);
            Controls.Add(txtuser2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Register";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtuser2;
        private TextBox txtpass2;
        private Label label1;
        private Button btnregistro;
        private PictureBox pictureBox3;
        private PictureBox btncerrar;
        private PictureBox btnminimizar;
        private TextBox txtname2;
        private TextBox txtapellido2;
        private TextBox txtemail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbluser;
        private Label label8;
        private Button btnvolver;
        private Label label6;
        private Label label7;
        private TextBox txtCedula;
        private Label lblSaldo;
        private Label label10;
    }
}

