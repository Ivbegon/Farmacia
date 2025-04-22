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
            SuspendLayout();
            // 
            // btnMedicamentos
            // 
            btnMedicamentos.Location = new Point(343, 133);
            btnMedicamentos.Margin = new Padding(3, 4, 3, 4);
            btnMedicamentos.Name = "btnMedicamentos";
            btnMedicamentos.Size = new Size(229, 53);
            btnMedicamentos.TabIndex = 0;
            btnMedicamentos.Text = "Gestión de Medicamentos";
            btnMedicamentos.UseVisualStyleBackColor = true;
            btnMedicamentos.Click += btnMedicamentos_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(343, 213);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(229, 53);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Gestión de Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnInformes
            // 
            btnInformes.Location = new Point(343, 293);
            btnInformes.Margin = new Padding(3, 4, 3, 4);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(229, 53);
            btnInformes.TabIndex = 2;
            btnInformes.Text = "Informes de Ventas";
            btnInformes.UseVisualStyleBackColor = true;
            btnInformes.Click += btnInformes_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(343, 373);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(229, 53);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(331, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(279, 37);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Sistema de Farmacia";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblTitulo);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnInformes);
            Controls.Add(btnVentas);
            Controls.Add(btnMedicamentos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        // Componentes
        private System.Windows.Forms.Button btnMedicamentos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblTitulo;

        #endregion
    }
}