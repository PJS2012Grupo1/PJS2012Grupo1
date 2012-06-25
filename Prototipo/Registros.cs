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
    public partial class Registros : Form
    {
        DataSet dados;
        DataRow registro;
        bool atualiza = false;
        AdaptadorRegistros adaptadorReg;
        AdaptadorCategoria adaptadorCat;
        //SqlDataAdapter adaptadorReg;// = new SqlDataAdapter();
        //SqlDataAdapter adaptadorCat;

        public Registros(DataSet dados, AdaptadorRegistros adaptadorReg, AdaptadorCategoria adaptadorCat)
        {
            this.dados = dados;
            this.adaptadorReg = adaptadorReg;
            this.adaptadorCat = adaptadorCat;
            InitializeComponent();
        }

        public Registros(DataRow registro, bool atualiza, DataSet dados, AdaptadorRegistros adaptadorReg, AdaptadorCategoria adaptadorCat)
        {
            this.atualiza = atualiza;
            this.registro = registro;
            this.dados = dados;
            this.adaptadorCat = adaptadorCat;
            this.adaptadorReg = adaptadorReg;
            InitializeComponent();
        }
        
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxDescricaoRegistro.Text = "";
            textBoxValorRegistro.Text = "";
            comboBoxCategoriaRegistro.Text = "";
            comboBoxQtdeParcelasReg.Text = "";
            comboBoxFormaPagamento.Text = "";
            dateTimePickerDataPagamentoReg.Text = dateTimePickerDataVencimentoReg.Text = DateTime.Now.ToShortDateString();
        }

        private void buttonCancelarRegistro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegistrarRegistro_Click(object sender, EventArgs e)
        {
            //parameter.Value = DBNull.Value;
            
            if (textBoxDescricaoRegistro.Text.Trim() == "")
            {
                labelCampoPreenchidos.Text = "*Campo descrição vazio.";
                labelCampoPreenchidos.Visible = true;
                textBoxDescricaoRegistro.Focus();
            }
            else if (comboBoxCategoriaRegistro.SelectedIndex == -1)
            {
                labelCampoPreenchidos.Text = "*Campo categoria vazio.";
                labelCampoPreenchidos.Visible = true;
                comboBoxCategoriaRegistro.Focus();
            }
            else if (textBoxValorRegistro.Text.Trim() == "")
            {
                labelCampoPreenchidos.Text = "*Campo valor vazio.";
                labelCampoPreenchidos.Visible = true;
                textBoxValorRegistro.Focus();
            }
            else if (comboBoxFormaPagamento.SelectedIndex == -1)
            {
                labelCampoPreenchidos.Text = "Forma de pagamento não selecionada.";
                labelCampoPreenchidos.Visible = true;
                comboBoxFormaPagamento.Focus();
            }
            else
            {
                labelCampoPreenchidos.Visible = false;

                int recorrente = 1;
                int parcelas;
                int categoria = 0;                

                foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                    if (comboBoxCategoriaRegistro.Text == registro["DescricaoCat"].ToString())
                        categoria = int.Parse(registro["CodigoCat"].ToString());

                if (comboBoxFormaPagamento.SelectedIndex == 1)
                    parcelas = int.Parse(comboBoxQtdeParcelasReg.Text);
                else
                {
                    parcelas = 1;
                    if (comboBoxFormaPagamento.SelectedIndex == 2)
                        recorrente = 2;
                }

                if (atualiza)
                {
                    registro["Descricao"] = textBoxDescricaoRegistro.Text;
                    registro["Valor"] = "-" + textBoxValorRegistro.Text;
                    registro["Categoria"] = categoria;
                    registro["Recorrente"] = recorrente;
                    registro["DataVencimento"] = dateTimePickerDataVencimentoReg.Value;
                    registro["DataPagamento"] = dateTimePickerDataPagamentoReg.Value;
                    adaptadorReg.adaptador.Update(dados, "Registros");
                }
                else if (parcelas > 1)
                {
                    float valor = (float.Parse(textBoxValorRegistro.Text) / parcelas);
                    string data = dateTimePickerDataVencimentoReg.Value.ToString("dd/MM/yyyy");
                    string[] datas = data.Split('/');
                    int mes = int.Parse(datas[1]);
                    int ano = int.Parse(datas[2]);
                    
                    for (int i = 1; i <= parcelas; i++)
                    {
                        if (mes > 12)
                        {
                            mes = 1;
                            ano += 1;
                        }
                        DataRow novoRegistro = dados.Tables["Registros"].NewRow();
                        novoRegistro["Descricao"] = textBoxDescricaoRegistro.Text + " " + i + "/" + parcelas;
                        novoRegistro["Valor"] = "-" + valor;
                        novoRegistro["Categoria"] = categoria;
                        novoRegistro["Recorrente"] = recorrente;
                        novoRegistro["DataVencimento"] = datas[0] + "/" + mes + "/" + ano;
                        if (i == 1)
                            novoRegistro["DataPagamento"] = dateTimePickerDataPagamentoReg.Value;
                        novoRegistro["DataCadastro"] = DateTime.Now.ToShortDateString();
                        dados.Tables["Registros"].Rows.Add(novoRegistro);
                        adaptadorReg.adaptador.Update(dados, "Registros");
                        mes = mes + 1;
                    }
                }
                else
                {
                    DataRow novoRegistro = dados.Tables["Registros"].NewRow();
                    novoRegistro["Descricao"] = textBoxDescricaoRegistro.Text;
                    novoRegistro["Valor"] = "-" + textBoxValorRegistro.Text;
                    novoRegistro["Categoria"] = categoria;
                    novoRegistro["Recorrente"] = recorrente;
                    novoRegistro["DataVencimento"] = dateTimePickerDataVencimentoReg.Value;
                    novoRegistro["DataPagamento"] = dateTimePickerDataPagamentoReg.Value;
                    novoRegistro["DataCadastro"] = DateTime.Now.ToShortDateString();
                    dados.Tables["Registros"].Rows.Add(novoRegistro);
                    adaptadorReg.adaptador.Update(dados, "Registros");
                }
                Close();
            }
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            AdaptadorRegistros registros = new AdaptadorRegistros("Data Source=(local);Initial Catalog=SistemaFinanceiro;Integrated Security=SSPI");
            registros.adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            registros.adaptador.Fill(dados, "Registros");

            foreach (DataRow registro in dados.Tables["Categoria"].Rows)
                comboBoxCategoriaRegistro.Items.Add(registro["DescricaoCat"].ToString());

            if (atualiza)
            {
                string categoria = " ";
                float valor = -1 * float.Parse(registro["Valor"].ToString());
                int formaPagamento = -1;
                DateTime data;

                foreach (DataRow registroCat in dados.Tables["Categoria"].Rows)
                    if (registro["Categoria"].ToString() == registroCat["CodigoCat"].ToString())
                        categoria = registroCat["DescricaoCat"].ToString();

                if (int.Parse(registro["Recorrente"].ToString()) == 2)
                    formaPagamento = 2;

                int index;
                string descricao = registro["Descricao"].ToString();
                index = descricao.IndexOf("/");

                if (index != -1)
                {
                    formaPagamento = 1;
                    comboBoxQtdeParcelasReg.Text = descricao.Substring(index + 1);
                    comboBoxFormaPagamento.Enabled = false;
                    comboBoxQtdeParcelasReg.Enabled = false;
                    textBoxValorRegistro.Enabled = false;
                }
                else
                {
                    comboBoxQtdeParcelasReg.Enabled = true;
                    formaPagamento = 0;
                }

                if (registro["DataPagamento"].ToString() == "")
                    data = DateTime.Parse(DateTime.Now.ToShortDateString());
                else
                    data = DateTime.Parse(registro["DataPagamento"].ToString());
                descricao = descricao.Replace(descricao.Substring(index + -2), " ");

                textBoxDescricaoRegistro.Text = descricao;
                comboBoxCategoriaRegistro.Text = categoria;
                comboBoxFormaPagamento.SelectedIndex = formaPagamento;
                textBoxValorRegistro.Text = valor.ToString();
                dateTimePickerDataPagamentoReg.Value = data;
                dateTimePickerDataVencimentoReg.Value = DateTime.Parse(registro["DataVencimento"].ToString());
            }
        }

        private void comboBoxFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFormaPagamento.SelectedIndex == 1 && !atualiza)
                comboBoxQtdeParcelasReg.Enabled = true;
            else
                comboBoxQtdeParcelasReg.Enabled = false;
        }
    }
}
