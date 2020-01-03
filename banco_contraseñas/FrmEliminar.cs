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
                DialogResult respuesta = MessageBox.Show("¿seguro què desea eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (respuesta == DialogResult.Yes)
                {
                    string query = "exec eliminar_banco " + id_registro;
                    bd.consultar(query);
                    MessageBox.Show("datos eliminados correctamente");
                    dataGridView1.DataSource = llenarGv().Tables[0];
                }
                else if (respuesta == DialogResult.No)
                {

                }
                else if (respuesta == DialogResult.Cancel)
                {

                }
                
            }
            else
            {
                MessageBox.Show("Error, ninguna entidad seleccionada");
            }
        }
    }
}
