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
    public partial class FrmEliminar : FrmConsultar
    {
        public FrmEliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id_registro > 0)
            {
                string query = "exec eliminar_banco " + id_registro;
                bd.consultar(query);
                MessageBox.Show("datos eliminados correctamente");
                dataGridView1.DataSource = llenarGv().Tables[0];
            }
            else
            {
                MessageBox.Show("Error, ninguna entidad seleccionada");
            }
        }
    }
}
