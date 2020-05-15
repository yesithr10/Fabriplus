namespace Fabriplus
{
    partial class Consultar
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
            this.tblPagos = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.lblCantidadPagos = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtCantidadPagos = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPagos
            // 
            this.tblPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.tblPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPagos.ColumnHeadersVisible = false;
            this.tblPagos.Location = new System.Drawing.Point(33, 12);
            this.tblPagos.Name = "tblPagos";
            this.tblPagos.Size = new System.Drawing.Size(572, 175);
            this.tblPagos.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::Fabriplus.Properties.Resources.loupe_78347;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar.Location = new System.Drawing.Point(509, 278);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(96, 71);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Todo",
            "Servicio publico",
            "Compras a proveedores",
            "Pagos a contratistas"});
            this.cmbTipoPago.Location = new System.Drawing.Point(33, 224);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(169, 21);
            this.cmbTipoPago.TabIndex = 14;
            this.cmbTipoPago.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPago_SelectedIndexChanged);
            // 
            // lblCantidadPagos
            // 
            this.lblCantidadPagos.AutoSize = true;
            this.lblCantidadPagos.Location = new System.Drawing.Point(30, 262);
            this.lblCantidadPagos.Name = "lblCantidadPagos";
            this.lblCantidadPagos.Size = new System.Drawing.Size(152, 13);
            this.lblCantidadPagos.TabIndex = 15;
            this.lblCantidadPagos.Text = "Cantidad de pagos realizados: ";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(30, 294);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(99, 13);
            this.lblValorTotal.TabIndex = 16;
            this.lblValorTotal.Text = "Valor total pagado: ";
            // 
            // txtCantidadPagos
            // 
            this.txtCantidadPagos.Location = new System.Drawing.Point(211, 259);
            this.txtCantidadPagos.Name = "txtCantidadPagos";
            this.txtCantidadPagos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadPagos.TabIndex = 17;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(211, 294);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 18;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 361);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtCantidadPagos);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblCantidadPagos);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.tblPagos);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblPagos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label lblCantidadPagos;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtCantidadPagos;
        private System.Windows.Forms.TextBox txtValorTotal;
    }
}