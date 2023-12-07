using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prPOS
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }

        private void dgvDetalleFactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDetalleFactura.Columns["colCodigoArticulo"].Index)
            {
                // Obtén la celda editada
                DataGridViewCell celdaEditada = dgvDetalleFactura.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Formatea la columna colCodigoArticulo a 7 dígitos
                if (int.TryParse(celdaEditada.Value.ToString(), out int codigo))
                {
                    celdaEditada.Value = codigo.ToString("D7");
                }
            }
            DataGridViewCell celdaPrecioUnidad = dgvDetalleFactura.Rows[e.RowIndex].Cells["colPrecioUnidad"];
            DataGridViewCell celdaCantidad = dgvDetalleFactura.Rows[e.RowIndex].Cells["colCantidad"];
            DataGridViewCell celdaValor = dgvDetalleFactura.Rows[e.RowIndex].Cells["colValor"];

            // Formatea colPrecioUnidad a decimal con dos decimales
            if (decimal.TryParse(celdaPrecioUnidad.Value?.ToString(), out decimal precioValue))
            {
                celdaPrecioUnidad.Value = precioValue.ToString("0.00");
            }

            // Formatea colCantidad a decimal con dos decimales
            if (decimal.TryParse(celdaCantidad.Value?.ToString(), out decimal cantidadValue))
            {
                celdaCantidad.Value = cantidadValue.ToString("0.00");
            }

            // Calcula el valor multiplicando colCantidad por colPrecioUnidad y actualiza colValor
            if (celdaCantidad.Value != null && celdaPrecioUnidad.Value != null)
            {
                if (decimal.TryParse(celdaCantidad.Value.ToString(), out decimal cantidad) &&
                    decimal.TryParse(celdaPrecioUnidad.Value.ToString(), out decimal precio))
                {
                    celdaValor.Value = (cantidad * precio).ToString("0.00");
                }
            }
            //Sumar las celdas valor
            decimal total = 0;

            foreach (DataGridViewRow row in dgvDetalleFactura.Rows)
            {
                if (row.Cells["colValor"].Value != null)
                {
                    decimal valorEnFila;
                    if (decimal.TryParse(row.Cells["colValor"].Value.ToString(), out valorEnFila))
                    {
                        total += valorEnFila;
                    }
                }
            }

            labelTotal.Text = total.ToString();

        }    
    }
}
