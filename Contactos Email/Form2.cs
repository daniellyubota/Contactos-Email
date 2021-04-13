using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Contactos_Email
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = new RadioButton[] { radioComerciante, radioComunicaçaoSocial };
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtEmail.Text) || !radioButtons.Any(rb => rb.Checked) )
            {
                MessageBox.Show("Uma das seções está vazia!");
            }
            else
            {

            }
        }
    }
}
