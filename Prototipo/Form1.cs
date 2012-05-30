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
        DataSet dados;
        SqlDataAdapter adaptador;
        public Form1()
        {
            InitializeComponent();
        }

        public void atualizaListView() //Atualiza list view
        {
            listViewPrincipal.Items.Clear();
            foreach (DataRow registro in dados.Tables["Registros"].Rows)
            {
                ListViewItem item = new ListViewItem(registro["Descricao"].ToString());
                ListViewItem.ListViewSubItem subItemValor = new ListViewItem.ListViewSubItem(item, registro["Valor"].ToString());
                ListViewItem.ListViewSubItem subItemCategoria = new ListViewItem.ListViewSubItem(item, registro["Categoria"].ToString());
                ListViewItem.ListViewSubItem subItemStatus = new ListViewItem.ListViewSubItem(item, registro["Status1"].ToString());
                ListViewItem.ListViewSubItem subItemDataVencimento = new ListViewItem.ListViewSubItem(item, ((DateTime)registro["DataVencimento"]).ToString("dd/MM/yyy"));
                ListViewItem.ListViewSubItem subItemDataPagamento = new ListViewItem.ListViewSubItem(item, ((DateTime)registro["DataPagamento"]).ToString("dd/MM/yyy"));
                item.SubItems.Add(subItemValor);
                item.SubItems.Add(subItemCategoria);
                item.SubItems.Add(subItemDataVencimento);
                item.SubItems.Add(subItemDataPagamento);
                listViewPrincipal.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=PC09LAB3\\SQLEXPRESS;Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI";
            adaptador = new SqlDataAdapter();

            SqlCommand comandoSelecao = new SqlCommand("select * from Registros", conexao);
            adaptador.SelectCommand = comandoSelecao;

            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            dados = new DataSet();
            adaptador.Fill(dados, "Registros");

            atualizaListView();*/
        }
    }
}
