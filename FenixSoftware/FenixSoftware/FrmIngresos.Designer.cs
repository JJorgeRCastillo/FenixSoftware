namespace FenixSoftware
{
    partial class FrmIngresos
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblEquivalenteResultado = new System.Windows.Forms.Label();
            this.lblEquivalente = new System.Windows.Forms.Label();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVerIngresos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnDolares);
            this.panel1.Controls.Add(this.rbtnSoles);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblMoneda);
            this.panel1.Controls.Add(this.lblEquivalenteResultado);
            this.panel1.Controls.Add(this.lblEquivalente);
            this.panel1.Controls.Add(this.lblTipoCambio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 333);
            this.panel1.TabIndex = 4;
            // 
            // rbtnDolares
            // 
            this.rbtnDolares.AutoSize = true;
            this.rbtnDolares.Location = new System.Drawing.Point(92, 112);
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
            this.rbtnSoles.Location = new System.Drawing.Point(92, 81);
            this.rbtnSoles.Name = "rbtnSoles";
            this.rbtnSoles.Size = new System.Drawing.Size(65, 25);
            this.rbtnSoles.TabIndex = 12;
            this.rbtnSoles.TabStop = true;
            this.rbtnSoles.Text = "Soles";
            this.rbtnSoles.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(20, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 148);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripción";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 111);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(333, 19);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(119, 29);
            this.txtMonto.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(92, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(119, 29);
            this.txtCodigo.TabIndex = 6;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(16, 97);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(74, 21);
            this.lblMoneda.TabIndex = 5;
            this.lblMoneda.Text = "Moneda :";
            // 
            // lblEquivalenteResultado
            // 
            this.lblEquivalenteResultado.AutoSize = true;
            this.lblEquivalenteResultado.Location = new System.Drawing.Point(374, 97);
            this.lblEquivalenteResultado.Name = "lblEquivalenteResultado";
            this.lblEquivalenteResultado.Size = new System.Drawing.Size(19, 21);
            this.lblEquivalenteResultado.TabIndex = 4;
            this.lblEquivalenteResultado.Text = "...";
            // 
            // lblEquivalente
            // 
            this.lblEquivalente.AutoSize = true;
            this.lblEquivalente.Location = new System.Drawing.Point(233, 97);
            this.lblEquivalente.Name = "lblEquivalente";
            this.lblEquivalente.Size = new System.Drawing.Size(97, 21);
            this.lblEquivalente.TabIndex = 3;
            this.lblEquivalente.Text = "Equivalente :";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.Location = new System.Drawing.Point(302, 22);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(28, 21);
            this.lblTipoCambio.TabIndex = 2;
            this.lblTipoCambio.Text = "S/.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 22);
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
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(8, 354);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(173, 46);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnVerIngresos
            // 
            this.btnVerIngresos.Location = new System.Drawing.Point(300, 354);
            this.btnVerIngresos.Name = "btnVerIngresos";
            this.btnVerIngresos.Size = new System.Drawing.Size(173, 46);
            this.btnVerIngresos.TabIndex = 5;
            this.btnVerIngresos.Text = "VER INGRESOS";
            this.btnVerIngresos.UseVisualStyleBackColor = true;
            this.btnVerIngresos.Click += new System.EventHandler(this.btnVerIngresos_Click);
            // 
            // FrmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnVerIngresos);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmIngresos";
            this.Text = "Ingresos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnDolares;
        private System.Windows.Forms.RadioButton rbtnSoles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblEquivalenteResultado;
        private System.Windows.Forms.Label lblEquivalente;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVerIngresos;
    }
}