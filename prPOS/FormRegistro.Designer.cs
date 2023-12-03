namespace prPOS
{
    partial class FormRegistro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.ColCodigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturación";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelTotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvDetalleFactura);
            this.groupBox2.Location = new System.Drawing.Point(7, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 367);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Factura";
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigoArticulo,
            this.ColNombreArticulo,
            this.ColPrecioUnidad,
            this.ColCantidad,
            this.ColValor});
            this.dgvDetalleFactura.Location = new System.Drawing.Point(6, 19);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.Size = new System.Drawing.Size(778, 290);
            this.dgvDetalleFactura.TabIndex = 0;
            // 
            // ColCodigoArticulo
            // 
            this.ColCodigoArticulo.HeaderText = "Código Artículo";
            this.ColCodigoArticulo.MinimumWidth = 110;
            this.ColCodigoArticulo.Name = "ColCodigoArticulo";
            this.ColCodigoArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCodigoArticulo.Width = 110;
            // 
            // ColNombreArticulo
            // 
            this.ColNombreArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombreArticulo.HeaderText = "Nombre Artículo";
            this.ColNombreArticulo.MinimumWidth = 200;
            this.ColNombreArticulo.Name = "ColNombreArticulo";
            this.ColNombreArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColPrecioUnidad
            // 
            this.ColPrecioUnidad.HeaderText = "Precio Unidad";
            this.ColPrecioUnidad.MinimumWidth = 110;
            this.ColPrecioUnidad.Name = "ColPrecioUnidad";
            this.ColPrecioUnidad.Width = 110;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.MinimumWidth = 110;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Width = 110;
            // 
            // ColValor
            // 
            this.ColValor.HeaderText = "Valor";
            this.ColValor.MinimumWidth = 110;
            this.ColValor.Name = "ColValor";
            this.ColValor.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total: $";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(680, 327);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(84, 37);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "0.00";
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegistro";
            this.Text = "Registro";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label1;
    }
}