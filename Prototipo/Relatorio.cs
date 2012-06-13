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
    public partial class Relatorio : Form
    {
        DataSet dados;
        public Relatorio(DataSet dados)
        {
            this.dados = dados;
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                comboBoxRelatorioCategoria.Items.Add(registro["DescricaoCat"].ToString());  
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
