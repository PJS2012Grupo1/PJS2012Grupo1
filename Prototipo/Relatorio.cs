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
    public partial class Relatorio : Form
    {
        DataSet dados;
        public Relatorio(DataSet dados)
        {
            this.dados = dados;
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                comboBoxRelatorioCategoria.Items.Add(registro["DescricaoCat"].ToString());
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
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
            listViewRelatorio.Items.Add(item);


        }
        private void comboBoxRelatorioCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoria = 0;
            foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                if (comboBoxRelatorioCategoria.Text == registro["DescricaoCat"].ToString())
                    categoria = int.Parse(registro["CodigoCat"].ToString());

            DataRow[] registros = dados.Tables["Registros"].Select("Categoria = '" + categoria + "'");// and DataCadastro >= '" + dateTimePickerDataMinima.Value + "' and DataCadastro <= '" + dateTimePickerDataMaxima.Value + "'");

            if (registros.Length != 0)
            {
                foreach (DataRow registro in registros)
                {
                    adicionaItensListView(registro);
                }
            }
            atualizaGroupBox();
        }

        public void atualizaGroupBox()
        {
            float gasto_medio = 0;
            float media = 0;
            string soma;
            //for (int i = 0; i < listViewRelatorio.Items.Count; i++)
            //{
            //    gasto_medio += float.Parse(listViewRelatorio.Items[i].SubItems[1].);
            //}
            foreach (ListViewItem item in listViewRelatorio.Items)
            {
                soma = item.SubItems[1].Text;
                gasto_medio += float.Parse(soma);
            }
            media = gasto_medio / listViewRelatorio.Items.Count;
            label1.Text = gasto_medio.ToString();
        }
    }
}
