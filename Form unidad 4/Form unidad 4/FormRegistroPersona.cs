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
    public partial class FormRegistroPersona : Form
    {
        public FormRegistroPersona()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtApellido.Text) ||
        string.IsNullOrWhiteSpace(txtCedula.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            dataGridView1.Rows.Add(
        txtNombre.Text,
        txtApellido.Text,
        txtCedula.Text,
        txtEmail.Text
    );
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtEmail.Clear();

            txtNombre.Focus(); 
    }
    }
}
