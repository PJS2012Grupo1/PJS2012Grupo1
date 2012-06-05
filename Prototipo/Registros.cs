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
        SqlDataAdapter adaptadorReg = new SqlDataAdapter();
        SqlDataAdapter adaptadorCat;

        public Registros(DataSet dados, SqlDataAdapter adaptadorReg, SqlDataAdapter adaptadorCat)
        {
            this.dados = dados;
            this.adaptadorCat = adaptadorCat;
            //this.adaptadorReg = adaptadorReg;
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
            dateTimePickerDataPagamentoReg.Text = dateTimePickerDataVencimentoReg.Text = DateTime.Now.ToShortDateString();
        }

        private void buttonCancelarRegistro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegistrarRegistro_Click(object sender, EventArgs e)
        {
            int status = 0;
            //RadioButton radio_clicado = (RadioButton)sender;
            //int radio = int.Parse(radio_clicado.Tag.ToString());
            //parameter.Value = DBNull.Value;

            if (textBoxDescricaoRegistro.Text == "")
            {
                labelCampoPreenchidos.Text = "*Campo descrição vazio.";
                labelCampoPreenchidos.Visible = true;
            }
            else if (comboBoxCategoriaRegistro.SelectedIndex == -1)
            {
                labelCampoPreenchidos.Text = "*Campo categoria vazio.";
            }
            else if (textBoxValorRegistro.Text == "")
            {
                labelCampoPreenchidos.Text = "*Campo valor vazio.";
                labelCampoPreenchidos.Visible = true;
            }
            else
            {
                int categoria = 0;
                foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                {
                    if (comboBoxCategoriaRegistro.Text == registro["DescricaoCat"].ToString())
                        categoria = int.Parse(registro["CodigoCat"].ToString());
                    else
                        categoria = 3;
                }
                labelCampoPreenchidos.Visible = false;
                DataRow novoRegistro = dados.Tables["Registros"].NewRow();
                novoRegistro["Descricao"] = textBoxDescricaoRegistro.Text;
                novoRegistro["Valor"] = "-" + textBoxValorRegistro.Text;
                novoRegistro["Categoria"] = categoria;
                novoRegistro["Status1"] = status;
                novoRegistro["DataVencimento"] = dateTimePickerDataVencimentoReg.Value;
                novoRegistro["DataPagamento"] = dateTimePickerDataPagamentoReg.Value;
                novoRegistro["DataCadastro"] = DateTime.Now.ToShortDateString();
                novoRegistro["Parcelas"] = 2;// comboBoxQtdeParcelasReg.Text;
                dados.Tables["Registros"].Rows.Add(novoRegistro);

                adaptadorReg.Update(dados, "Registros");

                Close();
            }
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=MARCIA-PC\\SQLEXPRESS;Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI";

            SqlCommand comandoInsercaoReg = new SqlCommand("Insert into Registros (Descricao, Valor, Categoria, Status1, DataVencimento, DataPagamento, DataCadastro, Parcelas) values (@Desc, @Valor, @Categoria, @Status1, @DataVencimento, @DataPagamento, @DataCadastro, @Parcelas)", conexao);
            SqlParameter prmDescricao = new SqlParameter("@Desc", SqlDbType.VarChar, 40);
            prmDescricao.SourceColumn = "Descricao";
            //prmDescricao.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmDescricao);

            SqlParameter prmValor = new SqlParameter("@Valor", SqlDbType.Decimal);
            prmValor.SourceColumn = "Valor";
            prmValor.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmValor);

            SqlParameter prmCategoria = new SqlParameter("@Categoria", SqlDbType.Int);
            prmCategoria.SourceColumn = "Categoria";
            prmCategoria.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmCategoria);

            SqlParameter prmStatus1 = new SqlParameter("@Status1", SqlDbType.TinyInt);
            prmStatus1.SourceColumn = "Status1";
            prmStatus1.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmStatus1);

            SqlParameter prmDataVencimento = new SqlParameter("@DataVencimento", SqlDbType.Date);
            prmDataVencimento.SourceColumn = "DataVencimento";
            prmDataVencimento.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmDataVencimento);

            SqlParameter prmDataPagamento = new SqlParameter("@DataPagamento", SqlDbType.Date);
            prmDataPagamento.SourceColumn = "DataPagamento";
            prmDataPagamento.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmDataPagamento);

            SqlParameter prmDataCadastro = new SqlParameter("@DataCadastro", SqlDbType.Date);
            prmDataCadastro.SourceColumn = "DataCadastro";
            prmDataCadastro.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmDataCadastro);

            SqlParameter prmParcelas = new SqlParameter("@Parcelas", SqlDbType.Int);
            prmParcelas.SourceColumn = "Parcelas";
            prmParcelas.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmParcelas);

            adaptadorReg.InsertCommand = comandoInsercaoReg;

            foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                comboBoxCategoriaRegistro.Items.Add(registro["DescricaoCat"].ToString());
        }
    }
}
