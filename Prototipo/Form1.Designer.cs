namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.listViewPrincipal = new System.Windows.Forms.ListView();
            this.columnHeaderDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategoria1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadatroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBusca = new System.Windows.Forms.TabPage();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.labelDataMinima = new System.Windows.Forms.Label();
            this.dateTimePickerDataMinima = new System.Windows.Forms.DateTimePicker();
            this.labelDataMaxima = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDescricao = new System.Windows.Forms.GroupBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxCategoria = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.checkBoxDescricao = new System.Windows.Forms.CheckBox();
            this.Categorias = new System.Windows.Forms.TabPage();
            this.listViewCategorias = new System.Windows.Forms.ListView();
            this.columnHeaderCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrcamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelTopo = new System.Windows.Forms.Panel();
            this.comboBoxAno = new System.Windows.Forms.ComboBox();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.buttonIrData = new System.Windows.Forms.Button();
            this.buttonProximo = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.labelNomeMes = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBoxDadosMes = new System.Windows.Forms.GroupBox();
            this.labelSaldoValor = new System.Windows.Forms.Label();
            this.labelTotalContasValor = new System.Windows.Forms.Label();
            this.labelTotalCaixaValor = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelTotalContas = new System.Windows.Forms.Label();
            this.labelTotalCaixa = new System.Windows.Forms.Label();
            this.menuStripPrincipal.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBusca.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.groupBoxDescricao.SuspendLayout();
            this.Categorias.SuspendLayout();
            this.panelTopo.SuspendLayout();
            this.groupBoxDadosMes.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPrincipal
            // 
            this.listViewPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPrincipal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDescricao,
            this.columnHeaderValor,
            this.columnHeaderCategoria1,
            this.columnHeaderStatus,
            this.columnHeaderDataVencimento,
            this.columnHeaderDataPagamento});
            this.listViewPrincipal.FullRowSelect = true;
            this.listViewPrincipal.Location = new System.Drawing.Point(12, 108);
            this.listViewPrincipal.Name = "listViewPrincipal";
            this.listViewPrincipal.Size = new System.Drawing.Size(500, 305);
            this.listViewPrincipal.TabIndex = 0;
            this.listViewPrincipal.UseCompatibleStateImageBehavior = false;
            this.listViewPrincipal.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDescricao
            // 
            this.columnHeaderDescricao.Text = "Descrição";
            this.columnHeaderDescricao.Width = 165;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor";
            this.columnHeaderValor.Width = 65;
            // 
            // columnHeaderCategoria1
            // 
            this.columnHeaderCategoria1.Text = "Categoria";
            this.columnHeaderCategoria1.Width = 75;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 55;
            // 
            // columnHeaderDataVencimento
            // 
            this.columnHeaderDataVencimento.Text = "Data Vencimento";
            this.columnHeaderDataVencimento.Width = 70;
            // 
            // columnHeaderDataPagamento
            // 
            this.columnHeaderDataPagamento.Text = "Data Pagamento";
            this.columnHeaderDataPagamento.Width = 70;
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadatroToolStripMenuItem,
            this.relatorioToolStripMenuItem,
            this.categoriToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menuStripPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(784, 24);
            this.menuStripPrincipal.TabIndex = 1;
            // 
            // cadatroToolStripMenuItem
            // 
            this.cadatroToolStripMenuItem.Name = "cadatroToolStripMenuItem";
            this.cadatroToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cadatroToolStripMenuItem.Text = "Contas";
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.relatorioToolStripMenuItem.Text = "Caixa";
            // 
            // categoriToolStripMenuItem
            // 
            this.categoriToolStripMenuItem.Name = "categoriToolStripMenuItem";
            this.categoriToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriToolStripMenuItem.Text = "Categorias";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.sairToolStripMenuItem.Text = "Relatórios";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem1.Text = "Sair";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(12, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageBusca);
            this.tabControl1.Controls.Add(this.Categorias);
            this.tabControl1.Location = new System.Drawing.Point(518, 130);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(254, 367);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageBusca
            // 
            this.tabPageBusca.Controls.Add(this.buttonLimpar);
            this.tabPageBusca.Controls.Add(this.buttonBuscar);
            this.tabPageBusca.Controls.Add(this.groupBox2);
            this.tabPageBusca.Controls.Add(this.groupBoxData);
            this.tabPageBusca.Controls.Add(this.groupBoxDescricao);
            this.tabPageBusca.Controls.Add(this.checkBoxCategoria);
            this.tabPageBusca.Controls.Add(this.checkBoxData);
            this.tabPageBusca.Controls.Add(this.checkBoxDescricao);
            this.tabPageBusca.Location = new System.Drawing.Point(4, 22);
            this.tabPageBusca.Name = "tabPageBusca";
            this.tabPageBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBusca.Size = new System.Drawing.Size(246, 341);
            this.tabPageBusca.TabIndex = 0;
            this.tabPageBusca.Text = "Busca";
            this.tabPageBusca.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(165, 312);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 19;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(84, 312);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCategoria);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(6, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 73);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(17, 18);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(55, 13);
            this.labelCategoria.TabIndex = 12;
            this.labelCategoria.Text = "Categoria:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 9;
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.labelDataMinima);
            this.groupBoxData.Controls.Add(this.dateTimePickerDataMinima);
            this.groupBoxData.Controls.Add(this.labelDataMaxima);
            this.groupBoxData.Controls.Add(this.dateTimePicker1);
            this.groupBoxData.Location = new System.Drawing.Point(6, 131);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(234, 73);
            this.groupBoxData.TabIndex = 17;
            this.groupBoxData.TabStop = false;
            // 
            // labelDataMinima
            // 
            this.labelDataMinima.AutoSize = true;
            this.labelDataMinima.Location = new System.Drawing.Point(13, 18);
            this.labelDataMinima.Name = "labelDataMinima";
            this.labelDataMinima.Size = new System.Drawing.Size(71, 13);
            this.labelDataMinima.TabIndex = 11;
            this.labelDataMinima.Text = "Data Miníma:";
            // 
            // dateTimePickerDataMinima
            // 
            this.dateTimePickerDataMinima.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataMinima.Location = new System.Drawing.Point(13, 34);
            this.dateTimePickerDataMinima.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDataMinima.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDataMinima.Name = "dateTimePickerDataMinima";
            this.dateTimePickerDataMinima.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerDataMinima.TabIndex = 4;
            this.dateTimePickerDataMinima.Value = new System.DateTime(2000, 1, 1, 22, 13, 0, 0);
            // 
            // labelDataMaxima
            // 
            this.labelDataMaxima.AutoSize = true;
            this.labelDataMaxima.Location = new System.Drawing.Point(124, 18);
            this.labelDataMaxima.Name = "labelDataMaxima";
            this.labelDataMaxima.Size = new System.Drawing.Size(72, 13);
            this.labelDataMaxima.TabIndex = 7;
            this.labelDataMaxima.Text = "Data Máxima:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 34);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // groupBoxDescricao
            // 
            this.groupBoxDescricao.Controls.Add(this.labelDescricao);
            this.groupBoxDescricao.Controls.Add(this.textBox1);
            this.groupBoxDescricao.Location = new System.Drawing.Point(6, 29);
            this.groupBoxDescricao.Name = "groupBoxDescricao";
            this.groupBoxDescricao.Size = new System.Drawing.Size(234, 73);
            this.groupBoxDescricao.TabIndex = 16;
            this.groupBoxDescricao.TabStop = false;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(17, 18);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(58, 13);
            this.labelDescricao.TabIndex = 10;
            this.labelDescricao.Text = "Descrição:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 2;
            // 
            // checkBoxCategoria
            // 
            this.checkBoxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCategoria.AutoSize = true;
            this.checkBoxCategoria.Location = new System.Drawing.Point(6, 210);
            this.checkBoxCategoria.Name = "checkBoxCategoria";
            this.checkBoxCategoria.Size = new System.Drawing.Size(71, 17);
            this.checkBoxCategoria.TabIndex = 15;
            this.checkBoxCategoria.Text = "Categoria";
            this.checkBoxCategoria.UseVisualStyleBackColor = true;
            // 
            // checkBoxData
            // 
            this.checkBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Location = new System.Drawing.Point(6, 108);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(49, 17);
            this.checkBoxData.TabIndex = 14;
            this.checkBoxData.Text = "Data";
            this.checkBoxData.UseVisualStyleBackColor = true;
            // 
            // checkBoxDescricao
            // 
            this.checkBoxDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDescricao.AutoSize = true;
            this.checkBoxDescricao.Location = new System.Drawing.Point(6, 6);
            this.checkBoxDescricao.Name = "checkBoxDescricao";
            this.checkBoxDescricao.Size = new System.Drawing.Size(74, 17);
            this.checkBoxDescricao.TabIndex = 13;
            this.checkBoxDescricao.Text = "Descrição";
            this.checkBoxDescricao.UseVisualStyleBackColor = true;
            // 
            // Categorias
            // 
            this.Categorias.Controls.Add(this.listViewCategorias);
            this.Categorias.Location = new System.Drawing.Point(4, 22);
            this.Categorias.Name = "Categorias";
            this.Categorias.Padding = new System.Windows.Forms.Padding(3);
            this.Categorias.Size = new System.Drawing.Size(246, 341);
            this.Categorias.TabIndex = 1;
            this.Categorias.Text = "Categorias";
            this.Categorias.UseVisualStyleBackColor = true;
            // 
            // listViewCategorias
            // 
            this.listViewCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCategorias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCategoria,
            this.columnHeaderOrcamento,
            this.columnHeaderGasto});
            this.listViewCategorias.FullRowSelect = true;
            this.listViewCategorias.Location = new System.Drawing.Point(6, 3);
            this.listViewCategorias.Name = "listViewCategorias";
            this.listViewCategorias.Size = new System.Drawing.Size(234, 272);
            this.listViewCategorias.TabIndex = 0;
            this.listViewCategorias.UseCompatibleStateImageBehavior = false;
            this.listViewCategorias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCategoria
            // 
            this.columnHeaderCategoria.Text = "Categoria";
            this.columnHeaderCategoria.Width = 110;
            // 
            // columnHeaderOrcamento
            // 
            this.columnHeaderOrcamento.Text = "Orçamento";
            this.columnHeaderOrcamento.Width = 65;
            // 
            // columnHeaderGasto
            // 
            this.columnHeaderGasto.Text = "Gasto";
            this.columnHeaderGasto.Width = 65;
            // 
            // panelTopo
            // 
            this.panelTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTopo.Controls.Add(this.comboBoxAno);
            this.panelTopo.Controls.Add(this.comboBoxMes);
            this.panelTopo.Controls.Add(this.buttonIrData);
            this.panelTopo.Controls.Add(this.buttonProximo);
            this.panelTopo.Controls.Add(this.buttonAnterior);
            this.panelTopo.Controls.Add(this.labelNomeMes);
            this.panelTopo.Location = new System.Drawing.Point(12, 67);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(500, 35);
            this.panelTopo.TabIndex = 4;
            // 
            // comboBoxAno
            // 
            this.comboBoxAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAno.FormattingEnabled = true;
            this.comboBoxAno.Items.AddRange(new object[] {
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
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
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050"});
            this.comboBoxAno.Location = new System.Drawing.Point(401, 7);
            this.comboBoxAno.Name = "comboBoxAno";
            this.comboBoxAno.Size = new System.Drawing.Size(60, 21);
            this.comboBoxAno.TabIndex = 6;
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.comboBoxMes.Location = new System.Drawing.Point(295, 7);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMes.TabIndex = 5;
            // 
            // buttonIrData
            // 
            this.buttonIrData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonIrData.Location = new System.Drawing.Point(467, 6);
            this.buttonIrData.Name = "buttonIrData";
            this.buttonIrData.Size = new System.Drawing.Size(30, 23);
            this.buttonIrData.TabIndex = 4;
            this.buttonIrData.Text = "Ir";
            this.buttonIrData.UseVisualStyleBackColor = true;
            // 
            // buttonProximo
            // 
            this.buttonProximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProximo.Location = new System.Drawing.Point(205, 6);
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.Size = new System.Drawing.Size(60, 23);
            this.buttonProximo.TabIndex = 2;
            this.buttonProximo.Text = "Proximo";
            this.buttonProximo.UseVisualStyleBackColor = true;
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAnterior.Location = new System.Drawing.Point(3, 6);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(60, 23);
            this.buttonAnterior.TabIndex = 1;
            this.buttonAnterior.Text = "Anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            // 
            // labelNomeMes
            // 
            this.labelNomeMes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNomeMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeMes.Location = new System.Drawing.Point(69, 10);
            this.labelNomeMes.Name = "labelNomeMes";
            this.labelNomeMes.Size = new System.Drawing.Size(130, 15);
            this.labelNomeMes.TabIndex = 0;
            this.labelNomeMes.Text = "Março 2012";
            this.labelNomeMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBoxDadosMes
            // 
            this.groupBoxDadosMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDadosMes.Controls.Add(this.labelSaldoValor);
            this.groupBoxDadosMes.Controls.Add(this.labelTotalContasValor);
            this.groupBoxDadosMes.Controls.Add(this.labelTotalCaixaValor);
            this.groupBoxDadosMes.Controls.Add(this.labelSaldo);
            this.groupBoxDadosMes.Controls.Add(this.labelTotalContas);
            this.groupBoxDadosMes.Controls.Add(this.labelTotalCaixa);
            this.groupBoxDadosMes.Location = new System.Drawing.Point(522, 27);
            this.groupBoxDadosMes.Name = "groupBoxDadosMes";
            this.groupBoxDadosMes.Size = new System.Drawing.Size(250, 97);
            this.groupBoxDadosMes.TabIndex = 6;
            this.groupBoxDadosMes.TabStop = false;
            this.groupBoxDadosMes.Text = "Mês: Março 2012";
            // 
            // labelSaldoValor
            // 
            this.labelSaldoValor.Location = new System.Drawing.Point(128, 62);
            this.labelSaldoValor.Name = "labelSaldoValor";
            this.labelSaldoValor.Size = new System.Drawing.Size(100, 13);
            this.labelSaldoValor.TabIndex = 5;
            this.labelSaldoValor.Text = "R$ 0,00";
            this.labelSaldoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalContasValor
            // 
            this.labelTotalContasValor.Location = new System.Drawing.Point(128, 42);
            this.labelTotalContasValor.Name = "labelTotalContasValor";
            this.labelTotalContasValor.Size = new System.Drawing.Size(100, 13);
            this.labelTotalContasValor.TabIndex = 4;
            this.labelTotalContasValor.Text = "R$ 0,00";
            this.labelTotalContasValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalCaixaValor
            // 
            this.labelTotalCaixaValor.Location = new System.Drawing.Point(128, 22);
            this.labelTotalCaixaValor.Name = "labelTotalCaixaValor";
            this.labelTotalCaixaValor.Size = new System.Drawing.Size(100, 13);
            this.labelTotalCaixaValor.TabIndex = 3;
            this.labelTotalCaixaValor.Text = "R$ 0,00";
            this.labelTotalCaixaValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSaldo
            // 
            this.labelSaldo.Location = new System.Drawing.Point(22, 62);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(100, 13);
            this.labelSaldo.TabIndex = 2;
            this.labelSaldo.Text = "Saldo:";
            this.labelSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalContas
            // 
            this.labelTotalContas.Location = new System.Drawing.Point(22, 42);
            this.labelTotalContas.Name = "labelTotalContas";
            this.labelTotalContas.Size = new System.Drawing.Size(100, 13);
            this.labelTotalContas.TabIndex = 1;
            this.labelTotalContas.Text = "Total de Contas:";
            this.labelTotalContas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalCaixa
            // 
            this.labelTotalCaixa.Location = new System.Drawing.Point(22, 22);
            this.labelTotalCaixa.Name = "labelTotalCaixa";
            this.labelTotalCaixa.Size = new System.Drawing.Size(100, 13);
            this.labelTotalCaixa.TabIndex = 0;
            this.labelTotalCaixa.Text = "Total do Caixa:";
            this.labelTotalCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 522);
            this.Controls.Add(this.listViewPrincipal);
            this.Controls.Add(this.groupBoxDadosMes);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelTopo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStripPrincipal);
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Gastos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageBusca.ResumeLayout(false);
            this.tabPageBusca.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBoxDescricao.ResumeLayout(false);
            this.groupBoxDescricao.PerformLayout();
            this.Categorias.ResumeLayout(false);
            this.panelTopo.ResumeLayout(false);
            this.groupBoxDadosMes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPrincipal;
        private System.Windows.Forms.ColumnHeader columnHeaderDescricao;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.ColumnHeader columnHeaderDataVencimento;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderDataPagamento;
        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem cadatroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderCategoria1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBusca;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataMinima;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TabPage Categorias;
        private System.Windows.Forms.ListView listViewCategorias;
        private System.Windows.Forms.ColumnHeader columnHeaderCategoria;
        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Label labelNomeMes;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelDataMinima;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelDataMaxima;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button buttonProximo;
        private System.Windows.Forms.GroupBox groupBoxDadosMes;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Label labelSaldoValor;
        private System.Windows.Forms.Label labelTotalContasValor;
        private System.Windows.Forms.Label labelTotalCaixaValor;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelTotalContas;
        private System.Windows.Forms.Label labelTotalCaixa;
        private System.Windows.Forms.Button buttonIrData;
        private System.Windows.Forms.ColumnHeader columnHeaderOrcamento;
        private System.Windows.Forms.ColumnHeader columnHeaderGasto;
        private System.Windows.Forms.GroupBox groupBoxDescricao;
        private System.Windows.Forms.CheckBox checkBoxCategoria;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.CheckBox checkBoxDescricao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.ComboBox comboBoxAno;
    }
}

