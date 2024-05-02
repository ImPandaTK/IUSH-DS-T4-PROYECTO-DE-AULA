using Soporte.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Presentation
{
    public partial class FormSecretaria : Form
    {
        string connectionString = "Server=BYPANDAPT;DataBase= bank; integrated security= true";

        public FormSecretaria()
        {
            InitializeComponent();
        }

        private void BuscarUsuario(string criterio)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE LoginName = @criterio OR Cedula = @criterio";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@criterio", criterio);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            txtuser2.Text = reader["LoginName"].ToString();
                            txtpass2.Text = reader["Password"].ToString();
                            txtname2.Text = reader["FirstName"].ToString();
                            txtapellido2.Text = reader["LastName"].ToString();
                            lbluser.Text = reader["Position"].ToString();
                            txtemail.Text = reader["Email"].ToString();
                            textBox2.Text = reader["Saldos"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar usuario: " + ex.Message);
                    }
                }
            }
        }

        private void LoadUsersData()
        {
            lblName.Text = UserLoginCache.FirstName + " " + UserLoginCache.LastName;
            lblCargo.Text = UserLoginCache.Position;
            lblEmail.Text = UserLoginCache.Email;
            lblCodigo.Text = UserLoginCache.Cedula;
        }

        private void ActualizarSaldo(string criterio, decimal nuevoSaldo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Saldos = @nuevoSaldo WHERE LoginName = @criterio OR Cedula = @criterio";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nuevoSaldo", nuevoSaldo);
                    command.Parameters.AddWithValue("@criterio", criterio);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Saldo actualizado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el saldo.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar saldo: " + ex.Message);
                    }
                }
            }
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de salir?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void FormSecretaria_Load_1(object sender, EventArgs e)
        {
            LoadUsersData();
        }

        private void btnregistro_Click_1(object sender, EventArgs e)
        {
            string criterio = textBox1.Text.Trim();
            BuscarUsuario(criterio);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string criterio = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(criterio) && decimal.TryParse(textBox2.Text.Trim(), out decimal nuevoSaldo))
            {
                ActualizarSaldo(criterio, nuevoSaldo);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un User válido o una Cedula válido y un nuevo saldo válido.");
            }
        }
    }
}
