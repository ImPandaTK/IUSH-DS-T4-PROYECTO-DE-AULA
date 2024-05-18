namespace Presentation
{
    partial class ArbolBi
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
            panelTree = new Panel();
            lblMonto = new Label();
            lblUser = new Label();
            txtTransfers = new TextBox();
            txtUserName = new TextBox();
            btnNodo = new Button();
            btnVolver1 = new Button();
            SuspendLayout();
            // 
            // panelTree
            // 
            panelTree.BackgroundImageLayout = ImageLayout.Center;
            panelTree.Location = new Point(12, 12);
            panelTree.Name = "panelTree";
            panelTree.Size = new Size(480, 426);
            panelTree.TabIndex = 5;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(687, 127);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 10;
            lblMonto.Text = "Monto";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(547, 127);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 9;
            lblUser.Text = "Usuario";
            // 
            // txtTransfers
            // 
            txtTransfers.Location = new Point(660, 154);
            txtTransfers.Name = "txtTransfers";
            txtTransfers.Size = new Size(100, 23);
            txtTransfers.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(525, 154);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 7;
            // 
            // btnNodo
            // 
            btnNodo.Location = new Point(516, 393);
            btnNodo.Name = "btnNodo";
            btnNodo.Size = new Size(134, 36);
            btnNodo.TabIndex = 6;
            btnNodo.Text = "AgregarNodo";
            btnNodo.UseVisualStyleBackColor = true;
            btnNodo.Click += btnNodo_Click;
            // 
            // btnVolver1
            // 
            btnVolver1.Location = new Point(660, 393);
            btnVolver1.Name = "btnVolver1";
            btnVolver1.Size = new Size(134, 36);
            btnVolver1.TabIndex = 11;
            btnVolver1.Text = "Volver";
            btnVolver1.UseVisualStyleBackColor = true;
            btnVolver1.Click += btnVolver1_Click;
            // 
            // ArbolBi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(805, 450);
            Controls.Add(btnVolver1);
            Controls.Add(lblMonto);
            Controls.Add(lblUser);
            Controls.Add(txtTransfers);
            Controls.Add(txtUserName);
            Controls.Add(btnNodo);
            Controls.Add(panelTree);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ArbolBi";
            Text = "ArbolBi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelTree;
        private Label lblMonto;
        private Label lblUser;
        private TextBox txtTransfers;
        private TextBox txtUserName;
        private Button btnNodo;
        private Button btnVolver1;
    }
}