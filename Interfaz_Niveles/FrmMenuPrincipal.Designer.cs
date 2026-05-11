namespace Interfaz_Niveles
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenuSuma = new System.Windows.Forms.Button();
            this.btnMenuResta = new System.Windows.Forms.Button();
            this.btnMenuMultiplicacion = new System.Windows.Forms.Button();
            this.btnMenuDivision = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-25, -48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenuSuma
            // 
            this.btnMenuSuma.BackColor = System.Drawing.Color.Salmon;
            this.btnMenuSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSuma.Location = new System.Drawing.Point(246, 285);
            this.btnMenuSuma.Name = "btnMenuSuma";
            this.btnMenuSuma.Size = new System.Drawing.Size(82, 32);
            this.btnMenuSuma.TabIndex = 1;
            this.btnMenuSuma.Text = "Jugar";
            this.btnMenuSuma.UseVisualStyleBackColor = false;
            this.btnMenuSuma.Click += new System.EventHandler(this.btnMenuSuma_Click);
            // 
            // btnMenuResta
            // 
            this.btnMenuResta.BackColor = System.Drawing.Color.Salmon;
            this.btnMenuResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuResta.Location = new System.Drawing.Point(533, 285);
            this.btnMenuResta.Name = "btnMenuResta";
            this.btnMenuResta.Size = new System.Drawing.Size(82, 32);
            this.btnMenuResta.TabIndex = 2;
            this.btnMenuResta.Text = "Jugar";
            this.btnMenuResta.UseVisualStyleBackColor = false;
            this.btnMenuResta.Click += new System.EventHandler(this.btnMenuResta_Click);
            // 
            // btnMenuMultiplicacion
            // 
            this.btnMenuMultiplicacion.BackColor = System.Drawing.Color.Salmon;
            this.btnMenuMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMultiplicacion.Location = new System.Drawing.Point(246, 493);
            this.btnMenuMultiplicacion.Name = "btnMenuMultiplicacion";
            this.btnMenuMultiplicacion.Size = new System.Drawing.Size(82, 32);
            this.btnMenuMultiplicacion.TabIndex = 3;
            this.btnMenuMultiplicacion.Text = "Jugar";
            this.btnMenuMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMenuMultiplicacion.Click += new System.EventHandler(this.btnMenuMultiplicacion_Click);
            // 
            // btnMenuDivision
            // 
            this.btnMenuDivision.BackColor = System.Drawing.Color.Salmon;
            this.btnMenuDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuDivision.Location = new System.Drawing.Point(533, 493);
            this.btnMenuDivision.Name = "btnMenuDivision";
            this.btnMenuDivision.Size = new System.Drawing.Size(82, 32);
            this.btnMenuDivision.TabIndex = 4;
            this.btnMenuDivision.Text = "Jugar";
            this.btnMenuDivision.UseVisualStyleBackColor = false;
            this.btnMenuDivision.Click += new System.EventHandler(this.btnMenuDivision_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Acumula numeros por monton";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descubre lo que falta ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Multiplica tus oportunidades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Reparte en partes iguales";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 559);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenuDivision);
            this.Controls.Add(this.btnMenuMultiplicacion);
            this.Controls.Add(this.btnMenuResta);
            this.Controls.Add(this.btnMenuSuma);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenuSuma;
        private System.Windows.Forms.Button btnMenuResta;
        private System.Windows.Forms.Button btnMenuMultiplicacion;
        private System.Windows.Forms.Button btnMenuDivision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

