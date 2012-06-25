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
        //Data Source=(local);Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI
        DataSet dados = new DataSet();
        AdaptadorRegistros registros;
        AdaptadorCategoria categoria;
        int mesCarregado;
        int anoCarregado;

        public Form1()
        {
            InitializeComponent();
        }

        //Coloca o nome do mes por extenso
        private string nomeMes(int mes)
        {
            switch (mes)
            {
                case 1:  return "Janeiro";
                case 2:  return "Fevereiro";
                case 3:  return "Março";
                case 4:  return "Abril";
                case 5:  return "Maio";
                case 6:  return "Junho";
                case 7:  return "Julho";
                case 8:  return "Agosto";
                case 9:  return "Setembro";
                case 10: return "Outubro";
                case 11: return "Novembro";
                case 12: return "Dezembro";
                default: return "";
            }
        }

        //carrega o numero do mes
        public int atualizaMes(string mes)
        {
            switch (mes)
            {
                case "Janeiro":   return 1;
                case "Fevereiro": return 2;
                case "Março":     return 3;
                case "Abril":     return 4;
                case "Maio":      return 5;
                case "Junho":     return 6;
                case "Julho":     return 7;
                case "Agosto":    return 8;
                case "Setembro":  return 9;
                case "Outubro":   return 10;
                case "Novembro":  return 11;
                case "Dezembro":  return 12;
                default: return 0;
            }
        }

        public void atualizaGroupBoxDadosMes(float contas, float caixa)
        {
            contas *= -1;
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
            string mes = nomeMes(mesCarregado);
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
            toolStripStatusLabelStatus.Text = "Conectando Banco de Dados";
            mesCarregado = DateTime.Now.Month;
            anoCarregado = DateTime.Now.Year;

            comboBoxMes.SelectedIndex = mesCarregado - 1;
            comboBoxAno.SelectedItem = anoCarregado.ToString();

            try
            {
                registros = new AdaptadorRegistros("Data Source=(local);Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI");
                categoria = new AdaptadorCategoria("Data Source=(local);Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI");

                atualizaMesListView();

                registros.adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                categoria.adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                registros.adaptador.Fill(dados, "Registros");
                categoria.adaptador.Fill(dados, "Categoria");

                atualizaListView();
                adicionaCat();
                carregaCat();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel conectar com o Banco de Dados.", "Erro ao Conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros cadastroRegistro = new Registros(dados, registros.adaptador, categoria.adaptador);
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
            Caixa cadastroCaixa = new Caixa(dados, registros.adaptador, categoria.adaptador);
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
            FormCadastroCategoria cadastroCategoria = new FormCadastroCategoria(dados, categoria.adaptador);
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
                Caixa cadastroCaixa = new Caixa(registro, true, dados, registros.adaptador, categoria.adaptador);
                cadastroCaixa.ShowDialog(this);
            }
            else
            {
                Registros cadastroPrograma = new Registros(registro, true, dados, registros.adaptador, categoria.adaptador);
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
                registros.adaptador.Update(dados, "Registros");

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
            }
            else
            {
                mesCarregado = 1;
                anoCarregado = 2000;
                buttonAnterior.Enabled = false;
            }
            atualizaMesListView();
            atualizaListView();
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
                {
                    mesCarregado += 1;
                }
            }
            else
            {
                mesCarregado = 12;
                anoCarregado = 2020;
                buttonProximo.Enabled = false;
            }
                atualizaMesListView();
                atualizaListView();
        }

        

        private void projeçãoDeGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjecaoDeGastos projecaoGastos = new ProjecaoDeGastos();
            projecaoGastos.ShowDialog(this);
        }

        private void buttonIrData_Click(object sender, EventArgs e)
        {
            if (mesCarregado == 1 && anoCarregado == 2000)
            {
                buttonAnterior.Enabled = false;
            }
            else if (mesCarregado == 12 && anoCarregado == 2020)
            {
                buttonProximo.Enabled = false;
            }
            mesCarregado = comboBoxMes.SelectedIndex + 1;
            anoCarregado = int.Parse(comboBoxAno.SelectedItem.ToString());
            atualizaMesListView();
            atualizaListView();
        }

        private void buttonMesAtual_Click(object sender, EventArgs e)
        {
            mesCarregado = DateTime.Now.Month;
            anoCarregado = DateTime.Now.Year;
            atualizaMesListView();
            atualizaListView();
        }

        private void deletarSelecionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
