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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registroDePersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistroPersona frmRegistro = new FormRegistroPersona();
            frmRegistro.MdiParent = this;
            frmRegistro.Show();
        }

        private void conversorDeDivisasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConversorDivisas frmConversor = new FormConversorDivisas();
            frmConversor.MdiParent = this;
            frmConversor.Show();
        }

        private void serieDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFibonacci frmFibonacci = new FormFibonacci();
            frmFibonacci.MdiParent = this;
            frmFibonacci.Show();
        }
    }
}
