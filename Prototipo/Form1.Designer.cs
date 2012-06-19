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
            this.columnHeaderCadastro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadatroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apresentarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDadosMes = new System.Windows.Forms.GroupBox();
            this.labelSaldoValor = new System.Windows.Forms.Label();
            this.labelTotalCaixa = new System.Windows.Forms.Label();
            this.labelTotalContasValor = new System.Windows.Forms.Label();
            this.labelTotalContas = new System.Windows.Forms.Label();
            this.labelTotalCaixaValor = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBusca = new System.Windows.Forms.TabPage();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupBoxCategoria = new System.Windows.Forms.GroupBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.labelDataMinima = new System.Windows.Forms.Label();
            this.dateTimePickerDataMinima = new System.Windows.Forms.DateTimePicker();
            this.labelDataMaxima = new System.Windows.Forms.Label();
            this.dateTimePickerDataMaxima = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDescricao = new System.Windows.Forms.GroupBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
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
            this.menuStripPrincipal.SuspendLayout();
            this.groupBoxDadosMes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBusca.SuspendLayout();
            this.groupBoxCategoria.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.groupBoxDescricao.SuspendLayout();
            this.Categorias.SuspendLayout();
            this.panelTopo.SuspendLayout();
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
            this.columnHeaderCadastro,
            this.columnHeaderDataVencimento,
            this.columnHeaderDataPagamento});
            this.listViewPrincipal.FullRowSelect = true;
            this.listViewPrincipal.Location = new System.Drawing.Point(12, 68);
            this.listViewPrincipal.Name = "listViewPrincipal";
            this.listViewPrincipal.Size = new System.Drawing.Size(656, 395);
            this.listViewPrincipal.TabIndex = 0;
            this.listViewPrincipal.UseCompatibleStateImageBehavior = false;
            this.listViewPrincipal.View = System.Windows.Forms.View.Details;
            this.listViewPrincipal.DoubleClick += new System.EventHandler(this.listViewPrincipal_DoubleClick);
            // 
            // columnHeaderDescricao
            // 
            this.columnHeaderDescricao.Text = "Descrição";
            this.columnHeaderDescricao.Width = 216;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor";
            this.columnHeaderValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderValor.Width = 65;
            // 
            // columnHeaderCategoria1
            // 
            this.columnHeaderCategoria1.Text = "Categoria";
            this.columnHeaderCategoria1.Width = 75;
            // 
            // columnHeaderCadastro
            // 
            this.columnHeaderCadastro.Text = "Data Cadastro";
            this.columnHeaderCadastro.Width = 87;
            // 
            // columnHeaderDataVencimento
            // 
            this.columnHeaderDataVencimento.Text = "Data Vencimento";
            this.columnHeaderDataVencimento.Width = 112;
            // 
            // columnHeaderDataPagamento
            // 
            this.columnHeaderDataPagamento.Text = "Data Pagamento";
            this.columnHeaderDataPagamento.Width = 90;
            // 
            // columnHeaderCodigo
            // 
            this.columnHeaderCodigo.Text = "codigo";
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
            this.menuStripPrincipal.Size = new System.Drawing.Size(940, 24);
            this.menuStripPrincipal.TabIndex = 1;
            // 
            // cadatroToolStripMenuItem
            // 
            this.cadatroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.cadatroToolStripMenuItem.Name = "cadatroToolStripMenuItem";
            this.cadatroToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cadatroToolStripMenuItem.Text = "Contas";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1});
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.relatorioToolStripMenuItem.Text = "Caixa";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // categoriToolStripMenuItem
            // 
            this.categoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem2});
            this.categoriToolStripMenuItem.Name = "categoriToolStripMenuItem";
            this.categoriToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriToolStripMenuItem.Text = "Categorias";
            // 
            // cadastroToolStripMenuItem2
            // 
            this.cadastroToolStripMenuItem2.Name = "cadastroToolStripMenuItem2";
            this.cadastroToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem2.Text = "Cadastro";
            this.cadastroToolStripMenuItem2.Click += new System.EventHandler(this.cadastroToolStripMenuItem2_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.semanaToolStripMenuItem,
            this.mêsToolStripMenuItem,
            this.anoToolStripMenuItem,
            this.apresentarToolStripMenuItem});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.sairToolStripMenuItem.Text = "Relatórios";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // semanaToolStripMenuItem
            // 
            this.semanaToolStripMenuItem.Name = "semanaToolStripMenuItem";
            this.semanaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.semanaToolStripMenuItem.Text = "Semana";
            this.semanaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // mêsToolStripMenuItem
            // 
            this.mêsToolStripMenuItem.Name = "mêsToolStripMenuItem";
            this.mêsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.mêsToolStripMenuItem.Text = "Mês";
            this.mêsToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // anoToolStripMenuItem
            // 
            this.anoToolStripMenuItem.Name = "anoToolStripMenuItem";
            this.anoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.anoToolStripMenuItem.Text = "Ano";
            this.anoToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // apresentarToolStripMenuItem
            // 
            this.apresentarToolStripMenuItem.Name = "apresentarToolStripMenuItem";
            this.apresentarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.apresentarToolStripMenuItem.Text = "Categoria";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // groupBoxDadosMes
            // 
            this.groupBoxDadosMes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDadosMes.Controls.Add(this.labelSaldoValor);
            this.groupBoxDadosMes.Controls.Add(this.labelTotalCaixa);
            this.groupBoxDadosMes.Controls.Add(this.labelTotalContasValor);
            this.groupBoxDadosMes.Controls.Add(this.labelTotalContas);
            this.groupBoxDadosMes.Controls.Add(this.labelTotalCaixaValor);
            this.groupBoxDadosMes.Controls.Add(this.labelSaldo);
            this.groupBoxDadosMes.Location = new System.Drawing.Point(12, 469);
            this.groupBoxDadosMes.Name = "groupBoxDadosMes";
            this.groupBoxDadosMes.Size = new System.Drawing.Size(656, 84);
            this.groupBoxDadosMes.TabIndex = 2;
            this.groupBoxDadosMes.TabStop = false;
            this.groupBoxDadosMes.Text = "Informações";
            // 
            // labelSaldoValor
            // 
            this.labelSaldoValor.Location = new System.Drawing.Point(425, 18);
            this.labelSaldoValor.Name = "labelSaldoValor";
            this.labelSaldoValor.Size = new System.Drawing.Size(100, 13);
            this.labelSaldoValor.TabIndex = 5;
            this.labelSaldoValor.Text = "R$";
            this.labelSaldoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalCaixa
            // 
            this.labelTotalCaixa.Location = new System.Drawing.Point(6, 17);
            this.labelTotalCaixa.Name = "labelTotalCaixa";
            this.labelTotalCaixa.Size = new System.Drawing.Size(86, 15);
            this.labelTotalCaixa.TabIndex = 0;
            this.labelTotalCaixa.Text = "Total do Caixa:";
            this.labelTotalCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalContasValor
            // 
            this.labelTotalContasValor.Location = new System.Drawing.Point(271, 18);
            this.labelTotalContasValor.Name = "labelTotalContasValor";
            this.labelTotalContasValor.Size = new System.Drawing.Size(85, 13);
            this.labelTotalContasValor.TabIndex = 4;
            this.labelTotalContasValor.Text = "R$";
            this.labelTotalContasValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalContas
            // 
            this.labelTotalContas.Location = new System.Drawing.Point(179, 18);
            this.labelTotalContas.Name = "labelTotalContas";
            this.labelTotalContas.Size = new System.Drawing.Size(86, 13);
            this.labelTotalContas.TabIndex = 1;
            this.labelTotalContas.Text = "Total de Contas:";
            this.labelTotalContas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalCaixaValor
            // 
            this.labelTotalCaixaValor.Location = new System.Drawing.Point(98, 18);
            this.labelTotalCaixaValor.Name = "labelTotalCaixaValor";
            this.labelTotalCaixaValor.Size = new System.Drawing.Size(75, 13);
            this.labelTotalCaixaValor.TabIndex = 3;
            this.labelTotalCaixaValor.Text = "R$";
            this.labelTotalCaixaValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSaldo
            // 
            this.labelSaldo.Location = new System.Drawing.Point(362, 18);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(57, 13);
            this.labelSaldo.TabIndex = 2;
            this.labelSaldo.Text = "Saldo:";
            this.labelSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageBusca);
            this.tabControl1.Controls.Add(this.Categorias);
            this.tabControl1.Location = new System.Drawing.Point(674, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(254, 526);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageBusca
            // 
            this.tabPageBusca.Controls.Add(this.buttonLimpar);
            this.tabPageBusca.Controls.Add(this.buttonBuscar);
            this.tabPageBusca.Controls.Add(this.groupBoxCategoria);
            this.tabPageBusca.Controls.Add(this.groupBoxData);
            this.tabPageBusca.Controls.Add(this.groupBoxDescricao);
            this.tabPageBusca.Controls.Add(this.checkBoxCategoria);
            this.tabPageBusca.Controls.Add(this.checkBoxData);
            this.tabPageBusca.Controls.Add(this.checkBoxDescricao);
            this.tabPageBusca.Location = new System.Drawing.Point(4, 22);
            this.tabPageBusca.Name = "tabPageBusca";
            this.tabPageBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBusca.Size = new System.Drawing.Size(246, 500);
            this.tabPageBusca.TabIndex = 0;
            this.tabPageBusca.Text = "Busca";
            this.tabPageBusca.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Enabled = false;
            this.buttonLimpar.Location = new System.Drawing.Point(165, 312);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 19;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Enabled = false;
            this.buttonBuscar.Location = new System.Drawing.Point(84, 312);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // groupBoxCategoria
            // 
            this.groupBoxCategoria.Controls.Add(this.comboBoxCategoria);
            this.groupBoxCategoria.Controls.Add(this.labelCategoria);
            this.groupBoxCategoria.Enabled = false;
            this.groupBoxCategoria.Location = new System.Drawing.Point(6, 233);
            this.groupBoxCategoria.Name = "groupBoxCategoria";
            this.groupBoxCategoria.Size = new System.Drawing.Size(234, 73);
            this.groupBoxCategoria.TabIndex = 18;
            this.groupBoxCategoria.TabStop = false;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(17, 34);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategoria.TabIndex = 13;
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
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.labelDataMinima);
            this.groupBoxData.Controls.Add(this.dateTimePickerDataMinima);
            this.groupBoxData.Controls.Add(this.labelDataMaxima);
            this.groupBoxData.Controls.Add(this.dateTimePickerDataMaxima);
            this.groupBoxData.Enabled = false;
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
            // dateTimePickerDataMaxima
            // 
            this.dateTimePickerDataMaxima.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataMaxima.Location = new System.Drawing.Point(127, 34);
            this.dateTimePickerDataMaxima.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDataMaxima.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDataMaxima.Name = "dateTimePickerDataMaxima";
            this.dateTimePickerDataMaxima.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerDataMaxima.TabIndex = 6;
            this.dateTimePickerDataMaxima.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // groupBoxDescricao
            // 
            this.groupBoxDescricao.Controls.Add(this.labelDescricao);
            this.groupBoxDescricao.Controls.Add(this.textBoxDescricao);
            this.groupBoxDescricao.Enabled = false;
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
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(17, 34);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescricao.TabIndex = 2;
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
            this.checkBoxCategoria.Click += new System.EventHandler(this.checkBoxCategoria_Click);
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
            this.checkBoxData.Click += new System.EventHandler(this.checkBoxData_Click);
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
            this.checkBoxDescricao.Click += new System.EventHandler(this.checkBoxDescricao_Click);
            // 
            // Categorias
            // 
            this.Categorias.Controls.Add(this.listViewCategorias);
            this.Categorias.Location = new System.Drawing.Point(4, 22);
            this.Categorias.Name = "Categorias";
            this.Categorias.Padding = new System.Windows.Forms.Padding(3);
            this.Categorias.Size = new System.Drawing.Size(246, 474);
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
            this.listViewCategorias.Size = new System.Drawing.Size(234, 385);
            this.listViewCategorias.TabIndex = 0;
            this.listViewCategorias.UseCompatibleStateImageBehavior = false;
            this.listViewCategorias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCategoria
            // 
            this.columnHeaderCategoria.Text = "Categoria";
            this.columnHeaderCategoria.Width = 101;
            // 
            // columnHeaderOrcamento
            // 
            this.columnHeaderOrcamento.Text = "Orçamento";
            this.columnHeaderOrcamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderOrcamento.Width = 65;
            // 
            // columnHeaderGasto
            // 
            this.columnHeaderGasto.Text = "Gasto";
            this.columnHeaderGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.panelTopo.Location = new System.Drawing.Point(12, 27);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(656, 35);
            this.panelTopo.TabIndex = 4;
            // 
            // comboBoxAno
            // 
            this.comboBoxAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAno.FormattingEnabled = true;
            this.comboBoxAno.Items.AddRange(new object[] {
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
            this.comboBoxAno.Location = new System.Drawing.Point(557, 7);
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
            this.comboBoxMes.Location = new System.Drawing.Point(451, 7);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMes.TabIndex = 5;
            // 
            // buttonIrData
            // 
            this.buttonIrData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonIrData.Location = new System.Drawing.Point(623, 6);
            this.buttonIrData.Name = "buttonIrData";
            this.buttonIrData.Size = new System.Drawing.Size(30, 23);
            this.buttonIrData.TabIndex = 4;
            this.buttonIrData.Text = "Ir";
            this.buttonIrData.UseVisualStyleBackColor = true;
            // 
            // buttonProximo
            // 
            this.buttonProximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProximo.Location = new System.Drawing.Point(283, 6);
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.Size = new System.Drawing.Size(60, 23);
            this.buttonProximo.TabIndex = 2;
            this.buttonProximo.Text = "Proximo";
            this.buttonProximo.UseVisualStyleBackColor = true;
            this.buttonProximo.Click += new System.EventHandler(this.buttonProximo_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAnterior.Location = new System.Drawing.Point(81, 6);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(60, 23);
            this.buttonAnterior.TabIndex = 1;
            this.buttonAnterior.Text = "Anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // labelNomeMes
            // 
            this.labelNomeMes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNomeMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeMes.Location = new System.Drawing.Point(147, 10);
            this.labelNomeMes.Name = "labelNomeMes";
            this.labelNomeMes.Size = new System.Drawing.Size(130, 15);
            this.labelNomeMes.TabIndex = 0;
            this.labelNomeMes.Text = "Março 2012";
            this.labelNomeMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(940, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 578);
            this.Controls.Add(this.listViewPrincipal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelTopo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBoxDadosMes);
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
            this.groupBoxDadosMes.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBusca.ResumeLayout(false);
            this.tabPageBusca.PerformLayout();
            this.groupBoxCategoria.ResumeLayout(false);
            this.groupBoxCategoria.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBoxDescricao.ResumeLayout(false);
            this.groupBoxDescricao.PerformLayout();
            this.Categorias.ResumeLayout(false);
            this.panelTopo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPrincipal;
        private System.Windows.Forms.ColumnHeader columnHeaderDescricao;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.ColumnHeader columnHeaderDataVencimento;
        private System.Windows.Forms.ColumnHeader columnHeaderCadastro;
        private System.Windows.Forms.ColumnHeader columnHeaderDataPagamento;
        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.GroupBox groupBoxDadosMes;
        private System.Windows.Forms.ToolStripMenuItem cadatroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderCategoria1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBusca;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataMaxima;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataMinima;
        private System.Windows.Forms.TextBox textBoxDescricao;
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
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Label labelSaldoValor;
        private System.Windows.Forms.Label labelTotalContasValor;
        private System.Windows.Forms.Label labelTotalCaixaValor;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelTotalContas;
        private System.Windows.Forms.Label labelTotalCaixa;
        private System.Windows.Forms.Button buttonIrData;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader columnHeaderOrcamento;
        private System.Windows.Forms.ColumnHeader columnHeaderGasto;
        private System.Windows.Forms.GroupBox groupBoxDescricao;
        private System.Windows.Forms.CheckBox checkBoxCategoria;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.CheckBox checkBoxDescricao;
        private System.Windows.Forms.GroupBox groupBoxCategoria;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.ComboBox comboBoxAno;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem2;

        protected internal System.Windows.Forms.ColumnHeader columnHeaderCodigo;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anoToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem apresentarToolStripMenuItem;

    }
}

