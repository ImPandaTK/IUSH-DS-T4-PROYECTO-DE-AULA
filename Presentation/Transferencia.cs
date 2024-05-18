using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;
using Presentacion;
using Presentation;
using Soporte.Cache;

namespace ModernGUI_V3
{
    public partial class Transferencia : Form
    {
        
        private string cadenaConexion = "Server=BYPANDAPT;DataBase= bank; integrated security= true";

        private FormPrincipal formPrincipal;
        public Transferencia(FormPrincipal mainForm)
        {
            InitializeComponent();
            formPrincipal = mainForm;
        }

        public Transferencia()
        {
            InitializeComponent();
        }
        private bool UsuarioExiste(string nombreUsuario)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT COUNT(*) FROM Users WHERE LoginName = @LoginName";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@LoginName", nombreUsuario);
                    return (int)comando.ExecuteScalar() > 0;
                }
            }
        }
        private bool RealizarTransferencia(string usuarioOrigen, string usuarioDestino, int monto)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                // Restar el monto al usuario destino
                string consultaRestar = "UPDATE Users SET Saldos = Saldos - @Monto WHERE LoginName = @LoginName";
                using (SqlCommand comandoRestar = new SqlCommand(consultaRestar, conexion))
                {
                    comandoRestar.Parameters.AddWithValue("@Monto", monto);
                    comandoRestar.Parameters.AddWithValue("@LoginName", usuarioOrigen);
                    comandoRestar.ExecuteNonQuery();
                }


                // Sumar el monto al usuario destino
                string consultaSumar = "UPDATE Users SET Saldos = Saldos + @Saldos WHERE LoginName = @LoginName";
                using (SqlCommand comandoSumar = new SqlCommand(consultaSumar, conexion))
                {
                    comandoSumar.Parameters.AddWithValue("@Saldos", monto);
                    comandoSumar.Parameters.AddWithValue("@LoginName", usuarioDestino);
                    comandoSumar.ExecuteNonQuery();
                }
                return true;
            }
        }
        private void btnvolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Transferencia_Load_1(object sender, EventArgs e)
        {
            lblEnvia.Text = UserLoginCache.LoginName;
        }
        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            int montoTransferencia;

            if (!int.TryParse(txtMonto.Text, out montoTransferencia) || montoTransferencia <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string usuarioDestino = textBox1.Text.Trim();
            string usuarioOrigen = lblEnvia.Text.Trim();
            if (!UsuarioExiste(usuarioDestino))
            {
                MessageBox.Show("El usuario destino no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (RealizarTransferencia(usuarioOrigen, usuarioDestino, montoTransferencia) == true)
            {

                
                MessageBox.Show("Transferencia realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

               

                //Encolar
                ColaManager.Encolar((usuarioOrigen, usuarioDestino, montoTransferencia));
                GlobalTimer.Start(5000);
                //Mostrar Datos
                ActualizarListBox(true);

               

                textBox1.Text = string.Empty;
                txtMonto.Text = string.Empty;


            }
            else
            {
                MessageBox.Show("Error al realizar la transferencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarListBox(bool agregar)
        {
            lstVisualizarT.Items.Clear();
            if (agregar)
            {
                foreach (var item in ColaManager.transferencias)
                {
                    lstVisualizarT.Items.Add($"De: {item.Item1}");
                    lstVisualizarT.Items.Add($"Para: {item.Item2}");
                    lstVisualizarT.Items.Add($"Monto: {item.Item3:c0}");
                    lstVisualizarT.Items.Add($"\n");
                }
            }
            else
            {
                foreach (var item in ColaManager.transferencias)
                {
                    if (lstVisualizarT.Items.Count > 0)
                    {
                        lstVisualizarT.Items.Remove($"De: {item.Item1}");
                        lstVisualizarT.Items.Remove($"Para: {item.Item2}");
                        lstVisualizarT.Items.Remove($"Monto: {item.Item3}");
                    }

                }

            }

        }
    }
}
