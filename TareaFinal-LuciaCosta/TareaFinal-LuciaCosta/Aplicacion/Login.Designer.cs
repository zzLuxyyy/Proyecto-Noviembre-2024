namespace TareaFinal_LuciaCosta
{
    partial class Login
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasenia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.PaleVioletRed;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.linkLabel1.Font = new System.Drawing.Font("Candara Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.linkLabel1.Location = new System.Drawing.Point(116, 369);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(184, 18);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Has olvidado tu contraseña?";
            // 
            // textpass
            // 
            this.textpass.BackColor = System.Drawing.Color.White;
            this.textpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textpass.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textpass.Location = new System.Drawing.Point(41, 275);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(336, 31);
            this.textpass.TabIndex = 12;
            this.textpass.Tag = "";
            this.textpass.Enter += new System.EventHandler(this.textpass_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(152, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "LOGIN";
            // 
            // textuser
            // 
            this.textuser.BackColor = System.Drawing.Color.White;
            this.textuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textuser.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textuser.Location = new System.Drawing.Point(41, 207);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(336, 31);
            this.textuser.TabIndex = 11;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ingresar.Location = new System.Drawing.Point(41, 331);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(336, 35);
            this.btn_ingresar.TabIndex = 10;
            this.btn_ingresar.Text = "INGRESAR";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.White;
            this.labelUsuario.Font = new System.Drawing.Font("Candara", 12F);
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.labelUsuario.Location = new System.Drawing.Point(37, 185);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(141, 19);
            this.labelUsuario.TabIndex = 16;
            this.labelUsuario.Text = "Nombre de Usuario";
            // 
            // labelContrasenia
            // 
            this.labelContrasenia.AutoSize = true;
            this.labelContrasenia.BackColor = System.Drawing.Color.White;
            this.labelContrasenia.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.labelContrasenia.Location = new System.Drawing.Point(37, 253);
            this.labelContrasenia.Name = "labelContrasenia";
            this.labelContrasenia.Size = new System.Drawing.Size(88, 19);
            this.labelContrasenia.TabIndex = 17;
            this.labelContrasenia.Text = "Contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(420, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 550);
            this.panel1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(322, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 31);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Candara", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(257, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Idioma:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelContrasenia);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.btn_ingresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasenia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

