using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void Registros_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonPagamentoParceladoReg_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxQtdeParcelasReg.Enabled = true;
            labelQtdeParcReg.Enabled = true;
        }
    }
}
