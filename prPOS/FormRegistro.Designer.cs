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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.tbNombreCajero = new System.Windows.Forms.TextBox();
            this.tbFacturaNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btPagarFactura = new System.Windows.Forms.Button();
            this.btCancelFactura = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.ColCodigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtpFechaFactura);
            this.groupBox1.Controls.Add(this.tbNombreCajero);
            this.groupBox1.Controls.Add(this.tbFacturaNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturación";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFactura.CustomFormat = "dddd, dd-MMMM-yyyy hh:mm:ss";
            this.dtpFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFactura.Location = new System.Drawing.Point(396, 29);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(374, 29);
            this.dtpFechaFactura.TabIndex = 5;
            this.dtpFechaFactura.Value = new System.DateTime(2023, 12, 3, 17, 23, 37, 0);
            // 
            // tbNombreCajero
            // 
            this.tbNombreCajero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombreCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreCajero.Location = new System.Drawing.Point(122, 79);
            this.tbNombreCajero.Name = "tbNombreCajero";
            this.tbNombreCajero.Size = new System.Drawing.Size(648, 29);
            this.tbNombreCajero.TabIndex = 4;
            // 
            // tbFacturaNumero
            // 
            this.tbFacturaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFacturaNumero.Location = new System.Drawing.Point(122, 29);
            this.tbFacturaNumero.Name = "tbFacturaNumero";
            this.tbFacturaNumero.Size = new System.Drawing.Size(178, 29);
            this.tbFacturaNumero.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cajero:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Factura #:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btPagarFactura);
            this.groupBox2.Controls.Add(this.btCancelFactura);
            this.groupBox2.Controls.Add(this.labelTotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvDetalleFactura);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 367);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Factura";
            // 
            // btPagarFactura
            // 
            this.btPagarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btPagarFactura.BackColor = System.Drawing.Color.LimeGreen;
            this.btPagarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPagarFactura.ForeColor = System.Drawing.Color.FloralWhite;
            this.btPagarFactura.Location = new System.Drawing.Point(106, 280);
            this.btPagarFactura.Name = "btPagarFactura";
            this.btPagarFactura.Size = new System.Drawing.Size(342, 81);
            this.btPagarFactura.TabIndex = 4;
            this.btPagarFactura.Text = "PAGAR";
            this.btPagarFactura.UseVisualStyleBackColor = false;
            // 
            // btCancelFactura
            // 
            this.btCancelFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancelFactura.BackColor = System.Drawing.Color.Red;
            this.btCancelFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelFactura.ForeColor = System.Drawing.Color.FloralWhite;
            this.btCancelFactura.Location = new System.Drawing.Point(6, 280);
            this.btCancelFactura.Name = "btCancelFactura";
            this.btCancelFactura.Size = new System.Drawing.Size(94, 81);
            this.btCancelFactura.TabIndex = 3;
            this.btCancelFactura.Text = "Cancelar";
            this.btCancelFactura.UseVisualStyleBackColor = false;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(593, 302);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(191, 37);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "0.00";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total: $";
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
            this.dgvDetalleFactura.Size = new System.Drawing.Size(778, 254);
            this.dgvDetalleFactura.TabIndex = 0;
            this.dgvDetalleFactura.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleFactura_CellEndEdit);
            // 
            // ColCodigoArticulo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColCodigoArticulo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColCodigoArticulo.HeaderText = "Código Artículo";
            this.ColCodigoArticulo.MinimumWidth = 110;
            this.ColCodigoArticulo.Name = "ColCodigoArticulo";
            this.ColCodigoArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCodigoArticulo.Width = 110;
            // 
            // ColNombreArticulo
            // 
            this.ColNombreArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColNombreArticulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColNombreArticulo.HeaderText = "Nombre Artículo";
            this.ColNombreArticulo.MinimumWidth = 200;
            this.ColNombreArticulo.Name = "ColNombreArticulo";
            this.ColNombreArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColPrecioUnidad
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColPrecioUnidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColPrecioUnidad.HeaderText = "Precio Unidad $";
            this.ColPrecioUnidad.MinimumWidth = 110;
            this.ColPrecioUnidad.Name = "ColPrecioUnidad";
            this.ColPrecioUnidad.Width = 110;
            // 
            // ColCantidad
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColCantidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.MinimumWidth = 110;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Width = 110;
            // 
            // ColValor
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ColValor.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColValor.HeaderText = "Valor $";
            this.ColValor.MinimumWidth = 110;
            this.ColValor.Name = "ColValor";
            this.ColValor.Width = 110;
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
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.TextBox tbNombreCajero;
        private System.Windows.Forms.TextBox tbFacturaNumero;
        private System.Windows.Forms.Button btPagarFactura;
        private System.Windows.Forms.Button btCancelFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
    }
}