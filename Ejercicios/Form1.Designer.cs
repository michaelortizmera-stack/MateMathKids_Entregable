namespace Ejercicios
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.operacion = new System.Windows.Forms.Label();
            this.opcion_1 = new System.Windows.Forms.Button();
            this.opcion_2 = new System.Windows.Forms.Button();
            this.opcion_3 = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // operacion
            // 
            this.operacion.AutoSize = true;
            this.operacion.BackColor = System.Drawing.Color.White;
            this.operacion.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacion.ForeColor = System.Drawing.Color.IndianRed;
            this.operacion.Location = new System.Drawing.Point(114, 242);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(238, 34);
            this.operacion.TabIndex = 1;
            this.operacion.Text = "¿Cuánto es 5+2?";
            // 
            // opcion_1
            // 
            this.opcion_1.BackColor = System.Drawing.Color.MistyRose;
            this.opcion_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcion_1.ForeColor = System.Drawing.Color.IndianRed;
            this.opcion_1.Location = new System.Drawing.Point(137, 334);
            this.opcion_1.Name = "opcion_1";
            this.opcion_1.Size = new System.Drawing.Size(145, 48);
            this.opcion_1.TabIndex = 2;
            this.opcion_1.Text = "7";
            this.opcion_1.UseVisualStyleBackColor = false;
            this.opcion_1.Click += new System.EventHandler(this.opcion_1_Click);
            // 
            // opcion_2
            // 
            this.opcion_2.BackColor = System.Drawing.Color.MistyRose;
            this.opcion_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcion_2.ForeColor = System.Drawing.Color.IndianRed;
            this.opcion_2.Location = new System.Drawing.Point(326, 334);
            this.opcion_2.Name = "opcion_2";
            this.opcion_2.Size = new System.Drawing.Size(146, 48);
            this.opcion_2.TabIndex = 3;
            this.opcion_2.Text = "4";
            this.opcion_2.UseVisualStyleBackColor = false;
            this.opcion_2.Click += new System.EventHandler(this.opcion_2_Click);
            // 
            // opcion_3
            // 
            this.opcion_3.BackColor = System.Drawing.Color.MistyRose;
            this.opcion_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcion_3.ForeColor = System.Drawing.Color.IndianRed;
            this.opcion_3.Location = new System.Drawing.Point(518, 334);
            this.opcion_3.Name = "opcion_3";
            this.opcion_3.Size = new System.Drawing.Size(146, 48);
            this.opcion_3.TabIndex = 4;
            this.opcion_3.Text = "2";
            this.opcion_3.UseVisualStyleBackColor = false;
            this.opcion_3.Click += new System.EventHandler(this.opcion_3_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.MistyRose;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(679, 395);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(98, 43);
            this.next.TabIndex = 5;
            this.next.Text = "Siguiente";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(659, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.next);
            this.Controls.Add(this.opcion_3);
            this.Controls.Add(this.opcion_2);
            this.Controls.Add(this.opcion_1);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label operacion;
        private System.Windows.Forms.Button opcion_1;
        private System.Windows.Forms.Button opcion_2;
        private System.Windows.Forms.Button opcion_3;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

