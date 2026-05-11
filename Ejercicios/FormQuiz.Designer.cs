namespace Ejercicios
{
    partial class FormQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuiz));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_pregunta = new System.Windows.Forms.Label();
            this.label_progreso = new System.Windows.Forms.Label();
            this.label_puntaje = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-40, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(906, 472);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_pregunta
            // 
            this.label_pregunta.AutoSize = true;
            this.label_pregunta.BackColor = System.Drawing.Color.White;
            this.label_pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pregunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_pregunta.Location = new System.Drawing.Point(300, 250);
            this.label_pregunta.Name = "label_pregunta";
            this.label_pregunta.Size = new System.Drawing.Size(279, 39);
            this.label_pregunta.TabIndex = 4;
            this.label_pregunta.Text = "¿Cuanto es 4+2?";
            // 
            // label_progreso
            // 
            this.label_progreso.AutoSize = true;
            this.label_progreso.BackColor = System.Drawing.Color.White;
            this.label_progreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_progreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_progreso.Location = new System.Drawing.Point(102, 321);
            this.label_progreso.Name = "label_progreso";
            this.label_progreso.Size = new System.Drawing.Size(87, 24);
            this.label_progreso.TabIndex = 5;
            this.label_progreso.Text = "Progreso";
            // 
            // label_puntaje
            // 
            this.label_puntaje.AutoSize = true;
            this.label_puntaje.BackColor = System.Drawing.Color.White;
            this.label_puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_puntaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_puntaje.Location = new System.Drawing.Point(614, 417);
            this.label_puntaje.Name = "label_puntaje";
            this.label_puntaje.Size = new System.Drawing.Size(73, 24);
            this.label_puntaje.TabIndex = 13;
            this.label_puntaje.Text = "Puntaje";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(285, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 59);
            this.button1.TabIndex = 14;
            this.button1.Text = "3";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(392, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 59);
            this.button2.TabIndex = 15;
            this.button2.Text = "6";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Pink;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(509, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 59);
            this.button3.TabIndex = 16;
            this.button3.Text = "10";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_puntaje);
            this.Controls.Add(this.label_progreso);
            this.Controls.Add(this.label_pregunta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormQuiz";
            this.Text = "FormQuiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_pregunta;
        private System.Windows.Forms.Label label_progreso;
        private System.Windows.Forms.Label label_puntaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}