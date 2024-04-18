using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySqlX.XDevAPI.Relational;
using System.Xml.Linq;

namespace Presentation
{
    public partial class ModoAdmin : Form
    {
        public ModoAdmin()
        {
            InitializeComponent();
        }

        private void ModoAdmin_Load(object sender, EventArgs e)
        {
            var tam = dgwAdmin.ColumnHeadersHeight;
            foreach (DataGridViewRow dr in dgwAdmin.Rows)
            {
                Height += dr.Height;
            }
            dgwAdmin.Height = Height;

            string connectionString = "Server=BYPANDAPT;DataBase= bank; integrated security= true";
            SqlConnection connection = new SqlConnection(connectionString);

            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", connection);
            //DataSet dataSet = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT UserID, LoginName, FirstName, LastName, Email FROM Users", connection);
            DataSet dataSet = new DataSet();

            connection.Open();
            adapter.Fill(dataSet, "Users");
            connection.Close();

            dgwAdmin.DataSource = dataSet.Tables["Users"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
