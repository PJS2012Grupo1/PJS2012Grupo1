namespace WindowsFormsApplication1
{
    partial class Relatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxRelatorioCategoria = new System.Windows.Forms.ComboBox();
            this.buttonCancelarRelat = new System.Windows.Forms.Button();
            this.listViewRelatorio = new System.Windows.Forms.ListView();
            this.columnHeaderDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataCadastro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCreDebGeral = new System.Windows.Forms.Label();
            this.labelValorCreDeb2 = new System.Windows.Forms.Label();
            this.comboBoxDescCat = new System.Windows.Forms.ComboBox();
            this.labelValorMaiorGasto = new System.Windows.Forms.Label();
            this.labelCreDebCat = new System.Windows.Forms.Label();
            this.labelMenorGasto = new System.Windows.Forms.Label();
            this.labelMaiorGasto = new System.Windows.Forms.Label();
            this.labelMedia = new System.Windows.Forms.Label();
            this.labelValorCreDeb1 = new System.Windows.Forms.Label();
            this.labelValorMenorGasto = new System.Windows.Forms.Label();
            this.labelValorMedia = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.checkBoxSemana = new System.Windows.Forms.CheckBox();
            this.checkBoxMes = new System.Windows.Forms.CheckBox();
            this.checkBoxAno = new System.Windows.Forms.CheckBox();
            this.checkBoxCategoria = new System.Windows.Forms.CheckBox();
            this.dateTimePickerSemana = new System.Windows.Forms.DateTimePicker();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxRelatorioCategoria
            // 
            this.comboBoxRelatorioCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRelatorioCategoria.Enabled = false;
            this.comboBoxRelatorioCategoria.FormattingEnabled = true;
            this.comboBoxRelatorioCategoria.Location = new System.Drawing.Point(566, 42);
            this.comboBoxRelatorioCategoria.Name = "comboBoxRelatorioCategoria";
            this.comboBoxRelatorioCategoria.Size = new System.Drawing.Size(163, 21);
            this.comboBoxRelatorioCategoria.TabIndex = 1;
            this.comboBoxRelatorioCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxRelatorioCategoria_SelectedIndexChanged);
            // 
            // buttonCancelarRelat
            // 
            this.buttonCancelarRelat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelarRelat.Location = new System.Drawing.Point(654, 652);
            this.buttonCancelarRelat.Name = "buttonCancelarRelat";
            this.buttonCancelarRelat.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarRelat.TabIndex = 3;
            this.buttonCancelarRelat.Text = "Cancelar";
            this.buttonCancelarRelat.UseVisualStyleBackColor = true;
            this.buttonCancelarRelat.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // listViewRelatorio
            // 
            this.listViewRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewRelatorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDescricao,
            this.columnHeaderValor,
            this.columnHeaderCategoria,
            this.columnHeaderDataCadastro,
            this.columnHeaderDataVencimento,
            this.columnHeaderDataPagamento});
            this.listViewRelatorio.Location = new System.Drawing.Point(29, 91);
            this.listViewRelatorio.Name = "listViewRelatorio";
            this.listViewRelatorio.Size = new System.Drawing.Size(700, 370);
            this.listViewRelatorio.TabIndex = 4;
            this.listViewRelatorio.UseCompatibleStateImageBehavior = false;
            this.listViewRelatorio.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDescricao
            // 
            this.columnHeaderDescricao.Text = "Descrição";
            this.columnHeaderDescricao.Width = 200;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor";
            this.columnHeaderValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderValor.Width = 90;
            // 
            // columnHeaderCategoria
            // 
            this.columnHeaderCategoria.Text = "Categoria";
            this.columnHeaderCategoria.Width = 106;
            // 
            // columnHeaderDataCadastro
            // 
            this.columnHeaderDataCadastro.Text = "Data Cadastro";
            this.columnHeaderDataCadastro.Width = 100;
            // 
            // columnHeaderDataVencimento
            // 
            this.columnHeaderDataVencimento.Text = "Data Vencimento";
            this.columnHeaderDataVencimento.Width = 100;
            // 
            // columnHeaderDataPagamento
            // 
            this.columnHeaderDataPagamento.Text = "Data Pagamento";
            this.columnHeaderDataPagamento.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelCreDebGeral);
            this.groupBox1.Controls.Add(this.labelValorCreDeb2);
            this.groupBox1.Controls.Add(this.comboBoxDescCat);
            this.groupBox1.Controls.Add(this.labelValorMaiorGasto);
            this.groupBox1.Controls.Add(this.labelCreDebCat);
            this.groupBox1.Controls.Add(this.labelMenorGasto);
            this.groupBox1.Controls.Add(this.labelMaiorGasto);
            this.groupBox1.Controls.Add(this.labelMedia);
            this.groupBox1.Controls.Add(this.labelValorCreDeb1);
            this.groupBox1.Controls.Add(this.labelValorMenorGasto);
            this.groupBox1.Controls.Add(this.labelValorMedia);
            this.groupBox1.Location = new System.Drawing.Point(31, 478);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatório";
            // 
            // labelCreDebGeral
            // 
            this.labelCreDebGeral.AutoSize = true;
            this.labelCreDebGeral.Location = new System.Drawing.Point(80, 97);
            this.labelCreDebGeral.Name = "labelCreDebGeral";
            this.labelCreDebGeral.Size = new System.Drawing.Size(117, 13);
            this.labelCreDebGeral.TabIndex = 10;
            this.labelCreDebGeral.Text = "Crédito ou Débito Geral";
            // 
            // labelValorCreDeb2
            // 
            this.labelValorCreDeb2.Location = new System.Drawing.Point(203, 97);
            this.labelValorCreDeb2.Name = "labelValorCreDeb2";
            this.labelValorCreDeb2.Size = new System.Drawing.Size(70, 13);
            this.labelValorCreDeb2.TabIndex = 9;
            this.labelValorCreDeb2.Text = "label9";
            // 
            // comboBoxDescCat
            // 
            this.comboBoxDescCat.FormattingEnabled = true;
            this.comboBoxDescCat.Location = new System.Drawing.Point(379, 40);
            this.comboBoxDescCat.Name = "comboBoxDescCat";
            this.comboBoxDescCat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDescCat.TabIndex = 8;
            this.comboBoxDescCat.Visible = false;
            this.comboBoxDescCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxDescCat_SelectedIndexChanged);
            // 
            // labelValorMaiorGasto
            // 
            this.labelValorMaiorGasto.Location = new System.Drawing.Point(150, 64);
            this.labelValorMaiorGasto.Name = "labelValorMaiorGasto";
            this.labelValorMaiorGasto.Size = new System.Drawing.Size(70, 13);
            this.labelValorMaiorGasto.TabIndex = 7;
            this.labelValorMaiorGasto.Text = "label8";
            // 
            // labelCreDebCat
            // 
            this.labelCreDebCat.AutoSize = true;
            this.labelCreDebCat.Location = new System.Drawing.Point(376, 64);
            this.labelCreDebCat.Name = "labelCreDebCat";
            this.labelCreDebCat.Size = new System.Drawing.Size(166, 13);
            this.labelCreDebCat.TabIndex = 6;
            this.labelCreDebCat.Text = "Crédito ou Débito desta Categoria";
            // 
            // labelMenorGasto
            // 
            this.labelMenorGasto.AutoSize = true;
            this.labelMenorGasto.Location = new System.Drawing.Point(226, 64);
            this.labelMenorGasto.Name = "labelMenorGasto";
            this.labelMenorGasto.Size = new System.Drawing.Size(68, 13);
            this.labelMenorGasto.TabIndex = 5;
            this.labelMenorGasto.Text = "Menor Gasto";
            // 
            // labelMaiorGasto
            // 
            this.labelMaiorGasto.AutoSize = true;
            this.labelMaiorGasto.Location = new System.Drawing.Point(80, 64);
            this.labelMaiorGasto.Name = "labelMaiorGasto";
            this.labelMaiorGasto.Size = new System.Drawing.Size(64, 13);
            this.labelMaiorGasto.TabIndex = 4;
            this.labelMaiorGasto.Text = "Maior Gasto";
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Location = new System.Drawing.Point(279, 97);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(82, 13);
            this.labelMedia.TabIndex = 3;
            this.labelMedia.Text = "Média de Gasto";
            // 
            // labelValorCreDeb1
            // 
            this.labelValorCreDeb1.Location = new System.Drawing.Point(548, 64);
            this.labelValorCreDeb1.Name = "labelValorCreDeb1";
            this.labelValorCreDeb1.Size = new System.Drawing.Size(70, 13);
            this.labelValorCreDeb1.TabIndex = 2;
            this.labelValorCreDeb1.Text = "label3";
            // 
            // labelValorMenorGasto
            // 
            this.labelValorMenorGasto.Location = new System.Drawing.Point(300, 64);
            this.labelValorMenorGasto.Name = "labelValorMenorGasto";
            this.labelValorMenorGasto.Size = new System.Drawing.Size(70, 13);
            this.labelValorMenorGasto.TabIndex = 1;
            this.labelValorMenorGasto.Text = "label2";
            // 
            // labelValorMedia
            // 
            this.labelValorMedia.Location = new System.Drawing.Point(367, 97);
            this.labelValorMedia.Name = "labelValorMedia";
            this.labelValorMedia.Size = new System.Drawing.Size(70, 13);
            this.labelValorMedia.TabIndex = 0;
            this.labelValorMedia.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.comboBox1.Location = new System.Drawing.Point(394, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMes.Enabled = false;
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBoxMes.Location = new System.Drawing.Point(223, 42);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMes.TabIndex = 7;
            this.comboBoxMes.SelectedIndexChanged += new System.EventHandler(this.comboBoxMes_SelectedIndexChanged);
            // 
            // checkBoxSemana
            // 
            this.checkBoxSemana.AutoSize = true;
            this.checkBoxSemana.Location = new System.Drawing.Point(29, 25);
            this.checkBoxSemana.Name = "checkBoxSemana";
            this.checkBoxSemana.Size = new System.Drawing.Size(65, 17);
            this.checkBoxSemana.TabIndex = 9;
            this.checkBoxSemana.Text = "Semana";
            this.checkBoxSemana.UseVisualStyleBackColor = true;
            this.checkBoxSemana.CheckedChanged += new System.EventHandler(this.checkBoxSemana_CheckedChanged);
            // 
            // checkBoxMes
            // 
            this.checkBoxMes.AutoSize = true;
            this.checkBoxMes.Location = new System.Drawing.Point(223, 25);
            this.checkBoxMes.Name = "checkBoxMes";
            this.checkBoxMes.Size = new System.Drawing.Size(46, 17);
            this.checkBoxMes.TabIndex = 10;
            this.checkBoxMes.Text = "Mês";
            this.checkBoxMes.UseVisualStyleBackColor = true;
            this.checkBoxMes.CheckedChanged += new System.EventHandler(this.checkBoxMes_CheckedChanged);
            // 
            // checkBoxAno
            // 
            this.checkBoxAno.AutoSize = true;
            this.checkBoxAno.Location = new System.Drawing.Point(394, 25);
            this.checkBoxAno.Name = "checkBoxAno";
            this.checkBoxAno.Size = new System.Drawing.Size(45, 17);
            this.checkBoxAno.TabIndex = 11;
            this.checkBoxAno.Text = "Ano";
            this.checkBoxAno.UseVisualStyleBackColor = true;
            this.checkBoxAno.CheckedChanged += new System.EventHandler(this.checkBoxAno_CheckedChanged);
            // 
            // checkBoxCategoria
            // 
            this.checkBoxCategoria.AutoSize = true;
            this.checkBoxCategoria.Location = new System.Drawing.Point(566, 25);
            this.checkBoxCategoria.Name = "checkBoxCategoria";
            this.checkBoxCategoria.Size = new System.Drawing.Size(71, 17);
            this.checkBoxCategoria.TabIndex = 12;
            this.checkBoxCategoria.Text = "Categoria";
            this.checkBoxCategoria.UseVisualStyleBackColor = true;
            this.checkBoxCategoria.CheckedChanged += new System.EventHandler(this.checkBoxCategoria_CheckedChanged);
            // 
            // dateTimePickerSemana
            // 
            this.dateTimePickerSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSemana.Location = new System.Drawing.Point(29, 48);
            this.dateTimePickerSemana.Name = "dateTimePickerSemana";
            this.dateTimePickerSemana.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerSemana.TabIndex = 13;
            this.dateTimePickerSemana.Value = new System.DateTime(2012, 5, 22, 19, 32, 0, 0);
            this.dateTimePickerSemana.ValueChanged += new System.EventHandler(this.dateTimePickerSemana_ValueChanged);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(570, 654);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 14;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 691);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.dateTimePickerSemana);
            this.Controls.Add(this.checkBoxCategoria);
            this.Controls.Add(this.checkBoxAno);
            this.Controls.Add(this.checkBoxMes);
            this.Controls.Add(this.checkBoxSemana);
            this.Controls.Add(this.comboBoxMes);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewRelatorio);
            this.Controls.Add(this.buttonCancelarRelat);
            this.Controls.Add(this.comboBoxRelatorioCategoria);
            this.MinimumSize = new System.Drawing.Size(771, 726);
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRelatorioCategoria;
        private System.Windows.Forms.Button buttonCancelarRelat;
        private System.Windows.Forms.ListView listViewRelatorio;
        private System.Windows.Forms.ColumnHeader columnHeaderDescricao;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.ColumnHeader columnHeaderCategoria;
        private System.Windows.Forms.ColumnHeader columnHeaderDataCadastro;
        private System.Windows.Forms.ColumnHeader columnHeaderDataVencimento;
        private System.Windows.Forms.ColumnHeader columnHeaderDataPagamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelValorMedia;
        private System.Windows.Forms.Label labelValorMenorGasto;
        private System.Windows.Forms.Label labelValorCreDeb1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.Label labelCreDebCat;
        private System.Windows.Forms.Label labelMenorGasto;
        private System.Windows.Forms.Label labelMaiorGasto;
        private System.Windows.Forms.Label labelMedia;
        private System.Windows.Forms.Label labelValorMaiorGasto;
        private System.Windows.Forms.ComboBox comboBoxDescCat;
        private System.Windows.Forms.CheckBox checkBoxSemana;
        private System.Windows.Forms.CheckBox checkBoxMes;
        private System.Windows.Forms.CheckBox checkBoxAno;
        private System.Windows.Forms.CheckBox checkBoxCategoria;
        private System.Windows.Forms.DateTimePicker dateTimePickerSemana;
        private System.Windows.Forms.Label labelValorCreDeb2;
        private System.Windows.Forms.Label labelCreDebGeral;
        private System.Windows.Forms.Button buttonLimpar;
    }
}