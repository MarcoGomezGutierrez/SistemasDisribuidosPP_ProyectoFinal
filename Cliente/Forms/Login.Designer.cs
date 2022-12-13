
namespace Cliente
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_nickName = new System.Windows.Forms.TextBox();
            this.lbl_nickName = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_moverBotonesRegistrar = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.checkBox_mostrar = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel_central = new System.Windows.Forms.Panel();
            this.panel_central.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nickName
            // 
            this.txt_nickName.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickName.Location = new System.Drawing.Point(132, 103);
            this.txt_nickName.Multiline = true;
            this.txt_nickName.Name = "txt_nickName";
            this.txt_nickName.Size = new System.Drawing.Size(180, 46);
            this.txt_nickName.TabIndex = 0;
            // 
            // lbl_nickName
            // 
            this.lbl_nickName.AutoSize = true;
            this.lbl_nickName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nickName.ForeColor = System.Drawing.Color.White;
            this.lbl_nickName.Location = new System.Drawing.Point(1, 112);
            this.lbl_nickName.Name = "lbl_nickName";
            this.lbl_nickName.Size = new System.Drawing.Size(125, 25);
            this.lbl_nickName.TabIndex = 1;
            this.lbl_nickName.Text = "Nick Name";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(132, 175);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(180, 46);
            this.txt_password.TabIndex = 2;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(1, 186);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(114, 25);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password";
            // 
            // btn_moverBotonesRegistrar
            // 
            this.btn_moverBotonesRegistrar.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_moverBotonesRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btn_moverBotonesRegistrar.FlatAppearance.BorderSize = 0;
            this.btn_moverBotonesRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_moverBotonesRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btn_moverBotonesRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_moverBotonesRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moverBotonesRegistrar.Location = new System.Drawing.Point(177, 323);
            this.btn_moverBotonesRegistrar.Name = "btn_moverBotonesRegistrar";
            this.btn_moverBotonesRegistrar.Size = new System.Drawing.Size(85, 28);
            this.btn_moverBotonesRegistrar.TabIndex = 5;
            this.btn_moverBotonesRegistrar.Text = "Register";
            this.btn_moverBotonesRegistrar.UseVisualStyleBackColor = false;
            this.btn_moverBotonesRegistrar.Click += new System.EventHandler(this.btn_moverBotonesRegistrar_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(132, 268);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(180, 49);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Visible = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_atras.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btn_atras.FlatAppearance.BorderSize = 0;
            this.btn_atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(177, 323);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(85, 28);
            this.btn_atras.TabIndex = 7;
            this.btn_atras.Text = "Return";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Visible = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // checkBox_mostrar
            // 
            this.checkBox_mostrar.AutoSize = true;
            this.checkBox_mostrar.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_mostrar.ForeColor = System.Drawing.Color.White;
            this.checkBox_mostrar.Location = new System.Drawing.Point(318, 193);
            this.checkBox_mostrar.Name = "checkBox_mostrar";
            this.checkBox_mostrar.Size = new System.Drawing.Size(57, 17);
            this.checkBox_mostrar.TabIndex = 8;
            this.checkBox_mostrar.Text = "Show";
            this.checkBox_mostrar.UseVisualStyleBackColor = false;
            this.checkBox_mostrar.CheckedChanged += new System.EventHandler(this.checkBox_mostrar_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(132, 268);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(180, 49);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(24, 33);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 25);
            this.lbl_error.TabIndex = 9;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(156, 33);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(115, 42);
            this.lbl_titulo.TabIndex = 10;
            this.lbl_titulo.Text = "Login";
            // 
            // panel_central
            // 
            this.panel_central.BackColor = System.Drawing.Color.Black;
            this.panel_central.Controls.Add(this.lbl_titulo);
            this.panel_central.Controls.Add(this.lbl_error);
            this.panel_central.Controls.Add(this.checkBox_mostrar);
            this.panel_central.Controls.Add(this.btn_atras);
            this.panel_central.Controls.Add(this.btn_register);
            this.panel_central.Controls.Add(this.btn_moverBotonesRegistrar);
            this.panel_central.Controls.Add(this.btn_login);
            this.panel_central.Controls.Add(this.lbl_password);
            this.panel_central.Controls.Add(this.txt_password);
            this.panel_central.Controls.Add(this.lbl_nickName);
            this.panel_central.Controls.Add(this.txt_nickName);
            this.panel_central.Location = new System.Drawing.Point(11, 27);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(399, 393);
            this.panel_central.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.panel_central);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(438, 489);
            this.MinimumSize = new System.Drawing.Size(438, 489);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nickName;
        private System.Windows.Forms.Label lbl_nickName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_moverBotonesRegistrar;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.CheckBox checkBox_mostrar;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel_central;
    }
}