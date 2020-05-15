using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Fabriplus
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
            Pagos = pagoService.Consultar();
        }
        PagoService pagoService = new PagoService();
        List<Pago> Pagos = new List<Pago>();

        private void Consultar_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipoPago.Text;
            tblPagos.DataSource = pagoService.BuscarTipo(tipo);
            if (cmbTipoPago.Text.Equals("Todo"))
            {
                tblPagos.DataSource = Pagos;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            tblPagos.DataSource = Pagos;
            txtCantidadPagos.Text = Convert.ToString(pagoService.CantidadPagos());
            txtValorTotal.Text = Convert.ToString(pagoService.SumarPagos());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tblPagos.DataSource = pagoService.ConsultarFecha(dateTimeFecha.Value.Date);
        }
    }
}
