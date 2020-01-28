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
                
                bd.consultar(query);
                MessageBox.Show("datos ingresados correctamente");
                txtDescripcion.Text = "";
                txtUsuario.Text = "";
                txtEntidad.Text = "";
                txtClave.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("error vuelve a intentarlo");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta=MessageBox.Show("¿Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show("usted ha salido de la aplicacion");
                Application.Exit();
            }
            else if (respuesta == DialogResult.No)
            {
            }
            else if (respuesta == DialogResult.Cancel)
            {
            }
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new lista_opciones().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
