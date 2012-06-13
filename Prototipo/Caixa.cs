using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Caixa : Form
    {
        DataSet dados;
        SqlDataAdapter adaptadorReg = new SqlDataAdapter();
        SqlDataAdapter adaptadorCat;

        public Caixa(DataSet dados, SqlDataAdapter adaptadorReg, SqlDataAdapter adaptadorCat)
        {
            this.dados = dados;
            this.adaptadorCat = adaptadorCat;
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxDescricaoCaixa.Text == "")
            {
                labelCampoPreenchimento.Text = "*Campo descrição vazio.";
                labelCampoPreenchimento.Visible = true;
            }

            else if (textBoxValorCaixa.Text == "")
            {
                labelCampoPreenchimento.Text = "*Campo valor vazio.";
                labelCampoPreenchimento.Visible = true;
            }

            else if (comboBoxCategoriaCaixa.SelectedIndex == -1)
            {
                labelCampoPreenchimento.Text = "*Campo categoria vazio.";
                labelCampoPreenchimento.Visible = true;
            }
            else
            {
                int categoria = 0;
                foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                    if (comboBoxCategoriaCaixa.Text == registro["DescricaoCat"].ToString())
                        categoria = int.Parse(registro["CodigoCat"].ToString());
                   
                labelCampoPreenchimento.Visible = false;
                DataRow novoRegistroCai = dados.Tables["Registros"].NewRow();
                novoRegistroCai["Descricao"] = textBoxDescricaoCaixa.Text;
                novoRegistroCai["Valor"] = textBoxValorCaixa.Text;
                novoRegistroCai["DataCadastro"] = DateTime.Now.ToShortDateString();
                novoRegistroCai["Categoria"] = categoria;              
                dados.Tables["Registros"].Rows.Add(novoRegistroCai);
                adaptadorReg.Update(dados, "Registros");
                Close();
            }
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

            SqlCommand comandoSelecaoCai = new SqlCommand("select Descricao, Valor, DataCadastro, Categoria;", conexao);
            adaptadorCat.SelectCommand = comandoSelecaoCai;

            SqlCommand comandoInsercaoCai = new SqlCommand("Insert into Registros (Descricao, Valor, DataCadastro, Categoria) values (@Desc, @Valor, @DataCadastro, @Categoria)", conexao);

            SqlParameter prmDescricao = new SqlParameter("@Desc", SqlDbType.VarChar, 40);
            prmDescricao.SourceColumn = "Descricao";
            comandoInsercaoCai.Parameters.Add(prmDescricao);

            SqlParameter prmValor = new SqlParameter("@Valor", SqlDbType.Decimal);
            prmValor.SourceColumn = "Valor";
            prmValor.SourceVersion = DataRowVersion.Current;
            comandoInsercaoCai.Parameters.Add(prmValor);

            SqlParameter prmDataCadastro = new SqlParameter("@DataCadastro", SqlDbType.Date);
            prmDataCadastro.SourceColumn = "DataCadastro";
            prmDataCadastro.SourceVersion = DataRowVersion.Current;
            comandoInsercaoCai.Parameters.Add(prmDataCadastro);

            SqlParameter prmCategoria = new SqlParameter("@Categoria", SqlDbType.Int);
            prmCategoria.SourceColumn = "Categoria";
            prmCategoria.SourceVersion = DataRowVersion.Current;
            comandoInsercaoCai.Parameters.Add(prmCategoria);

            adaptadorReg.InsertCommand = comandoInsercaoCai;
            foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                comboBoxCategoriaCaixa.Items.Add(registro["DescricaoCat"].ToString());       
        }
    }
}
