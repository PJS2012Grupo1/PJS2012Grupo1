using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Registros : Form
    {
        DataSet dados;
        SqlDataAdapter adaptadorReg;

        public Registros(DataSet dados, SqlDataAdapter adaptadorReg)
        {
            this.dados = dados;
            this.adaptadorReg = adaptadorReg;
            InitializeComponent();
        }

        private void radioButtonPagamentoParceladoReg_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxQtdeParcelasReg.Visible = true;
            labelQtdeParcReg.Visible = true;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxDescricaoRegistro.Text = "";
            textBoxValorRegistro.Text = "";
            comboBoxCategoriaRegistro.Text = "";
            comboBoxQtdeParcelasReg.Text = "";
        }

        private void buttonCancelarRegistro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegistrarRegistro_Click(object sender, EventArgs e)
        {
            //RadioButton radio = new RadioButton();
            int status = 1;
            DataRow novoRegistro = dados.Tables["Registros"].NewRow();
            novoRegistro["Descricao"] = textBoxDescricaoRegistro.Text;
            novoRegistro["Valor"] = textBoxValorRegistro.Text;
            novoRegistro["Categoria"] = comboBoxCategoriaRegistro.Text;
            novoRegistro["Status1"] = status;
            novoRegistro["DataVencimento"] = dateTimePickerDataVencimentoReg.Text;
            novoRegistro["DataPagamento"] = dateTimePickerDataPagamentoReg.Text;
            novoRegistro["DataCadastro"] = dateTimePickerDataCadastroReg.Text;
            dados.Tables["Registros"].Rows.Add(novoRegistro);

            adaptadorReg.Update(dados, "Registros");

            Close();
        }
    }
}
