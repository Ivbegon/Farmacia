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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelLogin = new Panel();
            txtB_usuario = new TextBox();
            txtB_password = new TextBox();
            lbl_usuario = new Label();
            lbl_password = new Label();
            btn_login = new Button();
            lbl_titulo = new Label();
            logo = new PictureBox();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Anchor = AnchorStyles.None;
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(txtB_usuario);
            panelLogin.Controls.Add(txtB_password);
            panelLogin.Controls.Add(lbl_usuario);
            panelLogin.Controls.Add(lbl_password);
            panelLogin.Controls.Add(btn_login);
            panelLogin.Controls.Add(lbl_titulo);
            panelLogin.Controls.Add(logo);
            panelLogin.Location = new Point(270, 50);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(420, 400);
            panelLogin.TabIndex = 0;
            // 
            // txtB_usuario
            // 
            txtB_usuario.Font = new Font("Segoe UI", 10F);
            txtB_usuario.Location = new Point(120, 170);
            txtB_usuario.Name = "txtB_usuario";
            txtB_usuario.Size = new Size(250, 34);
            txtB_usuario.TabIndex = 0;
            // 
            // txtB_password
            // 
            txtB_password.Font = new Font("Segoe UI", 10F);
            txtB_password.Location = new Point(120, 220);
            txtB_password.Name = "txtB_password";
            txtB_password.PasswordChar = '*';
            txtB_password.Size = new Size(250, 34);
            txtB_password.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            lbl_usuario.Font = new Font("Segoe UI", 10F);
            lbl_usuario.Location = new Point(40, 170);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(70, 25);
            lbl_usuario.TabIndex = 2;
            lbl_usuario.Text = "Usuario:";
            // 
            // lbl_password
            // 
            lbl_password.Font = new Font("Segoe UI", 10F);
            lbl_password.Location = new Point(20, 220);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(100, 25);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "Contraseña:";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.MediumSeaGreen;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(120, 280);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(250, 40);
            btn_login.TabIndex = 4;
            btn_login.Text = "Iniciar Sesión";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_titulo.ForeColor = Color.DarkGreen;
            lbl_titulo.Location = new Point(110, 120);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(273, 48);
            lbl_titulo.TabIndex = 5;
            lbl_titulo.Text = "Farmacia Login";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(160, 10);
            logo.Name = "logo";
            logo.Size = new Size(100, 100);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 6;
            logo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(960, 540);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Farmacia - Login";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private PictureBox logo;
        private Label lbl_titulo;
        private TextBox txtB_usuario;
        private TextBox txtB_password;
        private Label lbl_usuario;
        private Label lbl_password;
        private Button btn_login;
    }
}
