namespace FenixSoftware
{
    partial class FrmVerAsignaciones
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxAsignaciones = new System.Windows.Forms.GroupBox();
            this.dataGridViewListadoAsigancioens = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnDolares = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbtnSoles = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBoxDescripcion = new System.Windows.Forms.GroupBox();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblEquivalenteResultado = new System.Windows.Forms.Label();
            this.lblEquivalente = new System.Windows.Forms.Label();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.rbtnArea = new System.Windows.Forms.RadioButton();
            this.rbtnPersona = new System.Windows.Forms.RadioButton();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBoxAsignaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoAsigancioens)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxAsignaciones);
            this.panel2.Location = new System.Drawing.Point(12, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 237);
            this.panel2.TabIndex = 21;
            // 
            // groupBoxAsignaciones
            // 
            this.groupBoxAsignaciones.Controls.Add(this.dataGridViewListadoAsigancioens);
            this.groupBoxAsignaciones.Location = new System.Drawing.Point(20, 13);
            this.groupBoxAsignaciones.Name = "groupBoxAsignaciones";
            this.groupBoxAsignaciones.Size = new System.Drawing.Size(500, 212);
            this.groupBoxAsignaciones.TabIndex = 0;
            this.groupBoxAsignaciones.TabStop = false;
            this.groupBoxAsignaciones.Text = "Listado Asignaciones";
            // 
            // dataGridViewListadoAsigancioens
            // 
            this.dataGridViewListadoAsigancioens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoAsigancioens.Location = new System.Drawing.Point(7, 29);
            this.dataGridViewListadoAsigancioens.Name = "dataGridViewListadoAsigancioens";
            this.dataGridViewListadoAsigancioens.Size = new System.Drawing.Size(487, 177);
            this.dataGridViewListadoAsigancioens.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnArea);
            this.panel1.Controls.Add(this.rbtnPersona);
            this.panel1.Controls.Add(this.txtEntidad);
            this.panel1.Controls.Add(this.lblEntidad);
            this.panel1.Controls.Add(this.rbtnDolares);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.rbtnSoles);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.groupBoxDescripcion);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblMoneda);
            this.panel1.Controls.Add(this.lblEquivalenteResultado);
            this.panel1.Controls.Add(this.lblEquivalente);
            this.panel1.Controls.Add(this.lblTipoCambio);
            this.panel1.Controls.Add(this.lblMonto);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 357);
            this.panel1.TabIndex = 28;
            // 
            // rbtnDolares
            // 
            this.rbtnDolares.AutoSize = true;
            this.rbtnDolares.Location = new System.Drawing.Point(172, 54);
            this.rbtnDolares.Name = "rbtnDolares";
            this.rbtnDolares.Size = new System.Drawing.Size(81, 25);
            this.rbtnDolares.TabIndex = 13;
            this.rbtnDolares.TabStop = true;
            this.rbtnDolares.Text = "Dolares";
            this.rbtnDolares.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(20, 310);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(173, 35);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // rbtnSoles
            // 
            this.rbtnSoles.AutoSize = true;
            this.rbtnSoles.Location = new System.Drawing.Point(92, 54);
            this.rbtnSoles.Name = "rbtnSoles";
            this.rbtnSoles.Size = new System.Drawing.Size(65, 25);
            this.rbtnSoles.TabIndex = 12;
            this.rbtnSoles.TabStop = true;
            this.rbtnSoles.Text = "Soles";
            this.rbtnSoles.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(347, 310);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 35);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBoxDescripcion
            // 
            this.groupBoxDescripcion.Controls.Add(this.richTextBoxDescripcion);
            this.groupBoxDescripcion.Location = new System.Drawing.Point(21, 156);
            this.groupBoxDescripcion.Name = "groupBoxDescripcion";
            this.groupBoxDescripcion.Size = new System.Drawing.Size(499, 148);
            this.groupBoxDescripcion.TabIndex = 9;
            this.groupBoxDescripcion.TabStop = false;
            this.groupBoxDescripcion.Text = "Descripción";
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(7, 29);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(486, 111);
            this.richTextBoxDescripcion.TabIndex = 0;
            this.richTextBoxDescripcion.Text = "";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(401, 19);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(119, 29);
            this.txtMonto.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(92, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(152, 29);
            this.txtCodigo.TabIndex = 6;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(16, 54);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(74, 21);
            this.lblMoneda.TabIndex = 5;
            this.lblMoneda.Text = "Moneda :";
            // 
            // lblEquivalenteResultado
            // 
            this.lblEquivalenteResultado.AutoSize = true;
            this.lblEquivalenteResultado.Location = new System.Drawing.Point(407, 54);
            this.lblEquivalenteResultado.Name = "lblEquivalenteResultado";
            this.lblEquivalenteResultado.Size = new System.Drawing.Size(19, 21);
            this.lblEquivalenteResultado.TabIndex = 4;
            this.lblEquivalenteResultado.Text = "...";
            // 
            // lblEquivalente
            // 
            this.lblEquivalente.AutoSize = true;
            this.lblEquivalente.Location = new System.Drawing.Point(275, 54);
            this.lblEquivalente.Name = "lblEquivalente";
            this.lblEquivalente.Size = new System.Drawing.Size(97, 21);
            this.lblEquivalente.TabIndex = 3;
            this.lblEquivalente.Text = "Equivalente :";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.Location = new System.Drawing.Point(358, 22);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(28, 21);
            this.lblTipoCambio.TabIndex = 2;
            this.lblTipoCambio.Text = "S/.";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(275, 22);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(63, 21);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto :";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 21);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código :";
            // 
            // rbtnArea
            // 
            this.rbtnArea.AutoSize = true;
            this.rbtnArea.Location = new System.Drawing.Point(184, 125);
            this.rbtnArea.Name = "rbtnArea";
            this.rbtnArea.Size = new System.Drawing.Size(60, 25);
            this.rbtnArea.TabIndex = 19;
            this.rbtnArea.TabStop = true;
            this.rbtnArea.Text = "Área";
            this.rbtnArea.UseVisualStyleBackColor = true;
            // 
            // rbtnPersona
            // 
            this.rbtnPersona.AutoSize = true;
            this.rbtnPersona.Location = new System.Drawing.Point(92, 125);
            this.rbtnPersona.Name = "rbtnPersona";
            this.rbtnPersona.Size = new System.Drawing.Size(84, 25);
            this.rbtnPersona.TabIndex = 18;
            this.rbtnPersona.TabStop = true;
            this.rbtnPersona.Text = "Persona";
            this.rbtnPersona.UseVisualStyleBackColor = true;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(92, 89);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(428, 29);
            this.txtEntidad.TabIndex = 17;
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Location = new System.Drawing.Point(17, 92);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(69, 21);
            this.lblEntidad.TabIndex = 16;
            this.lblEntidad.Text = "Entidad :";
            // 
            // FrmVerAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmVerAsignaciones";
            this.Text = "Ver Asignaciones";
            this.panel2.ResumeLayout(false);
            this.groupBoxAsignaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoAsigancioens)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxDescripcion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxAsignaciones;
        private System.Windows.Forms.DataGridView dataGridViewListadoAsigancioens;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnDolares;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbtnSoles;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBoxDescripcion;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblEquivalenteResultado;
        private System.Windows.Forms.Label lblEquivalente;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.RadioButton rbtnArea;
        private System.Windows.Forms.RadioButton rbtnPersona;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.Label lblEntidad;
    }
}