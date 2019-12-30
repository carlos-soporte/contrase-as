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
    public partial class FrmAgregar : Form
    {
        public FrmAgregar()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Trim() == "") 
            {
                MessageBox.Show("campos vacios favor ingresarlos");
                return;
            }
            else if (txtDescripcion.Text.Trim() == "") 
            {
                MessageBox.Show("campos vacios favor ingresarlos");
                return;
            }
            else if (txtEntidad.Text.Trim() == "")
            {
                MessageBox.Show("campos vacios favor ingresarlos");
                return;
            }
            else if (txtUsuario.Text.Trim() == "")
            {
            MessageBox.Show ("campos vacios favor ingresarlos");
                return;
            }

            try
            {
                String query ="EXEC insertar_banco '"+txtEntidad.Text.Trim()+"','"+txtDescripcion.Text.Trim()+"','"+ txtUsuario.Text.Trim() + "','" + txtClave.Text.Trim() + "'"; 
                //query += txtUsuario.Text.Trim() + "','" + txtClave.Text.Trim() + "'";
                bd.consultar(query);

            }
            catch (Exception)
            {

                MessageBox.Show("error vuelve a intentarlo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ud ha salido de la aplicacion");
            Dispose();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new lista_opciones().Show();
            this.Hide();
        }
    }
}
