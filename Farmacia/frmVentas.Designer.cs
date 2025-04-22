namespace Farmacia
{
    partial class frmVentas
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
            lbl_titulo = new Label();
            grpBoxBusqueda = new GroupBox();
            lbl_medicamento = new Label();
            txtBusqueda = new TextBox();
            btn_Buscar = new Button();
            grpBoxBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(800, 49);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(104, 38);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Ventas";
            // 
            // grpBoxBusqueda
            // 
            grpBoxBusqueda.BackColor = Color.DarkSeaGreen;
            grpBoxBusqueda.Controls.Add(btn_Buscar);
            grpBoxBusqueda.Controls.Add(txtBusqueda);
            grpBoxBusqueda.Controls.Add(lbl_medicamento);
            grpBoxBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxBusqueda.Location = new Point(55, 146);
            grpBoxBusqueda.Name = "grpBoxBusqueda";
            grpBoxBusqueda.Size = new Size(1078, 379);
            grpBoxBusqueda.TabIndex = 1;
            grpBoxBusqueda.TabStop = false;
            grpBoxBusqueda.Text = "Busqueda de medicamento";
            // 
            // lbl_medicamento
            // 
            lbl_medicamento.AutoSize = true;
            lbl_medicamento.Location = new Point(22, 57);
            lbl_medicamento.Name = "lbl_medicamento";
            lbl_medicamento.Size = new Size(185, 32);
            lbl_medicamento.TabIndex = 2;
            lbl_medicamento.Text = "Medicamento :";
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.Silver;
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBusqueda.ForeColor = SystemColors.HighlightText;
            txtBusqueda.Location = new Point(244, 54);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Busqueda";
            txtBusqueda.Size = new Size(561, 40);
            txtBusqueda.TabIndex = 3;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.Black;
            btn_Buscar.ForeColor = Color.White;
            btn_Buscar.Location = new Point(859, 54);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(112, 40);
            btn_Buscar.TabIndex = 4;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1750, 1002);
            Controls.Add(grpBoxBusqueda);
            Controls.Add(lbl_titulo);
            Name = "frmVentas";
            Text = "frmVentas";
            grpBoxBusqueda.ResumeLayout(false);
            grpBoxBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private GroupBox grpBoxBusqueda;
        private Label lbl_medicamento;
        private TextBox txtBusqueda;
        private Button btn_Buscar;
    }
}