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
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVerIngresos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSunat = new System.Windows.Forms.Label();
            this.lblManual = new System.Windows.Forms.Label();
            this.txtSunat = new System.Windows.Forms.TextBox();
            this.txtManual = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.rbtnDolares);
            this.panel1.Controls.Add(this.rbtnSoles);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtImporte);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.lblMoneda);
            this.panel1.Controls.Add(this.lblImporte);
            this.panel1.Controls.Add(this.lblNumero);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 286);
            this.panel1.TabIndex = 4;
            // 
            // rbtnDolares
            // 
            this.rbtnDolares.AutoSize = true;
            this.rbtnDolares.Location = new System.Drawing.Point(163, 55);
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
            this.rbtnSoles.Location = new System.Drawing.Point(92, 55);
            this.rbtnSoles.Name = "rbtnSoles";
            this.rbtnSoles.Size = new System.Drawing.Size(65, 25);
            this.rbtnSoles.TabIndex = 12;
            this.rbtnSoles.TabStop = true;
            this.rbtnSoles.Text = "Soles";
            this.rbtnSoles.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(21, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 91);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(6, 28);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(372, 51);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.Text = "";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(97, 19);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(97, 29);
            this.txtNumero.TabIndex = 6;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(17, 57);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(74, 21);
            this.lblMoneda.TabIndex = 5;
            this.lblMoneda.Text = "Moneda :";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(228, 22);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(72, 21);
            this.lblImporte.TabIndex = 1;
            this.lblImporte.Text = "Importe :";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(16, 22);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(75, 21);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número :";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(8, 298);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(173, 46);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnVerIngresos
            // 
            this.btnVerIngresos.Location = new System.Drawing.Point(257, 298);
            this.btnVerIngresos.Name = "btnVerIngresos";
            this.btnVerIngresos.Size = new System.Drawing.Size(173, 46);
            this.btnVerIngresos.TabIndex = 5;
            this.btnVerIngresos.Text = "VER INGRESOS";
            this.btnVerIngresos.UseVisualStyleBackColor = true;
            this.btnVerIngresos.Click += new System.EventHandler(this.btnVerIngresos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSunat);
            this.groupBox2.Controls.Add(this.txtManual);
            this.groupBox2.Controls.Add(this.lblManual);
            this.groupBox2.Controls.Add(this.lblSunat);
            this.groupBox2.Location = new System.Drawing.Point(20, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 80);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equivalencia";
            // 
            // lblSunat
            // 
            this.lblSunat.AutoSize = true;
            this.lblSunat.Location = new System.Drawing.Point(14, 37);
            this.lblSunat.Name = "lblSunat";
            this.lblSunat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSunat.Size = new System.Drawing.Size(57, 21);
            this.lblSunat.TabIndex = 15;
            this.lblSunat.Text = "Sunat :";
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Location = new System.Drawing.Point(208, 37);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(69, 21);
            this.lblManual.TabIndex = 16;
            this.lblManual.Text = "Manual :";
            // 
            // txtSunat
            // 
            this.txtSunat.Location = new System.Drawing.Point(77, 34);
            this.txtSunat.Name = "txtSunat";
            this.txtSunat.Size = new System.Drawing.Size(97, 29);
            this.txtSunat.TabIndex = 15;
            // 
            // txtManual
            // 
            this.txtManual.Location = new System.Drawing.Point(283, 34);
            this.txtManual.Name = "txtManual";
            this.txtManual.Size = new System.Drawing.Size(96, 29);
            this.txtManual.TabIndex = 16;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(303, 19);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(96, 29);
            this.txtImporte.TabIndex = 8;
            // 
            // FrmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 357);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnDolares;
        private System.Windows.Forms.RadioButton rbtnSoles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVerIngresos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSunat;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Label lblSunat;
        private System.Windows.Forms.TextBox txtManual;
        private System.Windows.Forms.TextBox txtImporte;
    }
}