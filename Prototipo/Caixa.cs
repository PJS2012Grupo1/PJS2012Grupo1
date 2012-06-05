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
        DataSet dados;
        SqlDataAdapter adaptadorCat = new SqlDataAdapter();

        public Caixa(DataSet dados, SqlDataAdapter adaptadorCat)
        {
            this.dados = dados;
            this.adaptadorCat = adaptadorCat;
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            DataRow novoRegistroCai = dados.Tables["Registros"].NewRow();
            novoRegistroCai["Descricao"] = textBoxDescricaoCaixa.Text;
            novoRegistroCai["Valor"] = textBoxValorCaixa.Text;
            novoRegistroCai["Categoria"] = comboBoxCategoriaCaixa.Text;
            novoRegistroCai["DataCadastro"] = DateTime.Now.ToShortDateString();
            novoRegistroCai["DataPagamento"] = dateTimePickerDataEntradaCaixa.Value;
            adaptadorCat.Update(dados, "Registros");
            Close();
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

        private void Caixa_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=(local);Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI";

            SqlCommand comandoInsercaoReg = new SqlCommand("Insert into Registros (Descricao, Valor, Categoria, DataCadastro) values (@Desc, @Valor, @Categoria, @DataCadastro)", conexao);

            SqlParameter prmDescricao = new SqlParameter("@Desc", SqlDbType.VarChar, 40);
            prmDescricao.SourceColumn = "Descricao";
            comandoInsercaoReg.Parameters.Add(prmDescricao);

            SqlParameter prmValor = new SqlParameter("@Valor", SqlDbType.Decimal);
            prmValor.SourceColumn = "Valor";
            prmValor.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmValor);

            SqlParameter prmCategoria = new SqlParameter("@Categoria", SqlDbType.Int);
            prmCategoria.SourceColumn = "Categoria";
            prmCategoria.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmCategoria);

            SqlParameter prmDataCadastro = new SqlParameter("@DataCadastro", SqlDbType.Date);
            prmDataCadastro.SourceColumn = "DataCadastro";
            prmDataCadastro.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmDataCadastro);

            adaptadorCat.InsertCommand = comandoInsercaoReg;

            
        }
    }
}
