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
    public partial class FormFibonacci : Form
    {
        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLimite.Text, out int limite) || limite <= 0)
            {
                MessageBox.Show("Ingrese un número entero positivo válido para el límite.", "Error de Entrada");
                txtResultadoFib.Clear();
                return;
            }
            int a = 0;
            int b = 1;
            System.Text.StringBuilder serie = new System.Text.StringBuilder();
            
            if (limite >= 1) serie.Append(a); // El primer término es 0

            if (limite >= 2) serie.Append(", ").Append(b); // El segundo término es 1

            for (int i = 3; i <= limite; i++)
            {
                int c = a + b;
                serie.Append(", ").Append(c);
                a = b;
                b = c;
           }
            txtResultadoFib.Text = serie.ToString();
        }
    }
}
