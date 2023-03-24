using ClassLibrary1;
using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_IIParcial
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }

        Soporte soporte = null;
        List<Ticket> detalles = new List<Ticket> ();
        decimal Total = 0;
        decimal Subtotal = 0;
        decimal ISV = 0;


        private async void CodigoSoporteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SoporteDatos soporteDatos = new SoporteDatos();
                soporte = new Soporte();

                soporte = await soporteDatos.GetPorCodigoAsync(Convert.ToInt32(CodigoSoporteTextBox.Text));

                if (soporte.TipoSoporte != null)
                {
                    TipoSoporteTextBox.Text = soporte.TipoSoporte;
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(TipoSoporteTextBox, "No existe el este codigo de soporte");
                }
            }
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {
            UsuarioTextBox.Text = VariableGlobal.UsuarioLogin;
            DescuentoTextBox.Text = "0.00";
            PrecioTextBox.Text = "0.00";
        }

        private void DescripcionSolicitudTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Ticket ticket = new Ticket();

                ticket.DescripcionSolicitud = DescripcionSolicitudTextBox.Text;
                ticket.DescripcionRespuesta = DescripcionRespuestaTextBox.Text;
                ticket.Cliente = NombreTextBox.Text;
                ticket.DescripcionSolicitud = DescripcionSolicitudTextBox.Text;
                ticket.CodigoSoporte = soporte.Codigo;
                ticket.TipoSoporte = soporte.TipoSoporte;
                ticket.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                ticket.Descuento = Convert.ToDecimal(DescuentoTextBox.Text);

                detalles.Add(ticket);
                TicketDataGridView.DataSource = null;
                TicketDataGridView.DataSource = detalles;

                Subtotal = Convert.ToDecimal(PrecioTextBox.Text) - Convert.ToDecimal(DescuentoTextBox.Text);
                ISV = Subtotal * 0.15M;
                Total = Subtotal + ISV;

                ISVTextBox.Text = ISV.ToString("N");
                SubTotalTextBox.Text = Subtotal.ToString("N");
                TotalTextBox.Text = Total.ToString("N");
            }
        }
    }
}
