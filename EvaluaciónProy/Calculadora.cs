using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluaciónProy
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void AgregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (txtR.Text == "0")
                txtR.Text = "";

            txtR.Text += boton.Text;
        }

        private void bt0_Click(object sender, EventArgs e)
        {

        }
    }
}
