using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco_contraseñas
{
    public partial class ComplementoActualizar : Form
    {

        
        public  String[] banco = new String[5];
        public ComplementoActualizar(String [] banco1)
        {
            InitializeComponent();
            banco = banco1;

        }

       

        private void ComplementoActualizar_Load(object sender, EventArgs e)
        {
            txtId.Text =banco[0];
            txtEntidad.Text = banco[1];
            txtDescripcion.Text = banco[2];
            txtUsuario.Text = banco[3];
            txtContraseña.Text = banco[4];
        }

       

        private void RBUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (RBUsuario.Checked == true) 
            {
                txtContraseña.Enabled = false;
                txtUsuario.Enabled = true;
            }
        }

        private void RBContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (RBContraseña.Checked == true)
            {
                txtUsuario.Enabled = false;
                txtContraseña.Enabled = true;
            }
        }

        private void RBAmbos_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAmbos.Checked == true)
            {
                txtUsuario.Enabled = true;
                txtContraseña.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new lista_opciones().Show();
        }

        private void btnlogoepsi_Click(object sender, EventArgs e)
        {

        }
    }
}
