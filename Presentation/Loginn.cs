using System.Runtime.InteropServices;
using Domain;
using Presentacion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Soporte.Cache;
using Registro;

namespace Presentation
{
    public partial class Loginn : Form
    {
        public Loginn()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {
           // pictureBox3.Image = Image.FromFile(@"C:\Users\iambr\OneDrive\Escritorio\Universidad\AnalisisDiseño\Img\Big_Sale.png");
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                //txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                //txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "USUARIO")
            {
                if (txtpass.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        FormPrincipal mainMenu = new FormPrincipal();
                        MessageBox.Show("Bienvenido " + UserLoginCache.FirstName + ", " + UserLoginCache.LastName);
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Nombre de usuario o contraseña incorrectos. \n Intenta de nuevo.");
                        txtpass.Text = "CONTRASEÑA";
                        txtuser.Focus();
                    }
                }
                else msgError("Ingrese el contraseña.");

            }
            else msgError("Ingrese el usuario.");
        }
        private void msgError(string msg)
        {
            lblErrorMessagge.Text = "       " + msg;
            lblErrorMessagge.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "CONTRASEÑA";
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "USUARIO";
            lblErrorMessagge.Visible = false;
            this.Show();

        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            Register mainMenu = new Register();
            mainMenu.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pbocultar.BringToFront();
            txtpass.PasswordChar = '\0';
        }

        private void Pbocultar_Click(object sender, EventArgs e)
        {
            Pbmostrar.BringToFront();
            txtpass.PasswordChar = '*';
        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoveryPassword = new FormRecuperarPass();
            recoveryPassword.Show();
          

        }
    }
}