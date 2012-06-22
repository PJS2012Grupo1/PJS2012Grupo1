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
    public partial class ProjecaoDeGastos : Form
    {
        public ProjecaoDeGastos()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProjecaoDeGastos_Load(object sender, EventArgs e)
        {
        }

        private void radioButtonClicado(object sender, EventArgs e)
        {
            if (radioButtonGastosParc.Checked == true)
            {
                listView1.Columns.Clear();
                listView1.Columns.Add("Descrição");
                listView1.Columns.Add("Numero de parcelas");
                listView1.Columns.Add("Parcelas pagas");
                listView1.Columns.Add("Parcelas restantes");
                listView1.Columns.Add("Valor total");
            }
            else if (radioButtonGastosPeri.Checked == true)
            {
                listView1.Columns.Clear();
                listView1.Columns.Add("Descrição");
            }
        }

        private void radioButtonGastosParc_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
