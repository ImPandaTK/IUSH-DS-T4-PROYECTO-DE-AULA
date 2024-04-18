namespace ModernGUI_V3
{
    partial class Transferencia
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
            lblEnvia = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnEnviar = new Button();
            btnvolver = new Button();
            txtMonto = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            lstVisualizarT = new ListBox();
            lblCola = new Label();
            SuspendLayout();
            // 
            // lblEnvia
            // 
            lblEnvia.AutoSize = true;
            lblEnvia.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnvia.Location = new Point(142, 76);
            lblEnvia.Margin = new Padding(2, 0, 2, 0);
            lblEnvia.Name = "lblEnvia";
            lblEnvia.Size = new Size(13, 17);
            lblEnvia.TabIndex = 24;
            lblEnvia.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(73, 76);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 23;
            label4.Text = "Persona:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 114);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 22;
            label3.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 149);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 21;
            label2.Text = "Monto";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(40, 40, 40);
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEnviar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.ForeColor = Color.LightGray;
            btnEnviar.Location = new Point(321, 108);
            btnEnviar.Margin = new Padding(4, 3, 4, 3);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(89, 66);
            btnEnviar.TabIndex = 20;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click_1;
            // 
            // btnvolver
            // 
            btnvolver.BackColor = Color.FromArgb(40, 40, 40);
            btnvolver.FlatAppearance.BorderSize = 0;
            btnvolver.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnvolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnvolver.FlatStyle = FlatStyle.Flat;
            btnvolver.ForeColor = Color.LightGray;
            btnvolver.Location = new Point(317, 283);
            btnvolver.Margin = new Padding(4, 3, 4, 3);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(166, 27);
            btnvolver.TabIndex = 19;
            btnvolver.Text = "VOLVER";
            btnvolver.UseVisualStyleBackColor = false;
            btnvolver.Click += btnvolver_Click_1;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(134, 147);
            txtMonto.Margin = new Padding(2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(181, 23);
            txtMonto.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 108);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(193, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 16);
            label1.TabIndex = 16;
            label1.Text = "TRANSFERENCIA";
            // 
            // lstVisualizarT
            // 
            lstVisualizarT.BackColor = Color.BlueViolet;
            lstVisualizarT.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lstVisualizarT.FormattingEnabled = true;
            lstVisualizarT.ItemHeight = 18;
            lstVisualizarT.Location = new Point(503, 42);
            lstVisualizarT.Name = "lstVisualizarT";
            lstVisualizarT.Size = new Size(330, 310);
            lstVisualizarT.TabIndex = 25;
            // 
            // lblCola
            // 
            lblCola.AutoSize = true;
            lblCola.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCola.Location = new Point(503, 12);
            lblCola.Margin = new Padding(2, 0, 2, 0);
            lblCola.Name = "lblCola";
            lblCola.Size = new Size(203, 16);
            lblCola.TabIndex = 27;
            lblCola.Text = "COLA DE TRANSACCIONES";
            // 
            // Transferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(858, 376);
            Controls.Add(lblCola);
            Controls.Add(lstVisualizarT);
            Controls.Add(lblEnvia);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEnviar);
            Controls.Add(btnvolver);
            Controls.Add(txtMonto);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Transferencia";
            Text = "Form1";
            Load += Transferencia_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnvia;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnEnviar;
        private Button btnvolver;
        private TextBox txtMonto;
        private TextBox textBox1;
        private Label label1;
        private ListBox lstVisualizarT;
        private Label lblCola;
    }
}