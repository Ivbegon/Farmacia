namespace Farmacia
{
    partial class frmMenuPrincipal
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
            btnMedicamentos = new Button();
            btnVentas = new Button();
            btnInformes = new Button();
            btnCerrarSesion = new Button();
            lblTitulo = new Label();
            panelPrincipal = new Panel();
            lblFooter = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // btnMedicamentos
            // 
            btnMedicamentos.BackColor = Color.FromArgb(46, 204, 113);
            btnMedicamentos.FlatAppearance.BorderSize = 0;
            btnMedicamentos.FlatStyle = FlatStyle.Flat;
            btnMedicamentos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMedicamentos.ForeColor = Color.White;
            btnMedicamentos.Location = new Point(300, 150);
            btnMedicamentos.Margin = new Padding(3, 4, 3, 4);
            btnMedicamentos.Name = "btnMedicamentos";
            btnMedicamentos.Size = new Size(300, 60);
            btnMedicamentos.TabIndex = 0;
            btnMedicamentos.Text = "Gestión de Medicamentos";
            btnMedicamentos.UseVisualStyleBackColor = false;
            btnMedicamentos.Click += btnMedicamentos_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(46, 204, 113);
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(300, 230);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(300, 60);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Gestión de Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnInformes
            // 
            btnInformes.BackColor = Color.FromArgb(46, 204, 113);
            btnInformes.FlatAppearance.BorderSize = 0;
            btnInformes.FlatStyle = FlatStyle.Flat;
            btnInformes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInformes.ForeColor = Color.White;
            btnInformes.Location = new Point(300, 310);
            btnInformes.Margin = new Padding(3, 4, 3, 4);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(300, 60);
            btnInformes.TabIndex = 2;
            btnInformes.Text = "Informes de Ventas";
            btnInformes.UseVisualStyleBackColor = false;
            btnInformes.Click += btnInformes_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(231, 76, 60);
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(300, 390);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(300, 60);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.DarkGreen;
            lblTitulo.Location = new Point(290, 50);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(306, 54);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Menú Principal";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.WhiteSmoke;
            panelPrincipal.Controls.Add(lblFooter);
            panelPrincipal.Controls.Add(lblTitulo);
            panelPrincipal.Controls.Add(btnMedicamentos);
            panelPrincipal.Controls.Add(btnCerrarSesion);
            panelPrincipal.Controls.Add(btnVentas);
            panelPrincipal.Controls.Add(btnInformes);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(900, 600);
            panelPrincipal.TabIndex = 5;
            // 
            // lblFooter
            // 
            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblFooter.ForeColor = Color.Gray;
            lblFooter.Location = new Point(0, 570);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(900, 30);
            lblFooter.TabIndex = 6;
            lblFooter.Text = "© 2025 Farmacia. Todos los derechos reservados.";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Farmacia - Menú Principal";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMedicamentos;
        private Button btnVentas;
        private Button btnInformes;
        private Button btnCerrarSesion;
        private Label lblTitulo;
        private Panel panelPrincipal;
        private Label lblFooter;
    }
}