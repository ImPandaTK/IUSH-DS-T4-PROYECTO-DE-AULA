namespace Presentation
{
    partial class FormRecuperarPass
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
            label1 = new Label();
            lblResultado = new Label();
            txtInfo = new TextBox();
            btnSend = new Button();
            btnregistro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(128, 32);
            label1.Name = "label1";
            label1.Size = new Size(323, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingresa tu nombre de usuario o correo electrónico: ";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(128, 149);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(69, 19);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Resultado";
            // 
            // txtInfo
            // 
            txtInfo.BackColor = Color.DimGray;
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(128, 65);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(323, 18);
            txtInfo.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(40, 40, 40);
            btnSend.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnSend.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.ForeColor = Color.LightGray;
            btnSend.Location = new Point(492, 87);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 26);
            btnSend.TabIndex = 3;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnregistro
            // 
            btnregistro.BackColor = Color.FromArgb(40, 40, 40);
            btnregistro.FlatAppearance.BorderSize = 0;
            btnregistro.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnregistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnregistro.FlatStyle = FlatStyle.Flat;
            btnregistro.ForeColor = Color.LightGray;
            btnregistro.Location = new Point(492, 119);
            btnregistro.Name = "btnregistro";
            btnregistro.Size = new Size(75, 25);
            btnregistro.TabIndex = 11;
            btnregistro.Text = "Volver";
            btnregistro.UseVisualStyleBackColor = false;
            btnregistro.Click += btnregistro_Click;
            // 
            // FormRecuperarPass
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(679, 330);
            Controls.Add(btnregistro);
            Controls.Add(btnSend);
            Controls.Add(txtInfo);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRecuperarPass";
            Text = "FormRecuperarPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private TextBox txtInfo;
        private Button btnSend;
        private Button btnregistro;
    }
}