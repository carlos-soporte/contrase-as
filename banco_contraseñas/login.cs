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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "";
            txt_contraseña.Text = "";
        }

        private void Btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text.Trim() == "" || txt_contraseña.Text.Trim() == "")
            {
                MessageBox.Show("faltan datos por ingresar");
                return;
            }
            try
            {
                string query = "exec consultar_usuario '" + txt_usuario.Text.Trim() + "','" + txt_contraseña.Text.Trim() + "'";
                DataSet ds = bd.consultar(query);

                string usuario = ds.Tables[0].Rows[0]["usuario"].ToString().Trim();
                string contraseña = ds.Tables[0].Rows[0]["contraseña"].ToString().Trim();

                if(txt_usuario.Text.Trim()==usuario  && txt_contraseña.Text.Trim() == contraseña)
                {
                    if (usuario == "gloria" && contraseña == "1234")
                    {
                        MessageBox.Show("datos ingresados correctamente");
                        this.Hide();
                        new ComplementoLogin().Show();
                       
                    }
                    else
                    {
                        MessageBox.Show("¡Datos correctos, bienvenid@!");
                        this.Hide();
                        new lista_opciones().Show();
                    }
                    
                   
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Usuario y/o contraseña erróneos, intentelo de nuevo");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
