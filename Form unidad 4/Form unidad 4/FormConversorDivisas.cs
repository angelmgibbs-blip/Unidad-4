using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_unidad_4
{
    public partial class FormConversorDivisas : Form
    {
        public FormConversorDivisas()
        {
            InitializeComponent();
        }
        private const double TASA_EUR_A_USD = 1.07; // 1 EUR = 1.07 USD
        private const double TASA_DOP_A_USD = 0.017; // 1 DOP = 0.017 USD (aprox 1/58)

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMonto.Text, out double monto) || monto < 0)
            {
                MessageBox.Show("Ingrese un monto numérico positivo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbMonedaOrigen.SelectedItem == null || cmbMonedaDestino.SelectedItem == null)
            {
                MessageBox.Show("Seleccione las monedas de origen y destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string origen = cmbMonedaOrigen.SelectedItem.ToString();
            string destino = cmbMonedaDestino.SelectedItem.ToString();
            double resultado = 0;
            double montoEnUSD = ConvertirMonedaABase(origen, monto);
            if (destino == "USD")
            {
                resultado = montoEnUSD;
            }
            else if (destino == "EUR")
            {
                resultado = montoEnUSD / TASA_EUR_A_USD;
            }
            else if (destino == "DOP")
            {
                resultado = montoEnUSD / TASA_DOP_A_USD;
            }
            txtResultado.Text = resultado.ToString("N2"); // Mostrar con 2 decimales
        }
        private double ConvertirMonedaABase(string origen, double monto)
        {
            if (origen == "USD") return monto;
            if (origen == "EUR") return monto * TASA_EUR_A_USD;
            if (origen == "DOP") return monto * TASA_DOP_A_USD;
            return 0;
    }
    }
    }
