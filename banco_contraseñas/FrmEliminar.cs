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
    public partial class FrmEliminar : Form
    {
        public int id_registro;
        public FrmEliminar()
        {
            InitializeComponent();
        }


        public DataSet llenarGv()
        {

            DataSet ds;

            string query = "EXEC listar_banco";
            ds = bd.consultar(query);

            return ds;
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
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarGv().Tables[0];
            txt_filtrar.Text = "";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_filtrar.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;

                    string query = "EXEC filtrar_banco '" + txt_filtrar.Text + "'";
                    ds = bd.consultar(query);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un error " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_registro = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception)
            {

            }
        }

        private void FrmEliminar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarGv().Tables[0];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string query2;
            if (id_registro > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (respuesta == DialogResult.Yes)
                {
                    query2 = "exec eliminar_banco " + id_registro;
                    bd.consultar(query2);
                    MessageBox.Show("datos eliminados correctamente");
                    dataGridView1.DataSource = llenarGv().Tables[0];
                }
                else if (respuesta == DialogResult.No)
                {
                }
                else if (respuesta == DialogResult.Cancel)
                {
                }
                
                dataGridView1.DataSource = llenarGv().Tables[0];
            }
            else
            {
                MessageBox.Show("Error, ninguna entidad seleccionada");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
