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
        DataRow registro;
        bool atualiza = false;
        SqlDataAdapter adaptadorReg = new SqlDataAdapter();
        SqlDataAdapter adaptadorCat;

        public Registros(DataSet dados, SqlDataAdapter adaptadorReg, SqlDataAdapter adaptadorCat)
        {
            this.dados = dados;
            this.adaptadorReg = adaptadorReg;
            this.adaptadorCat = adaptadorCat;
            InitializeComponent();
        }

        public Registros(DataRow registro, bool atualiza, DataSet dados, SqlDataAdapter adaptadorReg, SqlDataAdapter adaptadorCat)
        {
            this.atualiza = atualiza;
            this.registro = registro;
            this.dados = dados;
            this.adaptadorCat = adaptadorCat;
            this.adaptadorReg = adaptadorReg;
            InitializeComponent();
        }
        
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxDescricaoRegistro.Text = "";
            textBoxValorRegistro.Text = "";
            comboBoxCategoriaRegistro.Text = "";
            comboBoxQtdeParcelasReg.Text = "";
            comboBoxFormaPagamento.Text = "";
            dateTimePickerDataPagamentoReg.Text = dateTimePickerDataVencimentoReg.Text = DateTime.Now.ToShortDateString();
        }

        private void buttonCancelarRegistro_Click(object sender, EventArgs e)
        {
            Close();
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
            else if (comboBoxFormaPagamento.SelectedIndex == -1)
            {
                labelCampoPreenchidos.Text = "Forma de pagamento não selecionada.";
                labelCampoPreenchidos.Visible = true;
            }
            else
            {
                labelCampoPreenchidos.Visible = false;

                int recorrente = 1;
                int parcelas;
                int categoria = 0;                

                foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                    if (comboBoxCategoriaRegistro.Text == registro["DescricaoCat"].ToString())
                        categoria = int.Parse(registro["CodigoCat"].ToString());

                if (comboBoxFormaPagamento.SelectedIndex == 1)
                    parcelas = int.Parse(comboBoxQtdeParcelasReg.Text);
                else
                {
                    parcelas = 1;
                    if (comboBoxFormaPagamento.SelectedIndex == 2)
                        recorrente = 2;
                }

                if (atualiza)
                {
                    registro["Descricao"] = textBoxDescricaoRegistro.Text;
                    registro["Valor"] = "-" + textBoxValorRegistro.Text;
                    registro["Categoria"] = categoria;
                    registro["Recorrente"] = recorrente;
                    registro["DataVencimento"] = dateTimePickerDataVencimentoReg.Value;
                    registro["DataPagamento"] = dateTimePickerDataPagamentoReg.Value;
                    adaptadorReg.Update(dados, "Registros");
                }
                else if (parcelas > 1)
                {
                    float valor = (float.Parse(textBoxValorRegistro.Text) / parcelas);
                    string data = dateTimePickerDataVencimentoReg.Value.ToString("dd/MM/yyyy");
                    string[] datas = data.Split('/');
                    int mes = int.Parse(datas[1]);
                    int ano = int.Parse(datas[2]);

                    foreach(string p in datas)
                        MessageBox.Show(p);

                    for (int i = 1; i <= parcelas; i++)
                    {
                        if (mes > 12)
                        {
                            mes = 1;
                            ano += 1;
                        }
                        DataRow novoRegistro = dados.Tables["Registros"].NewRow();
                        novoRegistro["Descricao"] = textBoxDescricaoRegistro.Text + " " + i + "/" + parcelas;
                        novoRegistro["Valor"] = "-" + valor;
                        novoRegistro["Categoria"] = categoria;
                        novoRegistro["Recorrente"] = recorrente;
                        novoRegistro["DataVencimento"] = datas[0] + "/" + mes + "/" + ano;
                        if (i == 1)
                            novoRegistro["DataPagamento"] = dateTimePickerDataPagamentoReg.Value;
                        novoRegistro["DataCadastro"] = DateTime.Now.ToShortDateString();
                        dados.Tables["Registros"].Rows.Add(novoRegistro);
                        adaptadorReg.Update(dados, "Registros");
                        mes = mes + 1;
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
                    dados.Tables["Registros"].Rows.Add(novoRegistro);
                    adaptadorReg.Update(dados, "Registros");
                }
                Close();
            }
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=(local);Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI";
            
            SqlCommand comandoInsercaoReg = new SqlCommand("Insert into Registros (Descricao, Valor, Categoria, Recorrente, DataVencimento, DataPagamento, DataCadastro) values (@Desc, @Valor, @Categoria, @Recorrente, @DataVencimento, @DataPagamento, @DataCadastro)", conexao);
            SqlParameter prmDescricao = new SqlParameter("@Desc", SqlDbType.VarChar, 40);
            prmDescricao.SourceColumn = "Descricao";
            prmDescricao.SourceVersion = DataRowVersion.Current;
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

            SqlCommand comandoAtualizacaoReg = new SqlCommand("Update Registros set Descricao = @Descricao, Valor = @Valor, Categoria = @Categoria, Recorrente = @Recorrente, DataVencimento = @DataVencimento, DataPagamento = @DataPagamento where Codigo = @Codigo", conexao);
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

            prmDataVencimento = new SqlParameter("@DataVencimento", SqlDbType.Date);
            prmDataVencimento.SourceColumn = "DataVencimento";
            prmDataVencimento.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmDataVencimento);

            prmDataPagamento = new SqlParameter("@DataPagamento", SqlDbType.Date);
            prmDataPagamento.SourceColumn = "DataPagamento";
            prmDataPagamento.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmDataPagamento);

            SqlParameter prmCodigo = new SqlParameter("@Codigo", SqlDbType.Int);
            prmCodigo.SourceColumn = "Codigo";
            prmCodigo.SourceVersion = DataRowVersion.Original;
            comandoAtualizacaoReg.Parameters.Add(prmCodigo);

            adaptadorReg.UpdateCommand = comandoAtualizacaoReg;
            adaptadorReg.InsertCommand = comandoInsercaoReg;

            adaptadorReg.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adaptadorReg.Fill(dados, "Registros");

            foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                comboBoxCategoriaRegistro.Items.Add(registro["DescricaoCat"].ToString());

            if (atualiza)
            {
                string categoria = " ";
                float valor = -1 * float.Parse(registro["Valor"].ToString());
                int formaPagamento = -1;
                DateTime data;

                foreach (DataRow registroCat in dados.Tables["Categoria"].Rows)
                    if (registro["Categoria"].ToString() == registroCat["CodigoCat"].ToString())
                        categoria = registroCat["DescricaoCat"].ToString();

                if (int.Parse(registro["Recorrente"].ToString()) == 2)
                    formaPagamento = 2;

                //else if (int.Parse(registro["Parcelas"].ToString()) > 1)
                //{
                //    formaPagamento = 1;
                //    comboBoxQtdeParcelasReg.Text = registro["Parcelas"].ToString();
                //}
                //else
                //{
                //    comboBoxQtdeParcelasReg.Enabled = false;
                //    formaPagamento = 0;
                //}

                if (registro["DataPagamento"].ToString() == "")
                    data = DateTime.Parse(DateTime.Now.ToShortDateString());
                else
                    data = DateTime.Parse(registro["DataPagamento"].ToString());


                textBoxDescricaoRegistro.Text = registro["Descricao"].ToString();
                comboBoxCategoriaRegistro.Text = categoria;
                comboBoxFormaPagamento.SelectedIndex = formaPagamento;
                textBoxValorRegistro.Text = valor.ToString();
                dateTimePickerDataPagamentoReg.Value = data;
                dateTimePickerDataVencimentoReg.Value = DateTime.Parse(registro["DataVencimento"].ToString());
                //if (comboBoxFormaPagamento.SelectedIndex == 1)
                //    comboBoxFormaPagamento.Enabled = true;

                //if (comboBoxFormaPagamento.SelectedIndex != 0 || comboBoxFormaPagamento.SelectedIndex != 1)
                //    comboBoxFormaPagamento.Enabled = false;
            }
        }

        private void comboBoxFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFormaPagamento.SelectedIndex == 1)
                comboBoxQtdeParcelasReg.Enabled = true;
            else
                comboBoxQtdeParcelasReg.Enabled = false;
        }
    }
}
