namespace Interfaz_Login
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnEntrarAJugar = new System.Windows.Forms.Button();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreoLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.txtPasswordRegistro = new System.Windows.Forms.TextBox();
            this.txtCorreoRegistro = new System.Windows.Forms.TextBox();
            this.txtNombreRegistro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(428, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 331);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.pictureBox9);
            this.tabPage1.Controls.Add(this.btnEntrarAJugar);
            this.tabPage1.Controls.Add(this.txtPasswordLogin);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCorreoLogin);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Iniciar Sesion";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(145, 23);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(54, 53);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 5;
            this.pictureBox9.TabStop = false;
            // 
            // btnEntrarAJugar
            // 
            this.btnEntrarAJugar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEntrarAJugar.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarAJugar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnEntrarAJugar.Location = new System.Drawing.Point(97, 224);
            this.btnEntrarAJugar.Name = "btnEntrarAJugar";
            this.btnEntrarAJugar.Size = new System.Drawing.Size(152, 51);
            this.btnEntrarAJugar.TabIndex = 4;
            this.btnEntrarAJugar.Text = "Entrar a Jugar";
            this.btnEntrarAJugar.UseVisualStyleBackColor = false;
            this.btnEntrarAJugar.Click += new System.EventHandler(this.btnEntrarAJugar_Click);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(49, 167);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(248, 22);
            this.txtPasswordLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txtCorreoLogin
            // 
            this.txtCorreoLogin.Location = new System.Drawing.Point(49, 98);
            this.txtCorreoLogin.Name = "txtCorreoLogin";
            this.txtCorreoLogin.Size = new System.Drawing.Size(248, 22);
            this.txtCorreoLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario o Correo de los padres";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCrearCuenta);
            this.tabPage2.Controls.Add(this.txtPasswordRegistro);
            this.tabPage2.Controls.Add(this.txtCorreoRegistro);
            this.tabPage2.Controls.Add(this.txtNombreRegistro);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear Cuenta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.Salmon;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearCuenta.Location = new System.Drawing.Point(94, 233);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(137, 47);
            this.btnCrearCuenta.TabIndex = 6;
            this.btnCrearCuenta.Text = "Crear mi Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // txtPasswordRegistro
            // 
            this.txtPasswordRegistro.Location = new System.Drawing.Point(41, 153);
            this.txtPasswordRegistro.Name = "txtPasswordRegistro";
            this.txtPasswordRegistro.Size = new System.Drawing.Size(242, 20);
            this.txtPasswordRegistro.TabIndex = 5;
            // 
            // txtCorreoRegistro
            // 
            this.txtCorreoRegistro.Location = new System.Drawing.Point(41, 98);
            this.txtCorreoRegistro.Name = "txtCorreoRegistro";
            this.txtCorreoRegistro.Size = new System.Drawing.Size(242, 20);
            this.txtCorreoRegistro.TabIndex = 4;
            // 
            // txtNombreRegistro
            // 
            this.txtNombreRegistro.Location = new System.Drawing.Point(41, 44);
            this.txtNombreRegistro.Name = "txtNombreRegistro";
            this.txtNombreRegistro.Size = new System.Drawing.Size(242, 20);
            this.txtNombreRegistro.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Correo del Tutor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre de Usuario:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(35, 104);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(307, 311);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.TextBox txtPasswordRegistro;
        private System.Windows.Forms.TextBox txtCorreoRegistro;
        private System.Windows.Forms.TextBox txtNombreRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btnEntrarAJugar;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreoLogin;
        private System.Windows.Forms.Label label1;
    }
}

