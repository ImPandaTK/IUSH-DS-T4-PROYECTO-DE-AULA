namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelContenedor = new Panel();
            panelformularios = new Panel();
            lblCola = new Label();
            lstVisualizar = new ListBox();
            lblHora = new Label();
            txtsaldo = new TextBox();
            pictureBox1 = new PictureBox();
            Pbocultar = new PictureBox();
            Pbmostrar = new PictureBox();
            panelMenu = new Panel();
            btnEditar = new Button();
            panelUser = new Panel();
            btnsave = new Button();
            btnCargar = new Button();
            pictureBox2 = new PictureBox();
            lblCodigo = new Label();
            lblCargo = new Label();
            lblEmail = new Label();
            lblName = new Label();
            btnExit = new Button();
            btnServicios = new Button();
            btnEnvia = new Button();
            panelBarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnCerrar = new PictureBox();
            Timer2 = new System.Windows.Forms.Timer(components);
            panelContenedor.SuspendLayout();
            panelformularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pbocultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pbmostrar).BeginInit();
            panelMenu.SuspendLayout();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ActiveCaption;
            panelContenedor.Controls.Add(panelformularios);
            panelContenedor.Controls.Add(panelMenu);
            panelContenedor.Controls.Add(panelBarraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Margin = new Padding(2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1192, 620);
            panelContenedor.TabIndex = 0;
            // 
            // panelformularios
            // 
            panelformularios.BackColor = Color.Indigo;
            panelformularios.Controls.Add(lblCola);
            panelformularios.Controls.Add(lstVisualizar);
            panelformularios.Controls.Add(lblHora);
            panelformularios.Controls.Add(txtsaldo);
            panelformularios.Controls.Add(pictureBox1);
            panelformularios.Controls.Add(Pbocultar);
            panelformularios.Controls.Add(Pbmostrar);
            panelformularios.Dock = DockStyle.Fill;
            panelformularios.Location = new Point(234, 39);
            panelformularios.Margin = new Padding(2);
            panelformularios.Name = "panelformularios";
            panelformularios.Size = new Size(958, 581);
            panelformularios.TabIndex = 2;
            // 
            // lblCola
            // 
            lblCola.AutoSize = true;
            lblCola.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCola.Location = new Point(645, 117);
            lblCola.Margin = new Padding(2, 0, 2, 0);
            lblCola.Name = "lblCola";
            lblCola.Size = new Size(163, 16);
            lblCola.TabIndex = 28;
            lblCola.Text = "COLAS PROCESADAS\r\n";
            // 
            // lstVisualizar
            // 
            lstVisualizar.BackColor = Color.BlueViolet;
            lstVisualizar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lstVisualizar.FormattingEnabled = true;
            lstVisualizar.ItemHeight = 18;
            lstVisualizar.Location = new Point(645, 147);
            lstVisualizar.Name = "lstVisualizar";
            lstVisualizar.Size = new Size(260, 364);
            lstVisualizar.TabIndex = 28;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.ForeColor = SystemColors.ButtonHighlight;
            lblHora.Location = new Point(826, 24);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(58, 30);
            lblHora.TabIndex = 18;
            lblHora.Text = "Hora";
            // 
            // txtsaldo
            // 
            txtsaldo.BackColor = Color.BlueViolet;
            txtsaldo.BorderStyle = BorderStyle.None;
            txtsaldo.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtsaldo.ForeColor = Color.Black;
            txtsaldo.Location = new Point(203, 126);
            txtsaldo.Name = "txtsaldo";
            txtsaldo.ReadOnly = true;
            txtsaldo.Size = new Size(187, 36);
            txtsaldo.TabIndex = 16;
            txtsaldo.Text = "--";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Presentation.Properties.Resources.pingui;
            pictureBox1.Location = new Point(141, 214);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Pbocultar
            // 
            Pbocultar.Image = (Image)resources.GetObject("Pbocultar.Image");
            Pbocultar.Location = new Point(396, 129);
            Pbocultar.Name = "Pbocultar";
            Pbocultar.Size = new Size(32, 33);
            Pbocultar.SizeMode = PictureBoxSizeMode.Zoom;
            Pbocultar.TabIndex = 13;
            Pbocultar.TabStop = false;
            Pbocultar.Click += Pbocultar_Click_1;
            // 
            // Pbmostrar
            // 
            Pbmostrar.Image = (Image)resources.GetObject("Pbmostrar.Image");
            Pbmostrar.Location = new Point(396, 129);
            Pbmostrar.Name = "Pbmostrar";
            Pbmostrar.Size = new Size(32, 33);
            Pbmostrar.SizeMode = PictureBoxSizeMode.Zoom;
            Pbmostrar.TabIndex = 14;
            Pbmostrar.TabStop = false;
            Pbmostrar.Click += Pbmostrar_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(btnEditar);
            panelMenu.Controls.Add(panelUser);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnServicios);
            panelMenu.Controls.Add(btnEnvia);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 39);
            panelMenu.Margin = new Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(234, 581);
            panelMenu.TabIndex = 1;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(2, 357);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(192, 87);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "EDITAR";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button4_Click;
            // 
            // panelUser
            // 
            panelUser.BackColor = Color.FromArgb(64, 64, 64);
            panelUser.Controls.Add(btnsave);
            panelUser.Controls.Add(btnCargar);
            panelUser.Controls.Add(pictureBox2);
            panelUser.Controls.Add(lblCodigo);
            panelUser.Controls.Add(lblCargo);
            panelUser.Controls.Add(lblEmail);
            panelUser.Controls.Add(lblName);
            panelUser.Location = new Point(0, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(234, 174);
            panelUser.TabIndex = 3;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.Gray;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnsave.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnsave.ForeColor = Color.White;
            btnsave.ImageAlign = ContentAlignment.MiddleLeft;
            btnsave.Location = new Point(129, 56);
            btnsave.Margin = new Padding(2);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(101, 28);
            btnsave.TabIndex = 18;
            btnsave.Text = "Guardar Img";
            btnsave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += button2_Click_1;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.Gray;
            btnCargar.FlatAppearance.BorderSize = 0;
            btnCargar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCargar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargar.ForeColor = Color.White;
            btnCargar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargar.Location = new Point(129, 24);
            btnCargar.Margin = new Padding(2);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(101, 28);
            btnCargar.TabIndex = 5;
            btnCargar.Text = "Cargar Img";
            btnCargar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = Color.White;
            lblCodigo.Location = new Point(12, 147);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Codigo";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.ForeColor = Color.White;
            lblCargo.Location = new Point(12, 102);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 0;
            lblCargo.Text = "Cargo";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(12, 132);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(43, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Correo";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(12, 117);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre";
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(12, 487);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(195, 83);
            btnExit.TabIndex = 2;
            btnExit.Text = "SALIDA";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button3_Click;
            // 
            // btnServicios
            // 
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnServicios.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnServicios.ForeColor = Color.White;
            btnServicios.Image = (Image)resources.GetObject("btnServicios.Image");
            btnServicios.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicios.Location = new Point(2, 266);
            btnServicios.Margin = new Padding(2);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(192, 87);
            btnServicios.TabIndex = 1;
            btnServicios.Text = "SERVICIOS";
            btnServicios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += button2_Click;
            // 
            // btnEnvia
            // 
            btnEnvia.FlatAppearance.BorderSize = 0;
            btnEnvia.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEnvia.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEnvia.FlatStyle = FlatStyle.Flat;
            btnEnvia.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnvia.ForeColor = Color.White;
            btnEnvia.Image = (Image)resources.GetObject("btnEnvia.Image");
            btnEnvia.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnvia.Location = new Point(2, 179);
            btnEnvia.Margin = new Padding(2);
            btnEnvia.Name = "btnEnvia";
            btnEnvia.Size = new Size(195, 83);
            btnEnvia.TabIndex = 0;
            btnEnvia.Text = "METIENDING\r\nMONEY\r\n";
            btnEnvia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEnvia.UseVisualStyleBackColor = true;
            btnEnvia.Click += button1_Click;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = Color.Black;
            panelBarraTitulo.Controls.Add(btnRestaurar);
            panelBarraTitulo.Controls.Add(btnCerrar);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Margin = new Padding(2);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(1192, 39);
            panelBarraTitulo.TabIndex = 0;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1128, 10);
            btnRestaurar.Margin = new Padding(2);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(23, 23);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1156, 10);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 23);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Timer2
            // 
            Timer2.Tick += Timer2_Tick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 620);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            MinimumSize = new Size(569, 375);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormPrincipal_Load;
            panelContenedor.ResumeLayout(false);
            panelformularios.ResumeLayout(false);
            panelformularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pbocultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pbmostrar).EndInit();
            panelMenu.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panelBarraTitulo;
        private PictureBox btnRestaurar;
        private PictureBox btnCerrar;
        private Panel panelUser;
        private Label lblEmail;
        private Label lblName;
        private Label lblCargo;
        private Label lblCodigo;
        private Button btnCargar;
        private PictureBox pictureBox2;
        private Button btnsave;
        private Panel panelformularios;
        private TextBox txtsaldo;
        private PictureBox pictureBox1;
        private PictureBox Pbocultar;
        private PictureBox Pbmostrar;
        private Panel panelMenu;
        private Button btnEditar;
        private Button btnExit;
        private Button btnServicios;
        private Button btnEnvia;
        private System.Windows.Forms.Timer Timer2;
        private Label lblHora;
        private ListBox lstVisualizar;
        private Label lblCola;
    }
}

