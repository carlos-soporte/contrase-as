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
    public partial class lista_opciones : Form
    {
        public lista_opciones()
        {
            InitializeComponent();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmConsultar().Show();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            new FrmAgregar().Show();
            this.Hide();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            new FrmActualizar().Show();
            this.Hide();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            new FrmEliminar().Show();
            this.Hide();
        }
    }
}
