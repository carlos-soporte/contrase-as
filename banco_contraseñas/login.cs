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
    }
}
