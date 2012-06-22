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
    public partial class FormCadastroCategoria : Form
    {
        DataSet dados;
        SqlDataAdapter adaptadorCat;

        public FormCadastroCategoria(DataSet dados, SqlDataAdapter adaptadorCat)
        {
            this.dados = dados;
            this.adaptadorCat = adaptadorCat;
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            
            if (textBoxDescricao.Text == "")
            {
                labelCampoPreenchidos.Text = "*Campo descrição vazio.";
                textBoxDescricao.Focus();
                labelCampoPreenchidos.Visible = true;
            }                
            else if (textBoxOrcamento.Text == "")
            {
                labelCampoPreenchidos.Text = "*Campo orçamento vazio.";
                textBoxOrcamento.Focus();
                labelCampoPreenchidos.Visible = true;
            }
            else
            {               
                labelCampoPreenchidos.Visible = false;
                DataRow novoRegistro = dados.Tables["Categoria"].NewRow();
                novoRegistro["DescricaoCat"] = textBoxDescricao.Text;
                novoRegistro["Orcamento"] = textBoxOrcamento.Text;
                dados.Tables["Categoria"].Rows.Add(novoRegistro);

                adaptadorCat.Update(dados, "Registros");

                Close();
            }
        }
    }
}
