namespace banco_contraseñas
{
    partial class ComplementoActualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplementoActualizar));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogoepsi = new System.Windows.Forms.Button();
            this.RBUsuario = new System.Windows.Forms.RadioButton();
            this.RBContraseña = new System.Windows.Forms.RadioButton();
            this.RBAmbos = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(12, 534);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(194, 47);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(212, 534);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 47);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(259, 253);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(170, 40);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(259, 337);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(170, 40);
            this.txtContraseña.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "USUARIO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "CONTRASEÑA :";
            // 
            // btnlogoepsi
            // 
            this.btnlogoepsi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogoepsi.BackgroundImage")));
            this.btnlogoepsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogoepsi.Enabled = false;
            this.btnlogoepsi.Location = new System.Drawing.Point(701, 12);
            this.btnlogoepsi.Name = "btnlogoepsi";
            this.btnlogoepsi.Size = new System.Drawing.Size(307, 351);
            this.btnlogoepsi.TabIndex = 14;
            this.btnlogoepsi.UseVisualStyleBackColor = true;
            // 
            // RBUsuario
            // 
            this.RBUsuario.AutoSize = true;
            this.RBUsuario.Location = new System.Drawing.Point(68, 29);
            this.RBUsuario.Name = "RBUsuario";
            this.RBUsuario.Size = new System.Drawing.Size(159, 37);
            this.RBUsuario.TabIndex = 15;
            this.RBUsuario.TabStop = true;
            this.RBUsuario.Text = "USUARIO";
            this.RBUsuario.UseVisualStyleBackColor = true;
            this.RBUsuario.CheckedChanged += new System.EventHandler(this.RBUsuario_CheckedChanged);
            // 
            // RBContraseña
            // 
            this.RBContraseña.AutoSize = true;
            this.RBContraseña.Location = new System.Drawing.Point(68, 84);
            this.RBContraseña.Name = "RBContraseña";
            this.RBContraseña.Size = new System.Drawing.Size(223, 37);
            this.RBContraseña.TabIndex = 16;
            this.RBContraseña.TabStop = true;
            this.RBContraseña.Text = "CONTRASEÑA";
            this.RBContraseña.UseVisualStyleBackColor = true;
            this.RBContraseña.CheckedChanged += new System.EventHandler(this.RBContraseña_CheckedChanged);
            // 
            // RBAmbos
            // 
            this.RBAmbos.AutoSize = true;
            this.RBAmbos.Location = new System.Drawing.Point(68, 147);
            this.RBAmbos.Name = "RBAmbos";
            this.RBAmbos.Size = new System.Drawing.Size(134, 37);
            this.RBAmbos.TabIndex = 17;
            this.RBAmbos.TabStop = true;
            this.RBAmbos.Text = "AMBOS";
            this.RBAmbos.UseVisualStyleBackColor = true;
            this.RBAmbos.CheckedChanged += new System.EventHandler(this.RBAmbos_CheckedChanged);
            // 
            // ComplementoActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 593);
            this.Controls.Add(this.RBAmbos);
            this.Controls.Add(this.RBContraseña);
            this.Controls.Add(this.RBUsuario);
            this.Controls.Add(this.btnlogoepsi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfirmar);
            this.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "ComplementoActualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComplementoActualizar";
            this.Load += new System.EventHandler(this.ComplementoActualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogoepsi;
        private System.Windows.Forms.RadioButton RBUsuario;
        private System.Windows.Forms.RadioButton RBContraseña;
        private System.Windows.Forms.RadioButton RBAmbos;
    }
}