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
    public partial class Form1 : Form
    {
        DataSet dados = new DataSet();
        SqlDataAdapter adaptadorReg = new SqlDataAdapter();
        SqlDataAdapter adaptadorCat = new SqlDataAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        public void atualizaGroupBoxDadosMes(float contas, float caixa)
        {
            contas *= -1;
            groupBoxDadosMes.Text = "Mes: " + labelNomeMes.Text;
            labelTotalCaixaValor.Text = "R$ " + caixa.ToString("0.00");
            labelTotalContasValor.Text = "R$ " + contas.ToString("0.00");
            labelSaldoValor.Text = "R$ " + (caixa - contas).ToString("0.00");
        }

        public void adicionaItensListView(DataRow registro)
        {
            string dataVencimento;
            string dataPagamento;
            string categoria = "";

            if (registro["DataVencimento"].ToString() == "")
                dataVencimento = " ";
            else
                dataVencimento = ((DateTime)registro["DataVencimento"]).ToString("dd/MM/yyy");
            if (registro["DataPagamento"].ToString() == "")
                dataPagamento = " ";
            else
                dataPagamento = ((DateTime)registro["DataPagamento"]).ToString("dd/MM/yyy");

            foreach (DataRow registroCat in dados.Tables["Categoria"].Rows)
                if (registro["Categoria"].ToString() == registroCat["CodigoCat"].ToString())
                    categoria = registroCat["DescricaoCat"].ToString();
                
            ListViewItem item = new ListViewItem(registro["Descricao"].ToString());
            ListViewItem.ListViewSubItem subItemValor = new ListViewItem.ListViewSubItem(item, registro["Valor"].ToString());
            ListViewItem.ListViewSubItem subItemCategoria = new ListViewItem.ListViewSubItem(item, categoria);
            ListViewItem.ListViewSubItem subItemDataCadastro = new ListViewItem.ListViewSubItem(item, ((DateTime)registro["DataCadastro"]).ToString("dd/MM/yyy"));
            ListViewItem.ListViewSubItem subItemDataVencimento = new ListViewItem.ListViewSubItem(item, dataVencimento);
            ListViewItem.ListViewSubItem subItemDataPagamento = new ListViewItem.ListViewSubItem(item, dataPagamento);
            item.Tag = registro["Codigo"].ToString();
            item.SubItems.Add(subItemValor);
            item.SubItems.Add(subItemCategoria);
            item.SubItems.Add(subItemDataCadastro);
            item.SubItems.Add(subItemDataVencimento);
            item.SubItems.Add(subItemDataPagamento);
            listViewPrincipal.Items.Add(item);
        }

        public void adicionaCat()
        {
            listViewCategorias.Items.Clear();
            float gasto = 0;
            //int c = 0;
            //int t = 0;
            DataRow[] registroCat = dados.Tables["Categoria"].Select("CodigoCat > 0");
            DataRow[] registro = dados.Tables["Registros"].Select("Codigo > 0");
            foreach (DataRow categoria in dados.Tables["Categoria"].Rows)
            {
                
                ListViewItem item = new ListViewItem(categoria["DescricaoCat"].ToString());
                ListViewItem.ListViewSubItem subItemOrcamento = new ListViewItem.ListViewSubItem(item, categoria["Orcamento"].ToString());

                for (int i = 0; i < registro.Length; i++)
                {
                    if (registro[i]["Categoria"].ToString() == categoria["CodigoCat"].ToString())
                        gasto += float.Parse(registro[i]["Valor"].ToString());
                }
                

               ListViewItem.ListViewSubItem subItemConta = new ListViewItem.ListViewSubItem(item, gasto.ToString());
               
               item.SubItems.Add(subItemOrcamento);
               item.SubItems.Add(subItemConta);
               listViewCategorias.Items.Add(item);
               gasto = 0;
            }
        }

        public void atualizaListView() //Atualiza list view
        {
            listViewPrincipal.Items.Clear();
            float totalPositivo = 0f;
            float totalNegativo = 0f;
            foreach (DataRow registro in dados.Tables["Registros"].Rows)
            {
                adicionaItensListView(registro);
                if (float.Parse(registro["Valor"].ToString()) < 0)
                    totalNegativo += float.Parse(registro["Valor"].ToString());
                else
                    totalPositivo += float.Parse(registro["Valor"].ToString());
            }
            atualizaGroupBoxDadosMes(totalNegativo, totalPositivo);

        }

        public void carregaCat()
        {
            comboBoxCategoria.Items.Clear();
            foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                comboBoxCategoria.Items.Add(registro["DescricaoCat"].ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=pc02lab3\\MSSQLSERVER1;Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI";

            //Comandos para a seleção
            SqlCommand comandoSelecaoReg = new SqlCommand("select * from Registros;", conexao);

            adaptadorReg.SelectCommand = comandoSelecaoReg;

            //SqlCommand comandoSelecaoCat = new SqlCommand("Select * from Categoria", conexao);
            //adaptador.SelectCommand = comandoSelecaoCat;
            SqlCommand comandoSelecaoCat = new SqlCommand("Select * from Categoria", conexao);
            adaptadorCat.SelectCommand = comandoSelecaoCat;


            //Comandos para a inserção de dados
            SqlCommand comandoInsercaoReg = new SqlCommand("Insert into Registros (Descricao, Valor, Categoria, Recorrente, DataVencimento, DataPagamento, DataCadastro, Parcelas) values ('@Descricao', @Valor, @Categoria, @Recorrente, @DataVencimento, @DataPagamento, @DataCadastro, @Parcelas)", conexao);
            SqlParameter prmDescricao = new SqlParameter("@Descricao", SqlDbType.VarChar, 40);
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

            SqlParameter prmParcelas = new SqlParameter("@Parcelas", SqlDbType.Int);
            prmParcelas.SourceColumn = "Parcelas";
            prmParcelas.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmParcelas);

            adaptadorReg.InsertCommand = comandoInsercaoReg;


            SqlCommand comandoInsercaoCat = new SqlCommand("Insert into Categoria (DescricaoCat, Orcamento) values (@DescricaoCat, @Orcamento)", conexao);
            SqlParameter prmDescricaoCat = new SqlParameter("@DescricaoCat", SqlDbType.VarChar, 40);
            prmDescricao.SourceColumn = "DescricaoCat";
            prmDescricao.SourceVersion = DataRowVersion.Current;
            comandoInsercaoCat.Parameters.Add(prmDescricaoCat);

            SqlParameter prmOrcamento = new SqlParameter("@Orcamento", SqlDbType.Decimal);
            prmOrcamento.SourceColumn = "Orcamento";
            prmOrcamento.SourceVersion = DataRowVersion.Current;
            comandoInsercaoCat.Parameters.Add(prmOrcamento);

            adaptadorCat.InsertCommand = comandoInsercaoCat;

        

            //Comandos para Atualização
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

            SqlCommand comandoAtualizacaoCat = new SqlCommand("Update Categoria set DescricaoCat = @DescricaoCat, Orcamento = @Orcamento where CodigoCat = @CodigoCat", conexao);
            prmDescricaoCat = new SqlParameter("@DescricaoCat", SqlDbType.VarChar, 40);
            prmDescricaoCat.SourceColumn = "DescricaoCat";
            prmDescricaoCat.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoCat.Parameters.Add(prmDescricaoCat);

            prmOrcamento = new SqlParameter("@Orcamento", SqlDbType.Decimal);
            prmOrcamento.SourceColumn = "Orcamento";
            prmOrcamento.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoCat.Parameters.Add(prmOrcamento);

            SqlParameter prmCodigoCat = new SqlParameter("@CodigoCat", SqlDbType.Int);
            prmCodigoCat.SourceColumn = "CodigoCat";
            prmCodigoCat.SourceVersion = DataRowVersion.Original;
            comandoAtualizacaoCat.Parameters.Add(prmCodigoCat);

            adaptadorCat.UpdateCommand = comandoAtualizacaoCat;

            //Caomandos para a remoção de dados
            SqlCommand comandoRemocaoReg = new SqlCommand("Delete from Registros where Codigo = @Codigo", conexao);
            prmCodigo = new SqlParameter("@Codigo", SqlDbType.Int);
            prmCodigo.SourceColumn = "Codigo";
            prmCodigo.SourceVersion = DataRowVersion.Original;
            comandoRemocaoReg.Parameters.Add(prmCodigo);
            adaptadorReg.DeleteCommand = comandoRemocaoReg;

            SqlCommand comandoRemocaoCat = new SqlCommand("Delete from Categoria where CodigoCat = @CodigoCat", conexao);
            prmCodigoCat = new SqlParameter("@CodigoCat", SqlDbType.Int);
            prmCodigoCat.SourceColumn = "CodigoCat";
            prmCodigoCat.SourceVersion = DataRowVersion.Original;
            comandoRemocaoCat.Parameters.Add(prmCodigoCat);
            adaptadorCat.DeleteCommand = comandoRemocaoCat;

            adaptadorReg.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptadorCat.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            
            adaptadorReg.Fill(dados, "Registros");
            adaptadorCat.Fill(dados, "Categoria");

            atualizaListView();
            adicionaCat();
            carregaCat();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros cadastroRegistro = new Registros(dados, adaptadorReg, adaptadorCat);
            cadastroRegistro.ShowDialog(this);

            atualizaListView();
            adicionaCat();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Caixa cadastroCaixa = new Caixa(dados, adaptadorCat);
            cadastroCaixa.ShowDialog(this);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int categoria = 0;
            listViewPrincipal.Items.Clear();

            if (checkBoxCategoria.Checked == true && checkBoxDescricao.Checked == true)
            {
                foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                    if (comboBoxCategoria.Text == registro["DescricaoCat"].ToString())
                        categoria = int.Parse(registro["CodigoCat"].ToString());

                DataRow[] registros = dados.Tables["Registros"].Select("Categoria = '"+categoria+ "' and DataCadastro >= '" + dateTimePickerDataMinima.Value + "' and DataCadastro <= '" + dateTimePickerDataMaxima.Value + "' and Descricao like '%" + textBoxDescricao.Text + "%'");

                if (registros.Length != 0)
                {
                    foreach (DataRow registro in registros)
                    {
                        adicionaItensListView(registro);
                    }
                }
                return;
            }

            if (checkBoxData.Checked == true && (checkBoxCategoria.Checked == true || checkBoxDescricao.Checked == true))
            {
                foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                    if (comboBoxCategoria.Text == registro["DescricaoCat"].ToString())
                        categoria = int.Parse(registro["CodigoCat"].ToString());

                DataRow[] registros = dados.Tables["Registros"].Select("Categoria = '" + categoria + "' and DataCadastro >= '" + dateTimePickerDataMinima.Value + "' and DataCadastro <= '" + dateTimePickerDataMaxima.Value + "' and Descricao like '%" + textBoxDescricao.Text + "%'");

                if (registros.Length != 0)
                {
                    foreach (DataRow registro in registros)
                    {
                        adicionaItensListView(registro);
                    }
                }
                return;
            }

            if (checkBoxDescricao.Checked == true)
            {
                DataRow[] registros = dados.Tables["Registros"].Select("Descricao like '%" + textBoxDescricao.Text + "%' and DataCadastro >= '" + dateTimePickerDataMinima.Value + "' and DataCadastro <= '" + dateTimePickerDataMaxima.Value + "'");

                if (registros.Length != 0)
                {
                    listViewPrincipal.Items.Clear();
                    foreach (DataRow registro in registros)
                    {

                        adicionaItensListView(registro);

                    }
                }
            }

            if (checkBoxData.Checked == true)
            {
                
                DataRow[] registros = dados.Tables["Registros"].Select("DataCadastro >= '" + dateTimePickerDataMinima.Value + "' and DataCadastro <= '" + dateTimePickerDataMaxima.Value+"'");

                if (registros.Length != 0)
                {
                    foreach (DataRow registro in registros)
                    {
                        adicionaItensListView(registro);
                    }
                }
            }

            if (checkBoxCategoria.Checked == true)
            {
                
                foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                    if (comboBoxCategoria.Text == registro["DescricaoCat"].ToString())
                        categoria = int.Parse(registro["CodigoCat"].ToString());

                DataRow[] registros = dados.Tables["Registros"].Select("Categoria = '" + categoria + "' and DataCadastro >= '" + dateTimePickerDataMinima.Value + "' and DataCadastro <= '" + dateTimePickerDataMaxima.Value + "'");

                if (registros.Length != 0)
                {
                    foreach (DataRow registro in registros)
                    {
                        adicionaItensListView(registro);
                    }
                }
            }

         

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            atualizaListView();
            
            comboBoxCategoria.SelectedIndex = -1;
            textBoxDescricao.Text = "";
            dateTimePickerDataMinima.Value = dateTimePickerDataMinima.MinDate;
            dateTimePickerDataMaxima.Value = dateTimePickerDataMaxima.MaxDate;

            checkBoxCategoria.Checked = false;
            checkBoxData.Checked = false;
            checkBoxDescricao.Checked = false;

            dateTimePickerDataMinima.Enabled = false;
            dateTimePickerDataMaxima.Enabled = false;
            textBoxDescricao.Enabled = false;
            comboBoxCategoria.Enabled = false;
        }

        private void verificaCheckBox()
        {
            if (checkBoxDescricao.Checked == true || checkBoxData.Checked == true || checkBoxCategoria.Checked == true)
            {
                buttonBuscar.Enabled = true;
                buttonLimpar.Enabled = true;
            }
            else
            {
                buttonBuscar.Enabled = false;
                buttonLimpar.Enabled = false;
            }
        }

        private void checkBoxDescricao_Click(object sender, EventArgs e)
        {
            verificaCheckBox();
            if (checkBoxDescricao.Checked == true)
            {
                groupBoxDescricao.Enabled = true;
                textBoxDescricao.Enabled = true;
            }
            else
                groupBoxDescricao.Enabled = false;
        }

        private void checkBoxData_Click(object sender, EventArgs e)
        {
            verificaCheckBox();
            if (checkBoxData.Checked == true)
            {
                groupBoxData.Enabled = true;
                dateTimePickerDataMaxima.Enabled = true;
                dateTimePickerDataMinima.Enabled = true;
            }
            else
                groupBoxData.Enabled = false;
        }

        private void checkBoxCategoria_Click(object sender, EventArgs e)
        {
            verificaCheckBox();
            if (checkBoxCategoria.Checked == true)
            {
                groupBoxCategoria.Enabled = true;
                comboBoxCategoria.Enabled = true;
            }
            else
                groupBoxCategoria.Enabled = false;
        }

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCadastroCategoria cadastroCategoria = new FormCadastroCategoria(dados, adaptadorCat);
            cadastroCategoria.ShowDialog(this);

            //adicionaCat();
            carregaCat();

            adicionaCat();

        }

        private void listViewPrincipal_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataRow registro in dados.Tables["Registros"].Rows)
            {
                if (registro["Codigo"].ToString() == listViewPrincipal.SelectedItems[0].Tag)
                {
                    int codigo = listViewPrincipal.SelectedItems[0].Tag.ToString();
                    Registros cadastroPrograma = new Registros(codigo, true);
                    cadastroPrograma.ShowDialog(this);
                    break;
                }
            }          
        }


    }
}
