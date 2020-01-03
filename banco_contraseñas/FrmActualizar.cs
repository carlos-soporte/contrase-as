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
    public partial class FrmActualizar : Form
    {
        public FrmActualizar()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new lista_opciones().Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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
            MessageBox.Show("usted ha salido de la aplicacion");
            Application.Exit();
        }
    }
}
