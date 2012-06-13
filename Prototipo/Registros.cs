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
    public partial class Registros : Form
    {
        DataSet dados;
        int codigo;
        bool atualiza = false;
        SqlDataAdapter adaptadorReg = new SqlDataAdapter();
        SqlDataAdapter adaptadorCat;
        int radio = 3;

        public Registros(DataSet dados, SqlDataAdapter adaptadorReg, SqlDataAdapter adaptadorCat)
        {
            this.dados = dados;
            this.adaptadorCat = adaptadorCat;
            //this.adaptadorReg = adaptadorReg;
            InitializeComponent();
        }

        public Registros(int codigo, bool atualiza, DataSet dados, SqlDataAdapter adaptadorReg, SqlDataAdapter adaptadorCat)
        {
            this.atualiza = atualiza;
            this.codigo = codigo;
            this.dados = dados;
            this.adaptadorCat = adaptadorCat;
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
            dateTimePickerDataPagamentoReg.Text = dateTimePickerDataVencimentoReg.Text = DateTime.Now.ToShortDateString();
        }

        private void buttonCancelarRegistro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonClicado(object sender, EventArgs e)
        {
            RadioButton radio_clicado = (RadioButton)sender;
            radio = int.Parse(radio_clicado.Tag.ToString());
        }

        private void buttonRegistrarRegistro_Click(object sender, EventArgs e)
        {
            //parameter.Value = DBNull.Value;
            
            if (textBoxDescricaoRegistro.Text == "")
            {
                labelCampoPreenchidos.Text = "*Campo descrição vazio.";
                labelCampoPreenchidos.Visible = true;
            }
            else if (comboBoxCategoriaRegistro.SelectedIndex == -1)
            {
                labelCampoPreenchidos.Text = "*Campo categoria vazio.";
                labelCampoPreenchidos.Visible = true;
            }
            else if (textBoxValorRegistro.Text == "")
            {
                labelCampoPreenchidos.Text = "*Campo valor vazio.";
                labelCampoPreenchidos.Visible = true;
            }
            else if (radio == 3)
            {
                labelCampoPreenchidos.Text = "Forma de pagamento não selecionada.";
                labelCampoPreenchidos.Visible = true;

            }
            else
            {
                int recorrente = 1;
                int parcelas;

                if (radio == 3)
                    parcelas = int.Parse(comboBoxQtdeParcelasReg.Text);
                else
                {
                    parcelas = 1;
                    if (radio == 2)
                        recorrente = 2;
                }

                int categoria = 0;
                foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                    if (comboBoxCategoriaRegistro.Text == registro["DescricaoCat"].ToString())
                        categoria = int.Parse(registro["CodigoCat"].ToString());

                labelCampoPreenchidos.Visible = false;

                if (atualiza)
                {
                    foreach (DataRow registro in dados.Tables["Registros"].Rows)
                    {
                        if (int.Parse(registro["Codigo"].ToString()) == codigo)
                        {
                            DataRow Registro = dados.Tables["Registros"].NewRow();
                            Registro["Descricao"] = textBoxDescricaoRegistro.Text;
                            Registro["Valor"] = "-" + textBoxValorRegistro.Text;
                            Registro["Categoria"] = categoria;
                            Registro["Recorrente"] = recorrente;
                            Registro["DataVencimento"] = dateTimePickerDataVencimentoReg.Value;
                            Registro["DataPagamento"] = dateTimePickerDataPagamentoReg.Value;
                            Registro["DataCadastro"] = DateTime.Now.ToShortDateString();
                            Registro["Parcelas"] = parcelas;
                            break;
                        }
                    }
                }
                else
                    {
                        DataRow novoRegistro = dados.Tables["Registros"].NewRow();
                        novoRegistro["Descricao"] = textBoxDescricaoRegistro.Text;
                        novoRegistro["Valor"] = "-" + textBoxValorRegistro.Text;
                        novoRegistro["Categoria"] = categoria;
                        novoRegistro["Recorrente"] = recorrente;
                        novoRegistro["DataVencimento"] = dateTimePickerDataVencimentoReg.Value;
                        novoRegistro["DataPagamento"] = dateTimePickerDataPagamentoReg.Value;
                        novoRegistro["DataCadastro"] = DateTime.Now.ToShortDateString();
                        novoRegistro["Parcelas"] = parcelas;
                        dados.Tables["Registros"].Rows.Add(novoRegistro);
                        adaptadorReg.Update(dados, "Registros");
                        adaptadorReg.Update(dados, "Registros");
                    }
                Close();
            }
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=(local);Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI";
            
            SqlCommand comandoInsercaoReg = new SqlCommand("Insert into Registros (Descricao, Valor, Categoria, Recorrente, DataVencimento, DataPagamento, DataCadastro, Parcelas) values (@Desc, @Valor, @Categoria, @Recorrente, @DataVencimento, @DataPagamento, @DataCadastro, @Parcelas)", conexao);
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

            SqlParameter prmRecorrente = new SqlParameter("@Recorrente", SqlDbType.TinyInt);
            prmRecorrente.SourceColumn = "Recorrente";
            prmRecorrente.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmRecorrente);

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

            SqlCommand comandoAtualizacaoReg = new SqlCommand("Update Registros set Descricao = @Descricao, Valor = @Valor, Categoria = @Categoria, Status1 = @Recorrente, DataVencimento = @DataVencimento, DataPagamento = @DataPagamento, DataCadastro = @DataCadastro, Parcelas = @Parcelas where Codigo = @Codigo", conexao);
            prmDescricao = new SqlParameter("@Descricao", SqlDbType.VarChar, 40);
            prmDescricao.SourceColumn = "Descricao";
            prmDescricao.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmDescricao);

            prmValor = new SqlParameter("@Valor", SqlDbType.Decimal);
            prmValor.SourceColumn = "Valor";
            prmValor.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmValor);

            prmCategoria = new SqlParameter("@Categoria", SqlDbType.Int);
            prmCategoria.SourceColumn = "Categoria";
            prmCategoria.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmCategoria);

            prmRecorrente = new SqlParameter("@Recorrente", SqlDbType.TinyInt);
            prmRecorrente.SourceColumn = "Recorrente";
            prmRecorrente.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmRecorrente);

            prmValor = new SqlParameter("@Valor", SqlDbType.Decimal);
            prmValor.SourceColumn = "Valor";
            prmValor.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmValor);

            prmDataVencimento = new SqlParameter("@DataVencimento", SqlDbType.Date);
            prmDataVencimento.SourceColumn = "DataVencimento";
            prmDataVencimento.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmDataVencimento);

            prmDataPagamento = new SqlParameter("@DataPagamento", SqlDbType.Date);
            prmDataPagamento.SourceColumn = "DataPagamento";
            prmDataPagamento.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmDataPagamento);

            prmDataCadastro = new SqlParameter("@DataCadastro", SqlDbType.Date);
            prmDataCadastro.SourceColumn = "DataCadastro";
            prmDataCadastro.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmDataCadastro);

            SqlParameter prmCodigo = new SqlParameter("@Codigo", SqlDbType.Int);
            prmCodigo.SourceColumn = "Codigo";
            prmCodigo.SourceVersion = DataRowVersion.Original;
            comandoAtualizacaoReg.Parameters.Add(prmCodigo);

            adaptadorReg.UpdateCommand = comandoAtualizacaoReg;

            adaptadorReg.InsertCommand = comandoInsercaoReg;
            adaptadorReg.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                comboBoxCategoriaRegistro.Items.Add(registro["DescricaoCat"].ToString());

            if (atualiza)
            {
                foreach (DataRow registro in dados.Tables["Registros"].Rows)
                {
                    if (int.Parse(registro["Codigo"].ToString()) == codigo)
                    {

                        string categoria = " ";

                        foreach (DataRow registroCat in dados.Tables["Categoria"].Rows)
                            if (registro["Categoria"].ToString() == registroCat["CodigoCat"].ToString())
                                categoria = registroCat["DescricaoCat"].ToString();

                        float valor = -1 * float.Parse(registro["Valor"].ToString());
                        textBoxDescricaoRegistro.Text = registro["Descricao"].ToString();
                        comboBoxCategoriaRegistro.Text = categoria;
                        textBoxValorRegistro.Text = valor.ToString();
                        dateTimePickerDataPagamentoReg.Value = DateTime.Parse(registro["DataPagamento"].ToString());
                        dateTimePickerDataVencimentoReg.Value = DateTime.Parse(registro["DataPagamento"].ToString());
                    }
                }
            }
        }
    }
}
