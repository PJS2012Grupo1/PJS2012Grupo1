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
    public partial class Form1 : Form
    {
        DataSet dados = new DataSet();
        SqlDataAdapter adaptadorReg = new SqlDataAdapter();
        SqlDataAdapter adaptadorCat = new SqlDataAdapter();
        int mesCarregado;
        int anoCarregado;

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

        public void atulizalist(DataRow registro, string categoria, string dataVencimento, string dataPagamento)
        {
            ListViewItem item = new ListViewItem(registro["Descricao"].ToString());
            item.UseItemStyleForSubItems = false;
            ListViewItem.ListViewSubItem subItemValor = new ListViewItem.ListViewSubItem(item, registro["Valor"].ToString());
            ListViewItem.ListViewSubItem subItemCategoria = new ListViewItem.ListViewSubItem(item, categoria);
            ListViewItem.ListViewSubItem subItemDataCadastro = new ListViewItem.ListViewSubItem(item, ((DateTime)registro["DataCadastro"]).ToString("dd/MM/yyy"));
            ListViewItem.ListViewSubItem subItemDataVencimento = new ListViewItem.ListViewSubItem(item, dataVencimento);
            ListViewItem.ListViewSubItem subItemDataPagamento = new ListViewItem.ListViewSubItem(item, dataPagamento);

            if (float.Parse(registro["Valor"].ToString()) < 0)
                subItemValor.ForeColor = Color.Red;
            else
                subItemValor.ForeColor = Color.Blue;
            item.Tag = registro["Codigo"].ToString();
            item.SubItems.Add(subItemValor);
            item.SubItems.Add(subItemCategoria);
            item.SubItems.Add(subItemDataCadastro);
            item.SubItems.Add(subItemDataVencimento);
            item.SubItems.Add(subItemDataPagamento);
            listViewPrincipal.Items.Add(item);
        }

        //Adiciona os itens do ListView Principal
        public void adicionaItensListView(DataRow registro)
        {
            string dataVencimento;
            string dataPagamento;
            string categoria = "";
            DateTime data = DateTime.Now;
            DateTime data2 = DateTime.Now;

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
            
            if(registro["DataVencimento"].ToString()!="")
                data = DateTime.Parse(registro["DataVencimento"].ToString());
            else
               data2 = DateTime.Parse(registro["DataCadastro"].ToString());
            string mes = labelNomeMes.Text;
            string[] label_mes_ano = mes.Split(' ');
            string nome_mes = label_mes_ano[0];
            string nome_ano = label_mes_ano[2];
            int num_mes = atualizaMes(nome_mes);
            int num_ano = int.Parse(nome_ano);

            if (registro["Recorrente"].ToString() != "2")
            {
                if (data.Month == num_mes && data.Year == num_ano)
                {
                    atulizalist(registro, categoria, dataVencimento, dataPagamento);
                }
            }
            else
            {
                if (data2.Year < num_ano || (data2.Month <= num_mes && data2.Year == num_ano))
                {
                   atulizalist(registro, categoria, dataVencimento, dataPagamento);
                }
            }       
        }

        //Adiciona as Categorias e orçamentos
        public void adicionaCat()
        {
            listViewCategorias.Items.Clear();
            float gasto = 0;
            DataRow[] registroCat = dados.Tables["Categoria"].Select("CodigoCat > 0");
            DataRow[] registro = dados.Tables["Registros"].Select("Codigo > 0");

            foreach (DataRow categoria in dados.Tables["Categoria"].Rows)
            {                
                ListViewItem item = new ListViewItem(categoria["DescricaoCat"].ToString());
                item.UseItemStyleForSubItems = false;
                ListViewItem.ListViewSubItem subItemOrcamento = new ListViewItem.ListViewSubItem(item, categoria["Orcamento"].ToString());

                for (int i = 0; i < registro.Length; i++)
                    if (float.Parse(registro[i]["Valor"].ToString()) < 0)
                        if (registro[i]["Categoria"].ToString() == categoria["CodigoCat"].ToString())
                            gasto += float.Parse(registro[i]["Valor"].ToString());

                gasto *= -1;
                
               ListViewItem.ListViewSubItem subItemConta = new ListViewItem.ListViewSubItem(item, gasto.ToString());

               if (gasto > float.Parse(categoria["Orcamento"].ToString()))
                   subItemConta.ForeColor = Color.Red;
               else
                   subItemConta.ForeColor = Color.Blue;
               
               item.SubItems.Add(subItemOrcamento);
               item.SubItems.Add(subItemConta);
               listViewCategorias.Items.Add(item);

               gasto = 0;
            }
        }
        //Atualiza list view por data
        public void atualizaListView(int mes, int ano)
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

        //Atualiza list view todos os cadastros
        public void atualizaListView()
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

        public void atualizaMesListView()
        {
            string mes;
            switch (mesCarregado)
            {
                case 1: mes = "Janeiro"; break;
                case 2: mes = "Fevereiro"; break;
                case 3: mes = "Março"; break;
                case 4: mes = "Abril"; break;
                case 5: mes = "Maio"; break;
                case 6: mes = "Junho"; break;
                case 7: mes = "Julho"; break;
                case 8: mes = "Agosto"; break;
                case 9: mes = "Setembro"; break;
                case 10: mes = "Outubro"; break;
                case 11: mes = "Novembro"; break;
                case 12: mes = "Dezembro"; break;

                default: mes = " ";break;
            }
            labelNomeMes.Text = mes + " de " + anoCarregado.ToString();
        }

        //Preenche o comboBox com as categorias
        public void carregaCat()
        {
            comboBoxCategoria.Items.Clear();
            foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                comboBoxCategoria.Items.Add(registro["DescricaoCat"].ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mesCarregado = DateTime.Now.Month;
            anoCarregado = DateTime.Now.Year;

            atualizaMesListView();

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=(local);Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI";

            //Comandos para a seleção
            SqlCommand comandoSelecaoReg = new SqlCommand("select * from Registros order by Categoria, Descricao;", conexao);

            adaptadorReg.SelectCommand = comandoSelecaoReg;

            //SqlCommand comandoSelecaoCat = new SqlCommand("Select * from Categoria", conexao);
            //adaptador.SelectCommand = comandoSelecaoCat;
            SqlCommand comandoSelecaoCat = new SqlCommand("Select * from Categoria", conexao);
            adaptadorCat.SelectCommand = comandoSelecaoCat;
            
            //SqlCommand comandoInsercaoCat = new SqlCommand("Insert into Categoria (DescricaoCat, Orcamento) values (@DescricaoCat, @Orcamento)", conexao);
            //SqlParameter prmDescricaoCat = new SqlParameter("@DescricaoCat", SqlDbType.VarChar, 40);
            //prmDescricaoCat.SourceColumn = "DescricaoCat";
            //prmDescricaoCat.SourceVersion = DataRowVersion.Current;
            //comandoInsercaoCat.Parameters.Add(prmDescricaoCat);

            //SqlParameter prmOrcamento = new SqlParameter("@Orcamento", SqlDbType.Decimal);
            //prmOrcamento.SourceColumn = "Orcamento";
            //prmOrcamento.SourceVersion = DataRowVersion.Current;
            //comandoInsercaoCat.Parameters.Add(prmOrcamento);

            //adaptadorCat.InsertCommand = comandoInsercaoCat;
            

            SqlCommand comandoAtualizacaoCat = new SqlCommand("Update Categoria set DescricaoCat = @DescricaoCat, Orcamento = @Orcamento where CodigoCat = @CodigoCat", conexao);
            SqlParameter prmDescricaoCat = new SqlParameter("@DescricaoCat", SqlDbType.VarChar, 40);
            prmDescricaoCat.SourceColumn = "DescricaoCat";
            prmDescricaoCat.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoCat.Parameters.Add(prmDescricaoCat);

            SqlParameter prmOrcamento = new SqlParameter("@Orcamento", SqlDbType.Decimal);
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
            SqlParameter prmCodigo = new SqlParameter("@Codigo", SqlDbType.Int);
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
            Caixa cadastroCaixa = new Caixa(dados, adaptadorReg, adaptadorCat);
            cadastroCaixa.ShowDialog(this);

            atualizaListView();
        }

        //Botão que efetua a busca
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            listViewPrincipal.Items.Clear();

            int categoria = 0;

            //Busca combinada de categoria e descrição
            if (checkBoxCategoria.Checked == true && checkBoxDescricao.Checked == true)
            {
                foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                    if (comboBoxCategoria.Text == registro["DescricaoCat"].ToString())
                        categoria = int.Parse(registro["CodigoCat"].ToString());

                DataRow[] registros = dados.Tables["Registros"].Select("Categoria = '"+categoria+ "' and DataCadastro >= '" + dateTimePickerDataMinima.Value + "' and DataCadastro <= '" + dateTimePickerDataMaxima.Value + "' and Descricao like '%" + textBoxDescricao.Text + "%'");

                if (registros.Length != 0)
                    foreach (DataRow registro in registros)
                        adicionaItensListView(registro);
                return;
            }

            //Busca combinada com os três elementos
            if (checkBoxData.Checked == true && (checkBoxCategoria.Checked == true || checkBoxDescricao.Checked == true))
            {
                foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                    if (comboBoxCategoria.Text == registro["DescricaoCat"].ToString())
                        categoria = int.Parse(registro["CodigoCat"].ToString());

                DataRow[] registros = dados.Tables["Registros"].Select("Categoria = '" + categoria + "' and DataCadastro >= '" + dateTimePickerDataMinima.Value + "' and DataCadastro <= '" + dateTimePickerDataMaxima.Value + "' and Descricao like '%" + textBoxDescricao.Text + "%'");

                if (registros.Length != 0)
                    foreach (DataRow registro in registros)
                        adicionaItensListView(registro);
                return;
            }
            //Busca só pela descrição
            if (checkBoxDescricao.Checked == true)
            {
                DataRow[] registros = dados.Tables["Registros"].Select("Descricao like '%" + textBoxDescricao.Text + "%' and DataCadastro >= '" + dateTimePickerDataMinima.Value + "' and DataCadastro <= '" + dateTimePickerDataMaxima.Value + "'");

                if (registros.Length != 0)
                {
                    listViewPrincipal.Items.Clear();
                    foreach (DataRow registro in registros)
                        adicionaItensListView(registro);
                }
            }
            //Busca pela intervalo de data
            if (checkBoxData.Checked == true)
            {                
                DataRow[] registros = dados.Tables["Registros"].Select("DataCadastro >= '" + dateTimePickerDataMinima.Value + "' and DataCadastro <= '" + dateTimePickerDataMaxima.Value+"'");

                if (registros.Length != 0)
                    foreach (DataRow registro in registros)
                        adicionaItensListView(registro);
            }
            //Busca pela categoria
            if (checkBoxCategoria.Checked == true)
            {
                foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                    if (comboBoxCategoria.Text == registro["DescricaoCat"].ToString())
                        categoria = int.Parse(registro["CodigoCat"].ToString());

                DataRow[] registros = dados.Tables["Registros"].Select("Categoria = '" + categoria + "' and DataCadastro >= '" + dateTimePickerDataMinima.Value + "' and DataCadastro <= '" + dateTimePickerDataMaxima.Value + "'");

                if (registros.Length != 0)
                    foreach (DataRow registro in registros)
                        adicionaItensListView(registro);
            }
        }

        //Limpa a aba de busca
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

        //Verifica o que está selecionado para efetuar a busca
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

            carregaCat();
            adicionaCat();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio(dados, this);
            relatorio.ShowDialog(this);            
        }

        //Altera um registro por meio de um clique duplo
        private void listViewPrincipal_DoubleClick(object sender, EventArgs e)
        {

            DataRow registro = dados.Tables["Registros"].Rows.Find(listViewPrincipal.SelectedItems[0].Tag);

            if (registro["DataVencimento"].ToString() == "")
            {
                Caixa cadastroCaixa = new Caixa(registro, true, dados, adaptadorReg, adaptadorCat);
                cadastroCaixa.ShowDialog(this);
            }
            else
            {
                Registros cadastroPrograma = new Registros(registro, true, dados, adaptadorReg, adaptadorCat);
                cadastroPrograma.ShowDialog(this);
            }
            atualizaListView();
        }

        //Deleta um registro
        private void listViewPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listViewPrincipal.SelectedItems.Count > 0)
            {
                DataRow registro = dados.Tables["Registros"].Rows.Find(listViewPrincipal.SelectedItems[0].Tag);
                if (registro["Recorrente"].ToString() == "2")
                {
                    //colocar mais um atributo de data no banco!!!
                }
                registro.Delete();
                adaptadorReg.Update(dados, "Registros");

                atualizaListView();
            }
        }

        //Navega pelo botão 'Anterior'
        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            buttonProximo.Enabled = true;
            
            if (!(mesCarregado == 2 && anoCarregado == 2000))
            {
                if (mesCarregado == 1)
                {
                    anoCarregado -= 1;
                    mesCarregado = 12;
                }
                else
                {
                    mesCarregado -= 1;
                }

                atualizaMesListView();
                atualizaListView();
            }
            else
            {
                buttonAnterior.Enabled = false;
            }
        }

        //Navega pelo botão 'Próximo'
        private void buttonProximo_Click(object sender, EventArgs e)
        {
            buttonAnterior.Enabled = true;
            if (!(mesCarregado == 11 && anoCarregado == 2020))
            {
                if (mesCarregado == 12)
                {
                    anoCarregado += 1;
                    mesCarregado = 1;
                    
                }
                else
                    mesCarregado += 1;

                atualizaMesListView();
                atualizaListView();
            }
            else
                buttonProximo.Enabled = false;
        }

        public int atualizaMes(string s)
        {
            int numero_mes = 0;
            switch (s)
            {
                case "Janeiro": numero_mes = 1; break;
                case "Fevereiro": numero_mes = 2; break;
                case "Março": numero_mes = 3; break;
                case "Abril": numero_mes = 4; break;
                case "Maio": numero_mes = 5; break;
                case "Junho": numero_mes = 6; break;
                case "Julho": numero_mes = 7; break;
                case "Agosto": numero_mes = 8; break;
                case "Setembro": numero_mes = 9; break;
                case "Outubro": numero_mes = 10; break;
                case "Novembro": numero_mes = 11; break;
                case "Dezembro": numero_mes = 12; break;
            }
            return numero_mes;
        }

        private void projeçãoDeGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjecaoDeGastos projecaoGastos = new ProjecaoDeGastos();
            projecaoGastos.ShowDialog(this);
        }
    }
}
