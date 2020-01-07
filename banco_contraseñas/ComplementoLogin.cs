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
    public partial class ComplementoLogin : Form
    {
        public ComplementoLogin()
        {
            InitializeComponent();
        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String query;
            query = "exec actualizar_habilitado '" + txtNUsuario.Text.Trim() + "','" + txtNContraseña.Text.Trim() + "'";
            bd.consultar(query);
            MessageBox.Show("usuario y contraseña actualizados correctamente");
            this.Hide();
            new login().Show();
        }
    }
}
