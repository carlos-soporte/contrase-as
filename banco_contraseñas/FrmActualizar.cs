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


        public int id_registro;
        public String entidad, descripcion, usuario, contraseña;

        public FrmActualizar()
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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarGv().Tables[0];
            txt_filtrar.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmActualizar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarGv().Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ComplementoActualizar(id_registro,entidad,descripcion,usuario,contraseña).Show();
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_registro =(int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                entidad=(String) dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                descripcion = (String)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                usuario= (String)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
                contraseña= (String)dataGridView1.Rows[e.RowIndex].Cells[4].Value;

            }
            catch (Exception)
            {

              
            }
        }
    }
}
