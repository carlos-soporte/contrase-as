namespace banco_contraseñas
{
    partial class lista_opciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lista_opciones));
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnlogoepsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_consultar.Location = new System.Drawing.Point(204, 206);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(146, 35);
            this.btn_consultar.TabIndex = 19;
            this.btn_consultar.Text = "CONSULTAR";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_actualizar.Location = new System.Drawing.Point(204, 249);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(146, 35);
            this.btn_actualizar.TabIndex = 20;
            this.btn_actualizar.Text = "ACTUALIZAR";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_agregar.Location = new System.Drawing.Point(204, 292);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(146, 35);
            this.btn_agregar.TabIndex = 21;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_eliminar.Location = new System.Drawing.Point(204, 335);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(146, 35);
            this.btn_eliminar.TabIndex = 22;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(11, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 72);
            this.button1.TabIndex = 23;
            this.button1.Text = "BANCO DE CONTRASEÑAS EPSI ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(103, 139);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(348, 59);
            this.button2.TabIndex = 24;
            this.button2.Text = "MENÚ PRINCIPAL";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnlogoepsi
            // 
            this.btnlogoepsi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogoepsi.BackgroundImage")));
            this.btnlogoepsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogoepsi.Enabled = false;
            this.btnlogoepsi.Location = new System.Drawing.Point(365, -2);
            this.btnlogoepsi.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogoepsi.Name = "btnlogoepsi";
            this.btnlogoepsi.Size = new System.Drawing.Size(196, 123);
            this.btnlogoepsi.TabIndex = 11;
            this.btnlogoepsi.UseVisualStyleBackColor = true;
            // 
            // lista_opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(560, 399);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btnlogoepsi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "lista_opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expertos Profesionales en Servicios Sociales Integrales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlogoepsi;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}