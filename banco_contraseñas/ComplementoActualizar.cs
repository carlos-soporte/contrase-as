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


        public int id_registro;
        public String entidad, descripcion, usuario, contraseña;
        public ComplementoActualizar(int nid_registro,String nentidad,String ndescripcion,String nusuario,String ncontraseña)
        {
            InitializeComponent();
            id_registro = nid_registro;
            entidad = nentidad;
            descripcion = ndescripcion;
            usuario = nusuario;
            contraseña = ncontraseña;

        }

       

        private void ComplementoActualizar_Load(object sender, EventArgs e)
        {
            txtId.Text =id_registro.ToString();
            txtEntidad.Text = entidad ;
            txtDescripcion.Text = descripcion;
            txtUsuario.Text = usuario;
            txtContraseña.Text = contraseña;
        }

       

        private void RBUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (RBUsuario.Checked == true) 
            {
                txtUsuario.Enabled = true;
                txtContraseña.Enabled = false;

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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String query;
            if(txtUsuario.Text=="" || txtContraseña.Text=="") 
            {
                MessageBox.Show("campos vacios, verifique porfavor");
                return;
            }

            if(RBUsuario.Checked==true && RBAmbos.Checked == false)
            {
                query = "exec editar_usuario " + id_registro + ",'" + txtUsuario.Text.Trim()+"'";
                bd.consultar(query);
                MessageBox.Show("el usuario ha sido actualizado correctamente");
                this.Hide();
                new FrmActualizar().Show();

            }

            else if (RBContraseña.Checked == true && RBAmbos.Checked == false)
            {
                query = "exec editar_contraseña " + id_registro + ",'" + txtContraseña.Text.Trim() + "'";
                bd.consultar(query);
                MessageBox.Show("la contraseña ha sido actualizada correctamente");
                this.Hide();
                new FrmActualizar().Show();
            }
            
            else if (RBAmbos.Checked == true)
            {
                query = "exec editar_duo " + id_registro + ",'" + txtUsuario.Text.Trim() + "','" + txtContraseña.Text.Trim() + "'";
                bd.consultar(query);
                MessageBox.Show("usuario y contraseña actualizado correctamente");
                this.Hide();
                new FrmActualizar().Show();
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
