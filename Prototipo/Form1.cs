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
        AdaptadorRegistros registros;
        AdaptadorCategoria categorias;
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

            if (float.Parse(registro["Valor"].ToString()) < 0)
                subItemValor.ForeColor = Color.Red;

            else
                subItemValor.ForeColor = Color.Blue;

            item.UseItemStyleForSubItems = false;
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
                item.UseItemStyleForSubItems = false;
                ListViewItem.ListViewSubItem subItemOrcamento = new ListViewItem.ListViewSubItem(item, categoria["Orcamento"].ToString());

                for (int i = 0; i < registro.Length; i++)
                {
                    if (float.Parse(registro[i]["Valor"].ToString()) < 0)
                        if (registro[i]["Categoria"].ToString() == categoria["CodigoCat"].ToString())
                            gasto += float.Parse(registro[i]["Valor"].ToString());
                }
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

        public void atualizaListView(int mes, int ano) //Atualiza list view por data
        {
            listViewPrincipal.Items.Clear();
            float totalPositivo = 0f;
            float totalNegativo = 0f;

            foreach (DataRow registro in dados.Tables["Registros"].Rows)
            {
                DateTime data;
                if (registro["DataVencimento"].ToString() == "")
                    data = Convert.ToDateTime(registro["DataPagamento"].ToString());
                else
                    data = Convert.ToDateTime(registro["DataPagamento"].ToString());
                if (data.Month == mes && data.Year == ano)
                {
                    adicionaItensListView(registro);
                    if (float.Parse(registro["Valor"].ToString()) < 0)
                        totalNegativo += float.Parse(registro["Valor"].ToString());
                    else
                        totalPositivo += float.Parse(registro["Valor"].ToString());
                }
            }
            atualizaGroupBoxDadosMes(totalNegativo, totalPositivo);
        }

        public void atualizaListView() //Atualiza list view todos os cadastros
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

            
            switch (mesCarregado)
            {
                case 1: comboBoxMes.Text = "Janeiro"; break;
                case 2: comboBoxMes.Text = "Fevereiro"; break;
                case 3: comboBoxMes.Text = "Março"; break;
                case 4: comboBoxMes.Text = "Abril"; break;
                case 5: comboBoxMes.Text = "Maio"; break;
                case 6: comboBoxMes.Text = "Junho"; break;
                case 7: comboBoxMes.Text = "Julho"; break;
                case 8: comboBoxMes.Text = "Agosto"; break;
                case 9: comboBoxMes.Text = "Setembro"; break;
                case 10: comboBoxMes.Text = "Outubro"; break;
                case 11: comboBoxMes.Text = "Novembro"; break;
                case 12: comboBoxMes.Text = "Dezembro"; break;

                default: comboBoxMes.Text = " "; break;
            }

            comboBoxAno.Text = anoCarregado.ToString();

            atualizaMesListView();

            registros = new AdaptadorRegistros();
            categorias = new AdaptadorCategoria();

            registros.adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            categorias.adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            registros.adaptador.Fill(dados, "Registros");
            categorias.adaptador.Fill(dados, "Categoria");

            atualizaListView(mesCarregado,anoCarregado);
            adicionaCat();
            carregaCat();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros cadastroRegistro = new Registros(dados, registros.adaptador, categorias.adaptador);
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
            Caixa cadastroCaixa = new Caixa(dados, registros.adaptador, categorias.adaptador);
            cadastroCaixa.ShowDialog(this);
            atualizaListView();
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
            atualizaListView(mesCarregado,anoCarregado);
            
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
            FormCadastroCategoria cadastroCategoria = new FormCadastroCategoria(dados, categorias.adaptador);
            cadastroCategoria.ShowDialog(this);
            carregaCat();
            adicionaCat();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio(dados);
            relatorio.ShowDialog(this);            
        }

        private void listViewPrincipal_DoubleClick(object sender, EventArgs e)
        {
            int codigo = int.Parse(listViewPrincipal.SelectedItems[0].Tag.ToString());
            Registros cadastroPrograma = new Registros(codigo, true, dados, registros.adaptador, categorias.adaptador);
            cadastroPrograma.ShowDialog(this);
            atualizaListView();
        }

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
                atualizaListView(mesCarregado, anoCarregado);
            }
            else
            {
                buttonAnterior.Enabled = false;
            }
        }

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
                atualizaMesListView();
                atualizaListView(mesCarregado, anoCarregado);
            }
            else
            {
                buttonProximo.Enabled = false;
            }
        }

        private void buttonIrData_Click(object sender, EventArgs e)
        {
            mesCarregado = comboBoxMes.SelectedIndex + 1;
            anoCarregado = int.Parse(comboBoxAno.Text);
            atualizaListView(mesCarregado,anoCarregado);
            atualizaMesListView();


            if (mesCarregado == 12 && anoCarregado == 2020)
                buttonProximo.Enabled = false;
            else if (mesCarregado == 1 && anoCarregado == 2000)
                buttonAnterior.Enabled = false;
            
        }

    }
}
