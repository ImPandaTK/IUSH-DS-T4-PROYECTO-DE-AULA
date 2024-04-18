namespace Presentation
{
    partial class ModoAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgwAdmin = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwAdmin).BeginInit();
            SuspendLayout();
            // 
            // dgwAdmin
            // 
            dgwAdmin.AllowUserToAddRows = false;
            dgwAdmin.BorderStyle = BorderStyle.None;
            dgwAdmin.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgwAdmin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgwAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgwAdmin.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgwAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            dgwAdmin.EnableHeadersVisualStyles = false;
            dgwAdmin.Location = new Point(12, 11);
            dgwAdmin.Name = "dgwAdmin";
            dgwAdmin.ReadOnly = true;
            dgwAdmin.RowHeadersVisible = false;
            dgwAdmin.RowTemplate.Height = 25;
            dgwAdmin.Size = new Size(603, 342);
            dgwAdmin.TabIndex = 0;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(629, 11);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(105, 38);
            button3.TabIndex = 3;
            button3.Text = "SALIDA";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ModoAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(726, 450);
            Controls.Add(button3);
            Controls.Add(dgwAdmin);
            Name = "ModoAdmin";
            Text = "ModoAdmin";
            Load += ModoAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgwAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwAdmin;
        private Button button3;
    }
}