using ModernGUI_V3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Cache;
using Presentation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {


        int segundosTranscurridos = 0;
        public FormPrincipal()
        {
            InitializeComponent();
            Timer2.Tick += Timer2_Tick;
            Timer2.Interval = 100;
            Timer2.Start();

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUsersData();
            if (UserLoginCache.Position == Positions.usuario)
            {
                btnEditar.Enabled = false;
            }
            MostrarSaldo();
            txtsaldo.ReadOnly = true;
        }
        private void MostrarSaldo()
        {
            using (SqlConnection connection = new SqlConnection("Server=BYPANDAPT;DataBase= bank; integrated security= true"))
            {
                connection.Open();

                string query = "SELECT Saldos FROM Users WHERE Cedula = @Cedula";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Cedula", UserLoginCache.Cedula);
                    object saldo = command.ExecuteScalar();

                    // Verificar si el resultado no es nulo
                    if (saldo != null)
                    {
                        // Aplicar formato "N" para agregar separadores de miles
                        txtsaldo.Text = "$: " + Convert.ToInt32(saldo).ToString("N0");
                    }
                    else
                    {
                        // Manejar el caso en que el saldo sea nulo
                        txtsaldo.Text = "Saldo no encontrado";
                    }

                }
            }

        }
        private void LoadUsersData()
        {
            // pictureBox1.Image = Image.FromFile(@"C:\Users\iambr\OneDrive\Escritorio\Universidad\AnalisisDiseño\Img\pingui.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            lblName.Text = UserLoginCache.FirstName + " " + UserLoginCache.LastName;
            lblCargo.Text = UserLoginCache.Position;
            lblEmail.Text = UserLoginCache.Email;
            lblCodigo.Text = UserLoginCache.Cedula;
            //lblSaldo.Text = UserLoginCache.Saldos;
        }
        #region Funcionalidades del formulario
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Transferencia>();
            btnEnvia.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Compra>();
            btnServicios.BackColor = Color.FromArgb(28, 28, 28);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ModoAdmin>();
            btnServicios.BackColor = Color.FromArgb(28, 28, 28);
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Transferencia"] == null)
                btnEnvia.BackColor = Color.FromArgb(28, 28, 28);
            if (Application.OpenForms["Compra"] == null)
                btnServicios.BackColor = Color.FromArgb(28, 28, 28);
            if (Application.OpenForms["ModoAdmin"] == null)
                btnServicios.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de salir?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        private void Pbocultar_Click_1(object sender, EventArgs e)
        {
            Pbmostrar.BringToFront();
            txtsaldo.PasswordChar = '*';
        }

        private void Pbmostrar_Click(object sender, EventArgs e)
        {
            Pbocultar.BringToFront();
            txtsaldo.PasswordChar = '\0';

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Seleccionar Imagen";
            openFileDialog1.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                byte[] imagenBytes = ImageToByteArray(pictureBox2.Image);
                GuardarImagenEnBD(txtsaldo.Text, imagenBytes);
            }
        }
        private byte[] ImageToByteArray(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void GuardarImagenEnBD(string nombre, byte[] datosImagen)
        {

            string connectionString = "Server=BYPANDAPT;DataBase= bank; integrated security= true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Users (NombreImagen, DatosImagen) VALUES (@NombreImagen, @DatosImagen)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreImagen", nombre);
                    command.Parameters.AddWithValue("@DatosImagen", datosImagen);
                    command.ExecuteNonQuery();
                }
            }
        }


        private void Timer2_Tick(object sender, EventArgs e)
        {
            segundosTranscurridos++;
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            if (segundosTranscurridos % 300 == 0)
            {

                while (true)
                {

                    // Desencolar los elementos de la cola
                    var elemento = ColaManager.Desencolar();
                    if (elemento == (null, null, 0))
                    {
                        break;
                    }

                    lstVisualizar.Items.Remove($"De: {elemento.Item1}");
                    lstVisualizar.Items.Remove($"Para: {elemento.Item2}");
                    lstVisualizar.Items.Remove($"Monto: {elemento.Item3:c0}");
                    lstVisualizar.Items.Remove($"\n");

                    //lstVisualizar.Items.Clear();
                }
               // MessageBox.Show("Se proceso las transeciones", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }

}



