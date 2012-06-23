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
        DataRow registro;
        DataSet dados;
        SqlDataAdapter adaptadorReg = new SqlDataAdapter();
        SqlDataAdapter adaptadorCat;
        bool atualiza = false;

        public Caixa(DataSet dados, SqlDataAdapter adaptadorReg, SqlDataAdapter adaptadorCat)
        {
            this.dados = dados;
            this.adaptadorCat = adaptadorCat;
            InitializeComponent();
        }

        public Caixa(DataRow registro, bool atualiza, DataSet dados, SqlDataAdapter adaptadorReg, SqlDataAdapter adaptadorCat)
        {
            this.dados = dados;
            this.adaptadorCat = adaptadorCat;
            this.registro = registro;
            this.atualiza = atualiza;
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            int recorrente = 1;

            if (checkBoxRecorrente.Checked == true)
                recorrente = 2;
            else
                recorrente = 1;

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
                if (atualiza)
                {
                    registro["Descricao"] = textBoxDescricaoCaixa.Text;
                    registro["Valor"] = textBoxValorCaixa.Text;
                    registro["Recorrente"] = recorrente;
                    registro["Categoria"] = categoria;
                    adaptadorReg.Update(dados, "Registros");
                }
                else
                {
                    labelCampoPreenchimento.Visible = false;
                    DataRow novoRegistroCai = dados.Tables["Registros"].NewRow();
                    novoRegistroCai["Descricao"] = textBoxDescricaoCaixa.Text;
                    novoRegistroCai["Valor"] = textBoxValorCaixa.Text;
                    novoRegistroCai["Recorrente"] = recorrente;
                    novoRegistroCai["DataCadastro"] = DateTime.Now.ToShortDateString();
                    novoRegistroCai["Categoria"] = categoria;
                    dados.Tables["Registros"].Rows.Add(novoRegistroCai);
                    adaptadorReg.Update(dados, "Registros");
                }
                Close();
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBoxDescricaoCaixa.Text = "";
            textBoxValorCaixa.Text = "";
            checkBoxRecorrente.Checked = false;
            comboBoxCategoriaCaixa.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=(local);Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI";

            SqlCommand comandoSelecaoCai = new SqlCommand("select Descricao, Valor, Recorrente, DataCadastro, Categoria;", conexao);
            adaptadorCat.SelectCommand = comandoSelecaoCai;

            SqlCommand comandoInsercaoCai = new SqlCommand("Insert into Registros (Descricao, Valor, Recorrente, DataCadastro, Categoria) values (@Desc, @Valor, @Recorrente, @DataCadastro, @Categoria)", conexao);

            SqlParameter prmDescricao = new SqlParameter("@Desc", SqlDbType.VarChar, 40);
            prmDescricao.SourceColumn = "Descricao";
            comandoInsercaoCai.Parameters.Add(prmDescricao);

            SqlParameter prmValor = new SqlParameter("@Valor", SqlDbType.Decimal);
            prmValor.SourceColumn = "Valor";
            prmValor.SourceVersion = DataRowVersion.Current;
            comandoInsercaoCai.Parameters.Add(prmValor);

            SqlParameter prmRecorrente = new SqlParameter("@Recorrente", SqlDbType.TinyInt);
            prmRecorrente.SourceColumn = "Recorrente";
            prmRecorrente.SourceVersion = DataRowVersion.Current;
            comandoInsercaoCai.Parameters.Add(prmRecorrente);

            SqlParameter prmDataCadastro = new SqlParameter("@DataCadastro", SqlDbType.Date);
            prmDataCadastro.SourceColumn = "DataCadastro";
            prmDataCadastro.SourceVersion = DataRowVersion.Current;
            comandoInsercaoCai.Parameters.Add(prmDataCadastro);

            SqlParameter prmCategoria = new SqlParameter("@Categoria", SqlDbType.Int);
            prmCategoria.SourceColumn = "Categoria";
            prmCategoria.SourceVersion = DataRowVersion.Current;
            comandoInsercaoCai.Parameters.Add(prmCategoria);

            adaptadorReg.InsertCommand = comandoInsercaoCai;

            //Comandos para Atualização
            SqlCommand comandoAtualizacaoReg = new SqlCommand("Update Registros set Descricao = @Descricao, Valor = @Valor, Recorrente = @Recorrente, Categoria = @Categoria where Codigo = @Codigo", conexao);
            prmDescricao = new SqlParameter("@Descricao", SqlDbType.VarChar, 40);
            prmDescricao.SourceColumn = "Descricao";
            prmDescricao.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmDescricao);

            prmValor = new SqlParameter("@Valor", SqlDbType.Decimal);
            prmValor.SourceColumn = "Valor";
            prmValor.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmValor);

            prmRecorrente = new SqlParameter("@Recorrente", SqlDbType.TinyInt);
            prmRecorrente.SourceColumn = "Recorrente";
            prmRecorrente.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmRecorrente);

            prmCategoria = new SqlParameter("@Categoria", SqlDbType.Int);
            prmCategoria.SourceColumn = "Categoria";
            prmCategoria.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmCategoria);

            SqlParameter prmCodigo = new SqlParameter("@Codigo", SqlDbType.Int);
            prmCodigo.SourceColumn = "Codigo";
            prmCodigo.SourceVersion = DataRowVersion.Original;
            comandoAtualizacaoReg.Parameters.Add(prmCodigo);

            adaptadorReg.UpdateCommand = comandoAtualizacaoReg;

            foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                comboBoxCategoriaCaixa.Items.Add(registro["DescricaoCat"].ToString());

          
            if (atualiza)
            {
                string categoria = " ";

                foreach (DataRow registroCat in dados.Tables["Categoria"].Rows)
                    if (registro["Categoria"].ToString() == registroCat["CodigoCat"].ToString())
                        categoria = registroCat["DescricaoCat"].ToString();

                textBoxDescricaoCaixa.Text = registro["Descricao"].ToString();
                comboBoxCategoriaCaixa.Text = categoria;
                textBoxValorCaixa.Text = registro["Valor"].ToString();
            }
        }

        private void checkBoxRecorrente_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
