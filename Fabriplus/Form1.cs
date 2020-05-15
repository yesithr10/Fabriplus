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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        PagoService pagoService = new PagoService();
        Pago pago;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            pago = new Pago();
            Guardar();
            pagoService.Guardar(pago);
            string mensaje = pagoService.Guardar(pago);
            MessageBox.Show(mensaje);
        }

        private void Guardar()
        {
            pago.TipoPago = cmbTipoPago.Text.Trim();
            pago.Identificacion = txtIdentificacion.Text.Trim();
            pago.Nombre = txtNombre.Text.Trim();
            pago.FechaPago = dateTimeFecha.Value;
            pago.ValorPagar = Convert.ToDouble(txtValorPagar.Text.Trim());
            limpiar();
        }
        public void limpiar()
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtValorPagar.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Consultar().Visible = true;
        }

        private void cmbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
