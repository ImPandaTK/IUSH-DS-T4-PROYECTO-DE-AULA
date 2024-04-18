using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;
using Presentacion;
using Soporte.Cache;
using Presentation;
using System.Data;
using System.Data.SqlClient;

namespace Registro
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }


        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Placeholder or WaterMark
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser2.Text == "Usuario")
            {
                txtuser2.Text = "";
                txtuser2.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser2.Text == "")
            {
                txtuser2.Text = "Usuario";
                txtuser2.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass2.Text == "Contraseña")
            {
                txtpass2.Text = "";
                txtpass2.ForeColor = Color.LightGray;
                txtpass2.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass2.Text == "")
            {
                txtpass2.Text = "Contraseña";
                txtpass2.ForeColor = Color.Silver;
                txtpass2.UseSystemPasswordChar = false;
            }
        }

        #endregion 

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox3.Image = Image.FromFile(@"C:\Users\iambr\OneDrive\Escritorio\Universidad\AnalisisDiseño\Img\pato.gif");
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=BYPANDAPT;DataBase= bank; integrated security= true";
            SqlConnection connection = new SqlConnection(connectionString);

            using (SqlConnection r = new SqlConnection(connectionString))
            {
                r.Open();

                string query = "INSERT INTO Users (LoginName, Password, FirstName, LastName, Position, Email, Saldos, Cedula) VALUES (@LoginName, @Password, @FirstName, @LastName, @Position, @Email, @Saldos, @Cedula)";

                using (SqlCommand command = new SqlCommand(query, r))
                {
                    command.Parameters.AddWithValue("@LoginName", txtuser2.Text);
                    command.Parameters.AddWithValue("@Password", txtpass2.Text);
                    command.Parameters.AddWithValue("@FirstName", txtname2.Text);
                    command.Parameters.AddWithValue("@LastName", txtapellido2.Text);
                    command.Parameters.AddWithValue("@Position", lbluser.Text);
                    command.Parameters.AddWithValue("@Email", txtemail.Text);
                    command.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                    command.Parameters.AddWithValue("@Saldos", lblSaldo.Text);


                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Registro exitoso.");

                Loginn mainMenu = new Loginn();
                mainMenu.Show();
                this.Hide();
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Loginn mv = new Loginn();
            mv.Show();
            this.Close();
        }
    }
}
