namespace FenixSoftware
{
    partial class FrmAbrirCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbrirCaja));
            this.rbtnSoles = new System.Windows.Forms.RadioButton();
            this.groupBoxTipoMoneda = new System.Windows.Forms.GroupBox();
            this.rbtnDolares = new System.Windows.Forms.RadioButton();
            this.groupBoxMonto = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblInicial = new System.Windows.Forms.Label();
            this.lblCierre = new System.Windows.Forms.Label();
            this.lblEquivalente = new System.Windows.Forms.Label();
            this.lblEquivalenteResultado = new System.Windows.Forms.Label();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.txtCierre = new System.Windows.Forms.TextBox();
            this.lblSolODolar1 = new System.Windows.Forms.Label();
            this.lblSolODolar2 = new System.Windows.Forms.Label();
            this.lblSolODolar3 = new System.Windows.Forms.Label();
            this.groupBoxTipoMoneda.SuspendLayout();
            this.groupBoxMonto.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnSoles
            // 
            this.rbtnSoles.AutoSize = true;
            this.rbtnSoles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSoles.ForeColor = System.Drawing.Color.Black;
            this.rbtnSoles.Location = new System.Drawing.Point(35, 28);
            this.rbtnSoles.Name = "rbtnSoles";
            this.rbtnSoles.Size = new System.Drawing.Size(65, 25);
            this.rbtnSoles.TabIndex = 1;
            this.rbtnSoles.TabStop = true;
            this.rbtnSoles.Text = "Soles";
            this.rbtnSoles.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipoMoneda
            // 
            this.groupBoxTipoMoneda.BackColor = System.Drawing.Color.White;
            this.groupBoxTipoMoneda.Controls.Add(this.rbtnDolares);
            this.groupBoxTipoMoneda.Controls.Add(this.rbtnSoles);
            this.groupBoxTipoMoneda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTipoMoneda.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBoxTipoMoneda.Location = new System.Drawing.Point(10, 10);
            this.groupBoxTipoMoneda.Name = "groupBoxTipoMoneda";
            this.groupBoxTipoMoneda.Size = new System.Drawing.Size(312, 95);
            this.groupBoxTipoMoneda.TabIndex = 2;
            this.groupBoxTipoMoneda.TabStop = false;
            this.groupBoxTipoMoneda.Text = "Tipo de Moneda";
            // 
            // rbtnDolares
            // 
            this.rbtnDolares.AutoSize = true;
            this.rbtnDolares.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDolares.ForeColor = System.Drawing.Color.Black;
            this.rbtnDolares.Location = new System.Drawing.Point(35, 58);
            this.rbtnDolares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnDolares.Name = "rbtnDolares";
            this.rbtnDolares.Size = new System.Drawing.Size(81, 25);
            this.rbtnDolares.TabIndex = 2;
            this.rbtnDolares.TabStop = true;
            this.rbtnDolares.Text = "Dolares";
            this.rbtnDolares.UseVisualStyleBackColor = true;
            // 
            // groupBoxMonto
            // 
            this.groupBoxMonto.BackColor = System.Drawing.Color.White;
            this.groupBoxMonto.Controls.Add(this.lblSolODolar3);
            this.groupBoxMonto.Controls.Add(this.lblSolODolar2);
            this.groupBoxMonto.Controls.Add(this.lblSolODolar1);
            this.groupBoxMonto.Controls.Add(this.txtCierre);
            this.groupBoxMonto.Controls.Add(this.txtInicial);
            this.groupBoxMonto.Controls.Add(this.lblEquivalenteResultado);
            this.groupBoxMonto.Controls.Add(this.lblEquivalente);
            this.groupBoxMonto.Controls.Add(this.lblCierre);
            this.groupBoxMonto.Controls.Add(this.lblInicial);
            this.groupBoxMonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMonto.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBoxMonto.Location = new System.Drawing.Point(10, 111);
            this.groupBoxMonto.Name = "groupBoxMonto";
            this.groupBoxMonto.Size = new System.Drawing.Size(312, 162);
            this.groupBoxMonto.TabIndex = 3;
            this.groupBoxMonto.TabStop = false;
            this.groupBoxMonto.Text = "Monto";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrar.Location = new System.Drawing.Point(12, 279);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(129, 42);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Location = new System.Drawing.Point(193, 279);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(129, 42);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicial.ForeColor = System.Drawing.Color.Black;
            this.lblInicial.Location = new System.Drawing.Point(31, 38);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(50, 21);
            this.lblInicial.TabIndex = 0;
            this.lblInicial.Text = "Inicial";
            // 
            // lblCierre
            // 
            this.lblCierre.AutoSize = true;
            this.lblCierre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCierre.ForeColor = System.Drawing.Color.Black;
            this.lblCierre.Location = new System.Drawing.Point(31, 76);
            this.lblCierre.Name = "lblCierre";
            this.lblCierre.Size = new System.Drawing.Size(52, 21);
            this.lblCierre.TabIndex = 1;
            this.lblCierre.Text = "Cierre";
            // 
            // lblEquivalente
            // 
            this.lblEquivalente.AutoSize = true;
            this.lblEquivalente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquivalente.ForeColor = System.Drawing.Color.Black;
            this.lblEquivalente.Location = new System.Drawing.Point(31, 115);
            this.lblEquivalente.Name = "lblEquivalente";
            this.lblEquivalente.Size = new System.Drawing.Size(90, 21);
            this.lblEquivalente.TabIndex = 2;
            this.lblEquivalente.Text = "Equivalente";
            // 
            // lblEquivalenteResultado
            // 
            this.lblEquivalenteResultado.AutoSize = true;
            this.lblEquivalenteResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquivalenteResultado.ForeColor = System.Drawing.Color.Black;
            this.lblEquivalenteResultado.Location = new System.Drawing.Point(202, 115);
            this.lblEquivalenteResultado.Name = "lblEquivalenteResultado";
            this.lblEquivalenteResultado.Size = new System.Drawing.Size(19, 21);
            this.lblEquivalenteResultado.TabIndex = 3;
            this.lblEquivalenteResultado.Text = "...";
            // 
            // txtInicial
            // 
            this.txtInicial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtInicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicial.Location = new System.Drawing.Point(206, 38);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(100, 29);
            this.txtInicial.TabIndex = 4;
            // 
            // txtCierre
            // 
            this.txtCierre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCierre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCierre.Location = new System.Drawing.Point(206, 73);
            this.txtCierre.Name = "txtCierre";
            this.txtCierre.Size = new System.Drawing.Size(100, 29);
            this.txtCierre.TabIndex = 5;
            // 
            // lblSolODolar1
            // 
            this.lblSolODolar1.AutoSize = true;
            this.lblSolODolar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolODolar1.ForeColor = System.Drawing.Color.Black;
            this.lblSolODolar1.Location = new System.Drawing.Point(143, 41);
            this.lblSolODolar1.Name = "lblSolODolar1";
            this.lblSolODolar1.Size = new System.Drawing.Size(28, 21);
            this.lblSolODolar1.TabIndex = 6;
            this.lblSolODolar1.Text = "S/.";
            // 
            // lblSolODolar2
            // 
            this.lblSolODolar2.AutoSize = true;
            this.lblSolODolar2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolODolar2.ForeColor = System.Drawing.Color.Black;
            this.lblSolODolar2.Location = new System.Drawing.Point(143, 76);
            this.lblSolODolar2.Name = "lblSolODolar2";
            this.lblSolODolar2.Size = new System.Drawing.Size(28, 21);
            this.lblSolODolar2.TabIndex = 7;
            this.lblSolODolar2.Text = "S/.";
            // 
            // lblSolODolar3
            // 
            this.lblSolODolar3.AutoSize = true;
            this.lblSolODolar3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolODolar3.ForeColor = System.Drawing.Color.Black;
            this.lblSolODolar3.Location = new System.Drawing.Point(143, 115);
            this.lblSolODolar3.Name = "lblSolODolar3";
            this.lblSolODolar3.Size = new System.Drawing.Size(28, 21);
            this.lblSolODolar3.TabIndex = 8;
            this.lblSolODolar3.Text = "S/.";
            // 
            // FrmAbrirCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 333);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBoxMonto);
            this.Controls.Add(this.groupBoxTipoMoneda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAbrirCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Caja";
            this.groupBoxTipoMoneda.ResumeLayout(false);
            this.groupBoxTipoMoneda.PerformLayout();
            this.groupBoxMonto.ResumeLayout(false);
            this.groupBoxMonto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnSoles;
        private System.Windows.Forms.GroupBox groupBoxTipoMoneda;
        private System.Windows.Forms.RadioButton rbtnDolares;
        private System.Windows.Forms.GroupBox groupBoxMonto;
        private System.Windows.Forms.Label lblSolODolar3;
        private System.Windows.Forms.Label lblSolODolar2;
        private System.Windows.Forms.Label lblSolODolar1;
        private System.Windows.Forms.TextBox txtCierre;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.Label lblEquivalenteResultado;
        private System.Windows.Forms.Label lblEquivalente;
        private System.Windows.Forms.Label lblCierre;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCerrar;
    }
}