using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ProjecaoDeGastos : Form
    {
        DataSet dados;
        
        public ProjecaoDeGastos(DataSet dados, Form form1)
        {
            InitializeComponent();
            this.dados = dados;
        }

        private void adicionaItensListViewParcelado()
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("Descrição").Width = 167;
            listView1.Columns.Add("Numero de parcelas").Width = 120;
            //listView1.Columns.Add("Parcelas pagas").Width = 90;
            //listView1.Columns.Add("Parcelas restantes").Width = 120;
            listView1.Columns.Add("Valor total").Width = 80;
            listView1.Columns.Add("Valor parcela").Width = 90;

            DataRow[] registros = dados.Tables["Registros"].Select("Codigo > 0");
            string descricao2 = "";
            int ultimaPaga = 0;

            foreach (DataRow registro in registros)
            {
                int index;
                string parcelas = registro["Descricao"].ToString();
                index = parcelas.IndexOf("/");

                if (index != -1)
                {
                    parcelas = registro["Descricao"].ToString();
                    index = parcelas.IndexOf("/");
                    string descricao = parcelas.Replace(parcelas.Substring(index + -2), "");
                    string parcela = parcelas.Substring(index + 1);
                    DataRow[] r = dados.Tables["Registros"].Select("Descricao like '" + descricao + "%'");

                    foreach (DataRow re in r)
                    {
                        if (re["DataPagamento"].ToString() == "")
                            break;
                        else
                        {
                            int parcelaAtual;
                            string a = parcelas.Replace(descricao, "");
                            int index2 = a.IndexOf("/");
                            a = a.Replace(parcela, "");
                            a = a.Replace("/", "");
                            a = a.Replace(" ", "");

                            if (a == "")
                                parcelaAtual = int.Parse(parcela);
                            else
                                parcelaAtual = int.Parse(a);

                            if (ultimaPaga < parcelaAtual)
                                ultimaPaga = parcelaAtual;
                        }
                    }

                    descricao = descricao.Replace(" ", "");
                    if (descricao == descricao2)
                        descricao2 = descricao;
                    else
                    {
                        int restantes = int.Parse(parcela) - ultimaPaga;
                        float valorParcela = float.Parse(registro["Valor"].ToString()) * -1;
                        float valorTotal = int.Parse(parcela) * valorParcela;
                        ListViewItem item = new ListViewItem(descricao);
                        ListViewItem.ListViewSubItem subItemNumParcelas = new ListViewItem.ListViewSubItem(item, parcela);
                        //ListViewItem.ListViewSubItem subItemPagas = new ListViewItem.ListViewSubItem(item, ultimaPaga.ToString());
                        //ListViewItem.ListViewSubItem subItemRestantes = new ListViewItem.ListViewSubItem(item, restantes.ToString());
                        ListViewItem.ListViewSubItem subItemValorTotal = new ListViewItem.ListViewSubItem(item, valorTotal.ToString());
                        ListViewItem.ListViewSubItem subItemValorParcela = new ListViewItem.ListViewSubItem(item, valorParcela.ToString());

                        item.SubItems.Add(subItemNumParcelas);
                        //item.SubItems.Add(subItemPagas);
                        //item.SubItems.Add(subItemRestantes);
                        item.SubItems.Add(subItemValorTotal);
                        item.SubItems.Add(subItemValorParcela);
                        listView1.Items.Add(item);
                        ultimaPaga = 0;

                    }
                    descricao2 = descricao;
                }
            }
        }

        private void adicionaItensListViewRecorrente()
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("Descrição");
            listView1.Columns.Add("Valor");

            DataRow[] registros = dados.Tables["Registros"].Select("Codigo > 0");

            foreach (DataRow registro in registros)
                if (registro["Recorrente"].ToString() == "2")
                {
                    ListViewItem item = new ListViewItem(registro["Descricao"].ToString());
                    ListViewItem.ListViewSubItem subItemValor = new ListViewItem.ListViewSubItem(item, registro["Valor"].ToString());
                    item.SubItems.Add(subItemValor);
                    listView1.Items.Add(item);
                }            
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonClicado(object sender, EventArgs e)
        {
            if (radioButtonGastosParc.Checked == true)
            {
                adicionaItensListViewParcelado();
            }

            else if (radioButtonGastosPeri.Checked == true)
            {
                adicionaItensListViewRecorrente();
            }
        }
        
        private void comboBoxMesProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonGastosParc.Checked == true)
            {
                listView1.Columns.Clear();
                listView1.Items.Clear();
                listView1.Columns.Add("Descrição");
                listView1.Columns.Add("Valor");
                listView1.Columns.Add("Data Vencimento");

                DateTime data = DateTime.Now;
                DataRow[] registros = dados.Tables["Registros"].Select("Categoria > 0");
                int numero_mes = verificaMes(comboBoxMesProj.SelectedItem.ToString());
                if (registros.Length != 0)
                {
                    foreach (DataRow registro in registros)
                    {
                        if (registro["DataVencimento"].ToString() != "")
                            data = DateTime.Parse(registro["DataVencimento"].ToString());
                        if (data.Month == numero_mes)
                        {
                            int index;
                            string parcelas = registro["Descricao"].ToString();
                            index = parcelas.IndexOf("/");

                            if (index != -1)
                            {
                                ListViewItem item = new ListViewItem(registro["Descricao"].ToString());
                                ListViewItem.ListViewSubItem subItemValor = new ListViewItem.ListViewSubItem(item, registro["Valor"].ToString());
                                ListViewItem.ListViewSubItem subItemDataPagamento = new ListViewItem.ListViewSubItem(item, registro["DataVencimento"].ToString());

                                item.SubItems.Add(subItemValor);
                                item.SubItems.Add(subItemDataPagamento);
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }

            else if (radioButtonGastosPeri.Checked == true)
            {
                listView1.Columns.Clear();
                listView1.Items.Clear();
                listView1.Columns.Add("Descrição");
                listView1.Columns.Add("Valor");

                DateTime data = DateTime.Now;
                DataRow[] registros = dados.Tables["Registros"].Select("Categoria > 0");
                int numero_mes = verificaMes(comboBoxMesProj.SelectedItem.ToString());
                if (registros.Length != 0)
                {
                    foreach (DataRow registro in registros)
                    {
                        if (registro["DataVencimento"].ToString() != "")
                            data = DateTime.Parse(registro["DataVencimento"].ToString());
                        if (data.Month == numero_mes)
                            if (registro["Recorrente"].ToString() == "2")
                            {
                                ListViewItem item = new ListViewItem(registro["Descricao"].ToString());
                                ListViewItem.ListViewSubItem subItemValor = new ListViewItem.ListViewSubItem(item, registro["Valor"].ToString());
                                item.SubItems.Add(subItemValor);
                                listView1.Items.Add(item);
                            }
                    }
                }
            }            
        }

        private void ProjecaoDeGastos_Load(object sender, EventArgs e)
        {
            adicionaItensListViewParcelado();
        }

        public int verificaMes(string mes)
        {
            int numero_mes = 0;
            switch (mes)
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

        private void comboBoxAnoProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonGastosParc.Checked == true)
            {
                listView1.Columns.Clear();
                listView1.Items.Clear();
                listView1.Columns.Add("Descrição");
                listView1.Columns.Add("Valor");
                listView1.Columns.Add("Data Vencimento");
                listView1.Columns.Add("Data Pagamento");

                DateTime data = DateTime.Now;
                DataRow[] registros = dados.Tables["Registros"].Select("Categoria > 0");
                if (registros.Length != 0)
                {
                    foreach (DataRow registro in registros)
                    {
                        if (registro["DataVencimento"].ToString() != "")
                            data = DateTime.Parse(registro["DataVencimento"].ToString());
                        else
                            data = DateTime.Parse(registro["DataCadastro"].ToString());
                        if (data.Year == int.Parse(comboBoxAnoProj.SelectedItem.ToString()))
                        {
                            int index;
                            string parcelas = registro["Descricao"].ToString();
                            index = parcelas.IndexOf("/");                        
                            string dataPagamento;

                            if (registro["DataPagamento"].ToString() == "")
                                dataPagamento = " ";
                            else
                                dataPagamento = ((DateTime)registro["DataPagamento"]).ToString("dd/MM/yyy");

                            if (index != -1)
                            {
                                ListViewItem item = new ListViewItem(registro["Descricao"].ToString());
                                ListViewItem.ListViewSubItem subItemValor = new ListViewItem.ListViewSubItem(item, registro["Valor"].ToString());
                                ListViewItem.ListViewSubItem subItemDataVencimento = new ListViewItem.ListViewSubItem(item, ((DateTime)registro["DataVencimento"]).ToString("dd/MM/yyy"));
                                ListViewItem.ListViewSubItem subItemDataPagamento = new ListViewItem.ListViewSubItem(item, dataPagamento);

                                item.SubItems.Add(subItemValor);
                                item.SubItems.Add(subItemDataVencimento);
                                item.SubItems.Add(subItemDataPagamento);
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }                       
        }

        private void dateTimePickerSemana_ValueChanged(object sender, EventArgs e)
        {
            if (radioButtonGastosParc.Checked == true)
            {
                listView1.Columns.Clear();
                listView1.Items.Clear();
                listView1.Columns.Add("Descrição");
                listView1.Columns.Add("Valor");
                listView1.Columns.Add("Data Vencimento");
                listView1.Columns.Add("Data Pagamento");

                dateTimePickerSemana.CustomFormat = "dd/MM/yyyy";
                DateTime data = DateTime.Now;
                DateTime data1 = DateTime.Now;
                string data_aux;
                string data2;
                DataRow[] registros = dados.Tables["Registros"].Select("Categoria > 0");
                if (registros.Length != 0)
                {
                    foreach (DataRow registro in registros)
                    {
                        if (registro["DataVencimento"].ToString() != "")
                        {
                            data = dateTimePickerSemana.Value;
                            data1 = data.AddDays(7);
                            data_aux = data.ToString("dd/MM/yyyy");
                            data2 = data1.ToString("dd/MM/yyyy");
                            if (DateTime.Parse(registro["DataVencimento"].ToString()) >= DateTime.Parse(data_aux) && DateTime.Parse(registro["DataVencimento"].ToString()) <= DateTime.Parse(data2))
                            {
                                int index;
                                string parcelas = registro["Descricao"].ToString();
                                index = parcelas.IndexOf("/");
                                string dataPagamento;

                                if (registro["DataPagamento"].ToString() == "")
                                    dataPagamento = " ";
                                else
                                    dataPagamento = ((DateTime)registro["DataPagamento"]).ToString("dd/MM/yyy");

                                if (index != -1)
                                {
                                    ListViewItem item = new ListViewItem(registro["Descricao"].ToString());
                                    ListViewItem.ListViewSubItem subItemValor = new ListViewItem.ListViewSubItem(item, registro["Valor"].ToString());
                                    ListViewItem.ListViewSubItem subItemDataVencimento = new ListViewItem.ListViewSubItem(item, ((DateTime)registro["DataVencimento"]).ToString("dd/MM/yyy"));
                                    ListViewItem.ListViewSubItem subItemDataPagamento = new ListViewItem.ListViewSubItem(item, dataPagamento);

                                    item.SubItems.Add(subItemValor);
                                    item.SubItems.Add(subItemDataVencimento);
                                    item.SubItems.Add(subItemDataPagamento);
                                    listView1.Items.Add(item);
                                }
                            }
                        }
                    }
                }
            }            
        }

        private void radioButtonGastosPeri_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerSemana.Enabled = false;
            comboBoxAnoProj.Enabled = false;
        }

        private void radioButtonGastosParc_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerSemana.Enabled = true;
            comboBoxAnoProj.Enabled = true;
        }
    }
}
