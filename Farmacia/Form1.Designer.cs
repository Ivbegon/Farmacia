namespace Farmacia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        #region
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            logo = new PictureBox();
            panelLogin = new Panel();
            lbl_footer = new Label();
            txtB_usuario = new TextBox();
            txtB_password = new TextBox();
            lbl_usuario = new Label();
            lbl_password = new Label();
            btn_login = new Button();
            lbl_titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(800, 40);
            logo.Name = "logo";
            logo.Size = new Size(100, 100);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 6;
            logo.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.WhiteSmoke;
            panelLogin.Controls.Add(lbl_footer);
            panelLogin.Controls.Add(txtB_usuario);
            panelLogin.Controls.Add(txtB_password);
            panelLogin.Controls.Add(lbl_usuario);
            panelLogin.Controls.Add(lbl_password);
            panelLogin.Controls.Add(btn_login);
            panelLogin.Controls.Add(logo);
            panelLogin.Controls.Add(lbl_titulo);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(713, 483);
            panelLogin.TabIndex = 0;
            // 
            // lbl_footer
            // 
            lbl_footer.Dock = DockStyle.Bottom;
            lbl_footer.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbl_footer.ForeColor = Color.Gray;
            lbl_footer.Location = new Point(0, 453);
            lbl_footer.Name = "lbl_footer";
            lbl_footer.Size = new Size(713, 30);
            lbl_footer.TabIndex = 0;
            lbl_footer.Text = "© 2025 Farmacia. Todos los derechos reservados.";
            lbl_footer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtB_usuario
            // 
            txtB_usuario.BorderStyle = BorderStyle.FixedSingle;
            txtB_usuario.Font = new Font("Segoe UI", 12F);
            txtB_usuario.Location = new Point(218, 178);
            txtB_usuario.Name = "txtB_usuario";
            txtB_usuario.PlaceholderText = "Usuario";
            txtB_usuario.Size = new Size(300, 39);
            txtB_usuario.TabIndex = 1;
            // 
            // txtB_password
            // 
            txtB_password.BorderStyle = BorderStyle.FixedSingle;
            txtB_password.Font = new Font("Segoe UI", 12F);
            txtB_password.Location = new Point(218, 247);
            txtB_password.Name = "txtB_password";
            txtB_password.PasswordChar = '*';
            txtB_password.PlaceholderText = "Contraseña";
            txtB_password.Size = new Size(300, 39);
            txtB_password.TabIndex = 2;
            // 
            // lbl_usuario
            // 
            lbl_usuario.Font = new Font("Segoe UI", 12F);
            lbl_usuario.Location = new Point(49, 178);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(114, 36);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "Usuario:";
            lbl_usuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_password
            // 
            lbl_password.Font = new Font("Segoe UI", 12F);
            lbl_password.Location = new Point(49, 247);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(150, 39);
            lbl_password.TabIndex = 4;
            lbl_password.Text = "Contraseña:";
            lbl_password.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(46, 204, 113);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(218, 326);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(300, 50);
            btn_login.TabIndex = 5;
            btn_login.Text = "Iniciar Sesión";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.DarkGreen;
            lbl_titulo.Location = new Point(162, 51);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(400, 71);
            lbl_titulo.TabIndex = 7;
            lbl_titulo.Text = "Farmacia Login";
            lbl_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 483);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Farmacia - Login";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Label lbl_footer;
        private PictureBox logo;
        private Label lbl_titulo;
        private Button btn_login;
        private Label lbl_password;
        private Label lbl_usuario;
        private TextBox txtB_password;
        private TextBox txtB_usuario;
        private Panel panelLogin;
    }
}
