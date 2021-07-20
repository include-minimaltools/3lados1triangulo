using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Lados1Triangulo
{
    public partial class MdiSecundario : Form
    {
        public MdiSecundario()
        {
            InitializeComponent();
        }

        private void btnDefiniciones_Click(object sender, EventArgs e)
        {
            frmDefiniciones frm = new frmDefiniciones();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnCalcularRectas_Click(object sender, EventArgs e)
        {
            frmcalcRectas frm = new frmcalcRectas();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
