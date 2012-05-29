﻿using System;
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
            listView1.Items.Clear();
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
                listView1.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection conexao = new SqlConnection();
            //conexao.ConnectionString = "Data Source=PC09LAB3\\SQLEXPRESS;Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI";
            //adaptador = new SqlDataAdapter();

            //SqlCommand comandoSelecao = new SqlCommand("select * from Registros", conexao);
            //adaptador.SelectCommand = comandoSelecao;

            //adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            //dados = new DataSet();
            //adaptador.Fill(dados, "Registros");

            //atualizaListView();


            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=PC09LAB3\\SQLEXPRESS;Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI";

            //Comandos para a seleção
            SqlCommand comandoSelecaoReg = new SqlCommand("Select * from Registros", conexao);
            adaptador.SelectCommand = comandoSelecaoReg;

            SqlCommand comandoSelecaoCa = new SqlCommand("Select * from Caixa", conexao);
            adaptador.SelectCommand = comandoSelecaoCa;


            //Comandos para a inserção de dados
            SqlCommand comandoInsercaoReg = new SqlCommand("Insert into Registros (Descricao, Valor, Categoria, Status1, DataVencimento, DataPagamento, DataCadastro, Parcelas) values (@Descricao, @Valor, @Categoria, @Status1, @DataVencimento, @DataPagamento, @DataCadastro, @Parcelas)", conexao);
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

            SqlParameter prmStatus1 = new SqlParameter("@Status1", SqlDbType.Int);
            prmStatus1.SourceColumn = "Status1";
            prmStatus1.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmStatus1);

            SqlParameter prmDataVencimento = new SqlParameter("@DataVencimento", SqlDbType.Date);
            prmDataVencimento.SourceColumn = "DataVencimento";
            prmDataVencimento.SourceVersion = DataRowVersion.Current;
            comandoInsercaoReg.Parameters.Add(prmDataVencimento);

            SqlParameter prmDataPagamento = new SqlParameter("@DataPagamento", SqlDbType.Date);
            prmDataPagamento.SourceColumn = "DataCompra";
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

            adaptador.InsertCommand = comandoInsercaoReg;

            SqlCommand comandoAtualizacao = new SqlCommand("Update Comprados set Nome = @Nome, DataCompra = @DataCompra, Genero = @Genero where Codigo = @Codigo", conexao);
            prmNome = new SqlParameter("@Nome", SqlDbType.VarChar, 50);
            prmNome.SourceColumn = "Nome";
            prmNome.SourceVersion = DataRowVersion.Current;
            comandoAtualizacao.Parameters.Add(prmNome);
            prmDataCompra = new SqlParameter("@DataCompra", SqlDbType.Date);
            prmDataCompra.SourceColumn = "DataCompra";
            prmDataCompra.SourceVersion = DataRowVersion.Current;
            comandoAtualizacao.Parameters.Add(prmDataCompra);
            prmGenero = new SqlParameter("@Genero", SqlDbType.SmallInt);
            prmGenero.SourceColumn = "Genero";
            prmGenero.SourceVersion = DataRowVersion.Current;
            comandoAtualizacao.Parameters.Add(prmGenero);
            SqlParameter prmCodigo = new SqlParameter("@Codigo", SqlDbType.Int);
            prmCodigo.SourceColumn = "Codigo";
            prmCodigo.SourceVersion = DataRowVersion.Original;
            comandoAtualizacao.Parameters.Add(prmCodigo);
            adaptador.UpdateCommand = comandoAtualizacao;

            SqlCommand comandoRemocao = new SqlCommand("Delete from Comprados where Codigo = @Codigo", conexao);
            prmCodigo = new SqlParameter("@Codigo", SqlDbType.Int);
            prmCodigo.SourceColumn = "Codigo";
            prmCodigo.SourceVersion = DataRowVersion.Original;
            comandoRemocao.Parameters.Add(prmCodigo);
            adaptador.DeleteCommand = comandoRemocao;

            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;


            adaptador.Fill(dados, "Comprados");
        }
    }
}
