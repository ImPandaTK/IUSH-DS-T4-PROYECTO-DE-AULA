using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Registro;

namespace Presentation
{
    public partial class FormRecuperarPass : Form
    {
        public FormRecuperarPass()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var user = new UserModel();
            var result = user.recoverPassword(txtInfo.Text);
            lblResultado.Text = result;
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
