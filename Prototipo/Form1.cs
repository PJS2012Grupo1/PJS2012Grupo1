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
        DataSet dados = new DataSet();
        SqlDataAdapter adaptadorReg = new SqlDataAdapter();
        SqlDataAdapter adaptadorCat = new SqlDataAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        public void atualizaGroupBoxDadosMes()
        {
            groupBoxDadosMes.Text = "Mes: " + labelNomeMes.Text;
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
                item.SubItems.Add(subItemStatus);
                item.SubItems.Add(subItemDataVencimento);
                item.SubItems.Add(subItemDataPagamento);
                listViewPrincipal.Items.Add(item);
            }
            atualizaGroupBoxDadosMes();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=(local);Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI";

            //Comandos para a seleção
            SqlCommand comandoSelecaoReg = new SqlCommand("Select * from Registros", conexao);
            adaptadorReg.SelectCommand = comandoSelecaoReg;

            //SqlCommand comandoSelecaoCat = new SqlCommand("Select * from Categoria", conexao);
            //adaptador.SelectCommand = comandoSelecaoCat;
            SqlCommand comandoSelecaoCat = new SqlCommand("Select * from Categoria", conexao);
            adaptadorCat.SelectCommand = comandoSelecaoCat;


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

            SqlParameter prmStatus1 = new SqlParameter("@Status1", SqlDbType.TinyInt);
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
            SqlCommand comandoAtualizacaoReg = new SqlCommand("Update Registros set Descricao = @Descricao, Valor = @Valor, Categoria = @Categoria, Status1 = @Status1, DataVencimento = @DataVencimento, DataPagamento = @DataPagamento, DataCadastro = @DataCadastro, Parcelas = @Parcelas where Codigo = @Codigo", conexao);
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

            prmStatus1 = new SqlParameter("@Status1", SqlDbType.TinyInt);
            prmStatus1.SourceColumn = "Status1";
            prmStatus1.SourceVersion = DataRowVersion.Current;
            comandoAtualizacaoReg.Parameters.Add(prmStatus1);

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
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros cadastroRegistro = new Registros();
            cadastroRegistro.ShowDialog(this);
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Caixa cadastroCaixa = new Caixa();
            cadastroCaixa.ShowDialog(this);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (checkBoxDescricao.Checked == true)
            {
                DataRow[] registros = dados.Tables["Registros"].Select("Descricao like '" + textBox1.Text + "%'");

                if (registros.Length != 0)
                {
                    foreach (DataRow registro in registros)
                    {
                        if (registro["Descricao"].ToString() == textBox1.Text)
                        {
                            
                            ListViewItem item = new ListViewItem(registro["Descricao"].ToString());
                            ListViewItem.ListViewSubItem subitemValor = new ListViewItem.ListViewSubItem(item, registro["Valor"].ToString());
                            item.SubItems.Add(subitemValor);

                            ListViewItem.ListViewSubItem subitemCategoria = new ListViewItem.ListViewSubItem(item, registro["Categoria"].ToString());
                            item.SubItems.Add(subitemCategoria);

                            ListViewItem.ListViewSubItem subItemStatus = new ListViewItem.ListViewSubItem(item, registro["Status1"].ToString());
                            item.SubItems.Add(subItemStatus);
                            ListViewItem.ListViewSubItem subItemDataVencimento = new ListViewItem.ListViewSubItem(item, registro["DataVencimento"].ToString());
                            item.SubItems.Add(subItemDataVencimento);
                            ListViewItem.ListViewSubItem subItemDataPagamento = new ListViewItem.ListViewSubItem(item, registro["DataPagamento"].ToString());
                            item.SubItems.Add(subItemDataPagamento);
                          
                            listViewPrincipal.Items.Add(item);
                        }
                    }
                }
            }
        }
    }
}
