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
        Form1 f1;
        public Relatorio(DataSet dados, Form1 form)
        {
            f1 = form;
            this.dados = dados;
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            label1.Text = "0.00R$";
            label2.Text = "0.00R$";
            label3.Text = "0.00R$";
            label8.Text = "0.00R$";
            label9.Text = "0.00R$";
            dateTimePickerSemana.Enabled = false;
            foreach (DataRow registro in dados.Tables["Categoria"].Rows)
            {
                comboBoxRelatorioCategoria.Items.Add(registro["DescricaoCat"].ToString());
 
            }
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

        //Verifica quais são os registros de determinada categoria
        private void comboBoxRelatorioCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewRelatorio.Items.Clear();
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

        //Verifica quais são os registros de determinado ano
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewRelatorio.Items.Clear();
            DateTime data = DateTime.Now;
            DataRow[] registros = dados.Tables["Registros"].Select("Categoria > 0");// and DataCadastro >= '" + dateTimePickerDataMinima.Value + "' and DataCadastro <= '" + dateTimePickerDataMaxima.Value + "'");      
            if (registros.Length != 0)
            {
                foreach (DataRow registro in registros)
                {
                    if(registro["DataVencimento"].ToString() != "")
                        data = DateTime.Parse(registro["DataVencimento"].ToString());
                    if (data.Year == int.Parse(comboBox1.SelectedItem.ToString()))
                        adicionaItensListView(registro);
                }
            }
            comboBoxDescCat.Visible = true;
            atualizaCombo();
            atualizaGroupBox();
        }

        //Retorna o número do mês
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
        //Verifica quais são os registros de determinado mês
        private void comboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewRelatorio.Items.Clear();
            DateTime data = DateTime.Now;
            DataRow[] registros = dados.Tables["Registros"].Select("Categoria > 0");// and DataCadastro >= '" + dateTimePickerDataMinima.Value + "' and DataCadastro <= '" + dateTimePickerDataMaxima.Value + "'");
            int numero_mes = verificaMes(comboBoxMes.SelectedItem.ToString());
            if (registros.Length != 0)
            {
                foreach (DataRow registro in registros)
                {
                    if (registro["DataVencimento"].ToString() != "")
                        data = DateTime.Parse(registro["DataVencimento"].ToString());
                    if (data.Month == numero_mes)
                        adicionaItensListView(registro);
                }
            }
            comboBoxDescCat.Visible = true;

            atualizaCombo();
            atualizaGroupBox();
        }

        public void atualizaCombo()
        {
            comboBoxDescCat.Items.Clear();
            if (listViewRelatorio.Items.Count != 0)
            {
                for (int i = 0; i < listViewRelatorio.Items.Count; i++)
                {
                    if (i == 0)
                        comboBoxDescCat.Items.Add(listViewRelatorio.Items[i].SubItems[2].Text);
                    else
                    {
                        if (listViewRelatorio.Items[i].SubItems[2].ToString() != listViewRelatorio.Items[i - 1].SubItems[2].ToString())
                            comboBoxDescCat.Items.Add(listViewRelatorio.Items[i].SubItems[2].Text);
                    }
                }
            }
        }
        //Atualiza as informações no GroupBox
        public void atualizaGroupBox()
        {
            float gasto_total = 0;
            float media = 0;
            string soma;
            DataRow[] categoria = dados.Tables["Categoria"].Select("CodigoCat > 0");
            float maior = 0;
            float menor = 0;
            int contador = 0;
            //Soma o total no ListView
            foreach (ListViewItem item in listViewRelatorio.Items)
            {
                if (item.SubItems[1].ForeColor != Color.Blue)
                {
                    contador++;
                    soma = item.SubItems[1].Text;
                    gasto_total += float.Parse(soma);
                }
            }
            
            //Verifica o maior e o menor valor
            for (int i = 0; i < listViewRelatorio.Items.Count; i++)
            {
                if (listViewRelatorio.Items[i].SubItems[1].ForeColor != Color.Blue)
                {
                    if (i == 0)
                    {
                        maior = float.Parse(listViewRelatorio.Items[i].SubItems[1].Text);
                        menor = float.Parse(listViewRelatorio.Items[i].SubItems[1].Text);
                    }
                    else
                    {
                        if (menor < float.Parse(listViewRelatorio.Items[i].SubItems[1].Text))
                            menor = float.Parse(listViewRelatorio.Items[i].SubItems[1].Text);
                        else
                            if (maior > float.Parse(listViewRelatorio.Items[i].SubItems[1].Text))
                                maior = float.Parse(listViewRelatorio.Items[i].SubItems[1].Text);
                    }
                }
                
            }
            //Verifica o débito ou crédito no orçamento da categoria
            foreach (DataRow cat in dados.Tables["Categoria"].Rows)
            {
                float dif = 0;
                gasto_total *= -1;

                if (comboBoxDescCat.Visible == false)
                {
                    for (int i = 0; i < listViewRelatorio.Items.Count; i++)
                    {
                        if (listViewRelatorio.Items[i].SubItems[2].Text == cat["DescricaoCat"].ToString() && listViewRelatorio.Items[i].SubItems[1].ForeColor != Color.Blue)
                        {
                            if (gasto_total > float.Parse(cat["Orcamento"].ToString()))
                            {
                                dif = float.Parse(cat["Orcamento"].ToString()) - gasto_total;
                                label9.Text = "Débito de:" + dif + "R$";
                                break;
                            }
                            else
                            {
                                dif = float.Parse(cat["Orcamento"].ToString()) - gasto_total;
                                label9.Text = "Crédito de:" + dif + "R$";
                                break;
                            }
                        }
                    }  
                }
                
            }
            if (gasto_total != 0)
                media = gasto_total / contador;
            if (checkBoxAno.Checked == true || checkBoxMes.Checked == true || checkBoxSemana.Checked == true)
                verificaSituacao(gasto_total);
            label1.Text = media.ToString("0.00") + "R$";
            label2.Text = menor.ToString("0.00") + "R$";
            label8.Text = maior.ToString("0.00") + "R$";
            
        }

        private void comboBoxDescCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            float gasto_parcial = 0;
            float gasto_total = 0; 
            string soma_parcial;
            string soma_total;
            
            float dif = 0;
          
            if (comboBoxDescCat.SelectedIndex != -1)
            {
                for (int i = 0; i < listViewRelatorio.Items.Count; i++)
                {
                    if (listViewRelatorio.Items[i].SubItems[2].Text == comboBoxDescCat.SelectedItem.ToString() && listViewRelatorio.Items[i].SubItems[1].ForeColor != Color.Blue)
                    {
                        soma_parcial = listViewRelatorio.Items[i].SubItems[1].Text;
                        gasto_parcial += float.Parse(soma_parcial);
                    }
                    soma_total = listViewRelatorio.Items[i].SubItems[1].Text;
                    gasto_total += float.Parse(soma_total);
                }
            }
            gasto_parcial *= -1;
            foreach (DataRow cat in dados.Tables["Categoria"].Rows)
            {
                
                if (comboBoxDescCat.SelectedItem.ToString() == cat["DescricaoCat"].ToString())
                {
                    if (gasto_parcial> float.Parse(cat["Orcamento"].ToString()))
                    {
                        dif = float.Parse(cat["Orcamento"].ToString()) - gasto_parcial;
                        label3.Text = "Débito de:" + dif +  "R$";
                        break;
                    }
                    else
                    {
                        dif = float.Parse(cat["Orcamento"].ToString()) - gasto_parcial;
                        label3.Text = "Crédito de:" + dif + "R$";
                        break;
                    }
                }
                
            }     
        }
        //Débito ou crédito com mais de uma categoria
        public void verificaSituacao(float gasto_total)
        {
            float gasto_cat = 0;
            string soma_cat;
            foreach (DataRow cat in dados.Tables["Categoria"].Rows)
            {    
               for (int i = 0; i < listViewRelatorio.Items.Count; i++)
               {
                   if (listViewRelatorio.Items[i].SubItems[2].Text == cat["DescricaoCat"].ToString())
                   {
                       soma_cat = cat["Orcamento"].ToString();
                       gasto_cat += float.Parse(soma_cat);
                       break;
                   }
                }
                if (gasto_cat > gasto_total)
                    label9.Text = "Crédito de:" + (gasto_cat - gasto_total);
                else
                    label9.Text = "Débito de:" + (gasto_cat - gasto_total);
            }
               
        }
        private void checkBoxSemana_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSemana.Checked == true)
            {
                dateTimePickerSemana.Enabled = true;
                dateTimePickerSemana.Enabled = true;
            }
            else
                dateTimePickerSemana.Enabled = false;
        }

        private void checkBoxMes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMes.Checked == true)
            {
                comboBoxMes.Enabled = true;
                comboBoxMes.Enabled = true;
            }
            else
                comboBoxMes.Enabled = false;
        }

        private void checkBoxAno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAno.Checked == true)
            {
                comboBox1.Enabled = true;
                comboBox1.Enabled = true;
            }
            else
                comboBox1.Enabled = false;
        }

        private void checkBoxCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCategoria.Checked == true)
            {
                comboBoxDescCat.Visible = false;
                comboBoxRelatorioCategoria.Enabled = true;
                comboBoxRelatorioCategoria.Enabled = true;
            }
            else
                comboBoxRelatorioCategoria.Enabled = false;
        }
        //Filtra pela data
        private void dateTimePickerSemana_ValueChanged(object sender, EventArgs e)
        {
            listViewRelatorio.Items.Clear();
            dateTimePickerSemana.CustomFormat = "dd/MM/yyyy";
            DateTime data = DateTime.Now;
            DateTime data1 = DateTime.Now;
            string data_aux;
            string data2;
            DataRow[] registros = dados.Tables["Registros"].Select("Categoria > 0");
            //int numero_mes = verificaMes(comboBoxMes.SelectedItem.ToString());
            //if (registro["DataVencimento"].ToString() != "")
            
            
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
                            adicionaItensListView(registro);
                    }
                }
            }
            comboBoxDescCat.Visible = true;

            //atualizaCombo();
            atualizaGroupBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listViewRelatorio.Items.Clear();
            checkBoxMes.Checked = false;
            checkBoxAno.Checked = false;
            checkBoxSemana.Checked = false;
            checkBoxCategoria.Checked = false;
            comboBox1.SelectedIndex = -1;
            comboBoxMes.SelectedIndex = -1;
            comboBoxRelatorioCategoria.SelectedIndex = -1;
            comboBoxDescCat.Visible = false;
            label1.Text = "0.00 R$";
            label2.Text = "0.00 R$";
            label3.Text = "0.00 R$";
            label8.Text = "0.00 R$";
            label9.Text = "0.00 R$";
        }

           
    }
}
