using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Caixa : Form
    {
        DataSet dados = new DataSet();
        SqlDataAdapter adaptadorCat = new SqlDataAdapter();

        public Caixa(DataSet dados, SqlDataAdapter adaptadorCat)
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            DataRow novoRegistroCai = dados.Tables["Registros"].NewRow();
            novoRegistroCai["Descricao"] = textBoxDescricaoCaixa.Text;
            novoRegistroCai["Valor"] = textBoxValorCaixa.Text;
            novoRegistroCai["Categoria"] = dateTimePickerDataEntradaCaixa.Text;
            novoRegistroCai["??"] = comboBoxCategoriaCaixa.Text;
            
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBoxDescricaoCaixa.Text = "";
            textBoxValorCaixa.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
