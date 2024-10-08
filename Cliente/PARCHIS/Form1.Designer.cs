namespace PARCHIS
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
            this.button1_Iniciar_Sesion = new System.Windows.Forms.Button();
            this.button2_Regsitrarse = new System.Windows.Forms.Button();
            this.Nombre_label = new System.Windows.Forms.Label();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.contraseñaBox = new System.Windows.Forms.TextBox();
            this.Mail_label = new System.Windows.Forms.Label();
            this.Contraseña_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_nombre = new System.Windows.Forms.RadioButton();
            this.radioButton_contraseña = new System.Windows.Forms.RadioButton();
            this.radioButton_mail = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_Iniciar_Sesion
            // 
            this.button1_Iniciar_Sesion.Location = new System.Drawing.Point(34, 448);
            this.button1_Iniciar_Sesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1_Iniciar_Sesion.Name = "button1_Iniciar_Sesion";
            this.button1_Iniciar_Sesion.Size = new System.Drawing.Size(207, 68);
            this.button1_Iniciar_Sesion.TabIndex = 0;
            this.button1_Iniciar_Sesion.Text = "Iniciar Sesión\r\n";
            this.button1_Iniciar_Sesion.UseVisualStyleBackColor = true;
            this.button1_Iniciar_Sesion.Click += new System.EventHandler(this.button1_Iniciar_Sesion_Click);
            // 
            // button2_Regsitrarse
            // 
            this.button2_Regsitrarse.Location = new System.Drawing.Point(412, 448);
            this.button2_Regsitrarse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2_Regsitrarse.Name = "button2_Regsitrarse";
            this.button2_Regsitrarse.Size = new System.Drawing.Size(207, 68);
            this.button2_Regsitrarse.TabIndex = 1;
            this.button2_Regsitrarse.Text = "Registrarse";
            this.button2_Regsitrarse.UseVisualStyleBackColor = true;
            this.button2_Regsitrarse.Click += new System.EventHandler(this.button2_Regsitrarse_Click);
            // 
            // Nombre_label
            // 
            this.Nombre_label.AutoSize = true;
            this.Nombre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_label.Location = new System.Drawing.Point(27, 145);
            this.Nombre_label.Name = "Nombre_label";
            this.Nombre_label.Size = new System.Drawing.Size(141, 37);
            this.Nombre_label.TabIndex = 2;
            this.Nombre_label.Text = "Nombre:";
            this.Nombre_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(312, 156);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(307, 26);
            this.nombreBox.TabIndex = 3;
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(312, 211);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(307, 26);
            this.mailBox.TabIndex = 4;
            this.mailBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // contraseñaBox
            // 
            this.contraseñaBox.Location = new System.Drawing.Point(312, 266);
            this.contraseñaBox.Name = "contraseñaBox";
            this.contraseñaBox.Size = new System.Drawing.Size(307, 26);
            this.contraseñaBox.TabIndex = 5;
            // 
            // Mail_label
            // 
            this.Mail_label.AutoSize = true;
            this.Mail_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail_label.Location = new System.Drawing.Point(27, 200);
            this.Mail_label.Name = "Mail_label";
            this.Mail_label.Size = new System.Drawing.Size(84, 37);
            this.Mail_label.TabIndex = 6;
            this.Mail_label.Text = "Mail:";
            // 
            // Contraseña_label
            // 
            this.Contraseña_label.AutoSize = true;
            this.Contraseña_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña_label.Location = new System.Drawing.Point(27, 256);
            this.Contraseña_label.Name = "Contraseña_label";
            this.Contraseña_label.Size = new System.Drawing.Size(192, 37);
            this.Contraseña_label.TabIndex = 7;
            this.Contraseña_label.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(471, 108);
            this.label4.TabIndex = 8;
            this.label4.Text = "PARCHÍS";
            // 
            // radioButton_nombre
            // 
            this.radioButton_nombre.AutoSize = true;
            this.radioButton_nombre.Location = new System.Drawing.Point(34, 335);
            this.radioButton_nombre.Name = "radioButton_nombre";
            this.radioButton_nombre.Size = new System.Drawing.Size(127, 24);
            this.radioButton_nombre.TabIndex = 9;
            this.radioButton_nombre.TabStop = true;
            this.radioButton_nombre.Text = "Di mi nombre";
            this.radioButton_nombre.UseVisualStyleBackColor = true;
            // 
            // radioButton_contraseña
            // 
            this.radioButton_contraseña.AutoSize = true;
            this.radioButton_contraseña.Location = new System.Drawing.Point(466, 335);
            this.radioButton_contraseña.Name = "radioButton_contraseña";
            this.radioButton_contraseña.Size = new System.Drawing.Size(153, 24);
            this.radioButton_contraseña.TabIndex = 11;
            this.radioButton_contraseña.TabStop = true;
            this.radioButton_contraseña.Text = "Di mi contraseña";
            this.radioButton_contraseña.UseVisualStyleBackColor = true;
            // 
            // radioButton_mail
            // 
            this.radioButton_mail.AutoSize = true;
            this.radioButton_mail.Location = new System.Drawing.Point(252, 335);
            this.radioButton_mail.Name = "radioButton_mail";
            this.radioButton_mail.Size = new System.Drawing.Size(101, 24);
            this.radioButton_mail.TabIndex = 10;
            this.radioButton_mail.TabStop = true;
            this.radioButton_mail.Text = "Di mi mail";
            this.radioButton_mail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 120);
            this.label1.TabIndex = 12;
            this.label1.Text = "AVISO: primero has de \r\nponer el nombre, mail \r\ny contraseña. Seguidamente\r\nclica" +
    "r qué quieres que te diga \r\nel prgrama. Y por último\r\niniciar sesión o registrar" +
    "se.\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_contraseña);
            this.Controls.Add(this.radioButton_mail);
            this.Controls.Add(this.radioButton_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Contraseña_label);
            this.Controls.Add(this.Mail_label);
            this.Controls.Add(this.contraseñaBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.Nombre_label);
            this.Controls.Add(this.button2_Regsitrarse);
            this.Controls.Add(this.button1_Iniciar_Sesion);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Iniciar_Sesion;
        private System.Windows.Forms.Button button2_Regsitrarse;
        private System.Windows.Forms.Label Nombre_label;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.TextBox contraseñaBox;
        private System.Windows.Forms.Label Mail_label;
        private System.Windows.Forms.Label Contraseña_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_nombre;
        private System.Windows.Forms.RadioButton radioButton_contraseña;
        private System.Windows.Forms.RadioButton radioButton_mail;
        private System.Windows.Forms.Label label1;
    }
}

