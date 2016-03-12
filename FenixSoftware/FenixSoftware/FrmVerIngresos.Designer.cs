namespace FenixSoftware
{
    partial class FrmVerIngresos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnDolares = new System.Windows.Forms.RadioButton();
            this.rbtnSoles = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblEquivalenteResultado = new System.Windows.Forms.Label();
            this.lblEquivalente = new System.Windows.Forms.Label();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxIngresos = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnDolares);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.rbtnSoles);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblMoneda);
            this.panel1.Controls.Add(this.lblEquivalenteResultado);
            this.panel1.Controls.Add(this.lblEquivalente);
            this.panel1.Controls.Add(this.lblTipoCambio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 299);
            this.panel1.TabIndex = 7;
            // 
            // rbtnDolares
            // 
            this.rbtnDolares.AutoSize = true;
            this.rbtnDolares.Location = new System.Drawing.Point(172, 60);
            this.rbtnDolares.Name = "rbtnDolares";
            this.rbtnDolares.Size = new System.Drawing.Size(81, 25);
            this.rbtnDolares.TabIndex = 13;
            this.rbtnDolares.TabStop = true;
            this.rbtnDolares.Text = "Dolares";
            this.rbtnDolares.UseVisualStyleBackColor = true;
            // 
            // rbtnSoles
            // 
            this.rbtnSoles.AutoSize = true;
            this.rbtnSoles.Location = new System.Drawing.Point(92, 60);
            this.rbtnSoles.Name = "rbtnSoles";
            this.rbtnSoles.Size = new System.Drawing.Size(65, 25);
            this.rbtnSoles.TabIndex = 12;
            this.rbtnSoles.TabStop = true;
            this.rbtnSoles.Text = "Soles";
            this.rbtnSoles.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(20, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 148);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripción";
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(7, 29);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(508, 111);
            this.richTextBoxDescripcion.TabIndex = 0;
            this.richTextBoxDescripcion.Text = "";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(422, 19);
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
            this.lblMoneda.Location = new System.Drawing.Point(16, 62);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(74, 21);
            this.lblMoneda.TabIndex = 5;
            this.lblMoneda.Text = "Moneda :";
            // 
            // lblEquivalenteResultado
            // 
            this.lblEquivalenteResultado.AutoSize = true;
            this.lblEquivalenteResultado.Location = new System.Drawing.Point(427, 62);
            this.lblEquivalenteResultado.Name = "lblEquivalenteResultado";
            this.lblEquivalenteResultado.Size = new System.Drawing.Size(19, 21);
            this.lblEquivalenteResultado.TabIndex = 4;
            this.lblEquivalenteResultado.Text = "...";
            // 
            // lblEquivalente
            // 
            this.lblEquivalente.AutoSize = true;
            this.lblEquivalente.Location = new System.Drawing.Point(304, 62);
            this.lblEquivalente.Name = "lblEquivalente";
            this.lblEquivalente.Size = new System.Drawing.Size(97, 21);
            this.lblEquivalente.TabIndex = 3;
            this.lblEquivalente.Text = "Equivalente :";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.Location = new System.Drawing.Point(373, 22);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(28, 21);
            this.lblTipoCambio.TabIndex = 2;
            this.lblTipoCambio.Text = "S/.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto :";
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(20, 245);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(173, 46);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(368, 245);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 46);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxIngresos);
            this.panel2.Location = new System.Drawing.Point(12, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 235);
            this.panel2.TabIndex = 8;
            // 
            // groupBoxIngresos
            // 
            this.groupBoxIngresos.Controls.Add(this.dataGridView1);
            this.groupBoxIngresos.Location = new System.Drawing.Point(20, 13);
            this.groupBoxIngresos.Name = "groupBoxIngresos";
            this.groupBoxIngresos.Size = new System.Drawing.Size(521, 212);
            this.groupBoxIngresos.TabIndex = 0;
            this.groupBoxIngresos.TabStop = false;
            this.groupBoxIngresos.Text = "Listado Ingresos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmVerIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmVerIngresos";
            this.Text = "Ver Ingresos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxIngresos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnDolares;
        private System.Windows.Forms.RadioButton rbtnSoles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblEquivalenteResultado;
        private System.Windows.Forms.Label lblEquivalente;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxIngresos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}