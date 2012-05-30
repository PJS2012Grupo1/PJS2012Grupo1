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
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelDataMinima = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelDataMaxima = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataMinima = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Categorias = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeaderCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelTopo = new System.Windows.Forms.Panel();
            this.buttonIrData = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBusca.SuspendLayout();
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
            this.listViewPrincipal.Size = new System.Drawing.Size(528, 245);
            this.listViewPrincipal.TabIndex = 0;
            this.listViewPrincipal.UseCompatibleStateImageBehavior = false;
            this.listViewPrincipal.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDescricao
            // 
            this.columnHeaderDescricao.Text = "Descrição";
            this.columnHeaderDescricao.Width = 185;
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
            this.cadatroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.cadatroToolStripMenuItem.Name = "cadatroToolStripMenuItem";
            this.cadatroToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cadatroToolStripMenuItem.Text = "Contas";
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1});
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
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(12, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageBusca);
            this.tabControl1.Controls.Add(this.Categorias);
            this.tabControl1.Location = new System.Drawing.Point(546, 154);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(226, 283);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageBusca
            // 
            this.tabPageBusca.Controls.Add(this.labelCategoria);
            this.tabPageBusca.Controls.Add(this.labelDataMinima);
            this.tabPageBusca.Controls.Add(this.labelDescricao);
            this.tabPageBusca.Controls.Add(this.textBox2);
            this.tabPageBusca.Controls.Add(this.labelDataMaxima);
            this.tabPageBusca.Controls.Add(this.dateTimePicker1);
            this.tabPageBusca.Controls.Add(this.dateTimePickerDataMinima);
            this.tabPageBusca.Controls.Add(this.textBox1);
            this.tabPageBusca.Controls.Add(this.button1);
            this.tabPageBusca.Location = new System.Drawing.Point(4, 22);
            this.tabPageBusca.Name = "tabPageBusca";
            this.tabPageBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBusca.Size = new System.Drawing.Size(218, 257);
            this.tabPageBusca.TabIndex = 0;
            this.tabPageBusca.Text = "Busca";
            this.tabPageBusca.UseVisualStyleBackColor = true;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(6, 166);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 12;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelDataMinima
            // 
            this.labelDataMinima.AutoSize = true;
            this.labelDataMinima.Location = new System.Drawing.Point(9, 68);
            this.labelDataMinima.Name = "labelDataMinima";
            this.labelDataMinima.Size = new System.Drawing.Size(68, 13);
            this.labelDataMinima.TabIndex = 11;
            this.labelDataMinima.Text = "Data Miníma";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(6, 15);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 10;
            this.labelDescricao.Text = "Descrição";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 20);
            this.textBox2.TabIndex = 9;
            // 
            // labelDataMaxima
            // 
            this.labelDataMaxima.AutoSize = true;
            this.labelDataMaxima.Location = new System.Drawing.Point(7, 115);
            this.labelDataMaxima.Name = "labelDataMaxima";
            this.labelDataMaxima.Size = new System.Drawing.Size(69, 13);
            this.labelDataMaxima.TabIndex = 7;
            this.labelDataMaxima.Text = "Data Máxima";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 136);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // dateTimePickerDataMinima
            // 
            this.dateTimePickerDataMinima.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataMinima.Location = new System.Drawing.Point(6, 87);
            this.dateTimePickerDataMinima.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDataMinima.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDataMinima.Name = "dateTimePickerDataMinima";
            this.dateTimePickerDataMinima.Size = new System.Drawing.Size(86, 20);
            this.dateTimePickerDataMinima.TabIndex = 4;
            this.dateTimePickerDataMinima.Value = new System.DateTime(2000, 1, 1, 22, 13, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Categorias
            // 
            this.Categorias.Controls.Add(this.listView2);
            this.Categorias.Location = new System.Drawing.Point(4, 22);
            this.Categorias.Name = "Categorias";
            this.Categorias.Padding = new System.Windows.Forms.Padding(3);
            this.Categorias.Size = new System.Drawing.Size(218, 257);
            this.Categorias.TabIndex = 1;
            this.Categorias.Text = "Categorias";
            this.Categorias.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCategoria});
            this.listView2.Location = new System.Drawing.Point(6, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(206, 248);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCategoria
            // 
            this.columnHeaderCategoria.Text = "Categoria";
            this.columnHeaderCategoria.Width = 202;
            // 
            // panelTopo
            // 
            this.panelTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTopo.Controls.Add(this.buttonIrData);
            this.panelTopo.Controls.Add(this.dateTimePicker);
            this.panelTopo.Controls.Add(this.buttonProximo);
            this.panelTopo.Controls.Add(this.buttonAnterior);
            this.panelTopo.Controls.Add(this.labelNomeMes);
            this.panelTopo.Location = new System.Drawing.Point(12, 67);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(528, 35);
            this.panelTopo.TabIndex = 4;
            // 
            // buttonIrData
            // 
            this.buttonIrData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonIrData.Location = new System.Drawing.Point(495, 6);
            this.buttonIrData.Name = "buttonIrData";
            this.buttonIrData.Size = new System.Drawing.Size(30, 23);
            this.buttonIrData.TabIndex = 4;
            this.buttonIrData.Text = "Ir";
            this.buttonIrData.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker.CustomFormat = "mm/yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(368, 7);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // buttonProximo
            // 
            this.buttonProximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProximo.Location = new System.Drawing.Point(215, 6);
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
            this.labelNomeMes.Location = new System.Drawing.Point(69, 9);
            this.labelNomeMes.Name = "labelNomeMes";
            this.labelNomeMes.Size = new System.Drawing.Size(140, 15);
            this.labelNomeMes.TabIndex = 0;
            this.labelNomeMes.Text = "Março 2012";
            this.labelNomeMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
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
            this.groupBoxDadosMes.Location = new System.Drawing.Point(556, 27);
            this.groupBoxDadosMes.Name = "groupBoxDadosMes";
            this.groupBoxDadosMes.Size = new System.Drawing.Size(216, 121);
            this.groupBoxDadosMes.TabIndex = 6;
            this.groupBoxDadosMes.TabStop = false;
            this.groupBoxDadosMes.Text = "Mês: Março 2012";
            // 
            // labelSaldoValor
            // 
            this.labelSaldoValor.Location = new System.Drawing.Point(111, 74);
            this.labelSaldoValor.Name = "labelSaldoValor";
            this.labelSaldoValor.Size = new System.Drawing.Size(100, 13);
            this.labelSaldoValor.TabIndex = 5;
            this.labelSaldoValor.Text = "R$ 0,00";
            this.labelSaldoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalContasValor
            // 
            this.labelTotalContasValor.Location = new System.Drawing.Point(111, 54);
            this.labelTotalContasValor.Name = "labelTotalContasValor";
            this.labelTotalContasValor.Size = new System.Drawing.Size(100, 13);
            this.labelTotalContasValor.TabIndex = 4;
            this.labelTotalContasValor.Text = "R$ 0,00";
            this.labelTotalContasValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalCaixaValor
            // 
            this.labelTotalCaixaValor.Location = new System.Drawing.Point(111, 34);
            this.labelTotalCaixaValor.Name = "labelTotalCaixaValor";
            this.labelTotalCaixaValor.Size = new System.Drawing.Size(100, 13);
            this.labelTotalCaixaValor.TabIndex = 3;
            this.labelTotalCaixaValor.Text = "R$ 0,00";
            this.labelTotalCaixaValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSaldo
            // 
            this.labelSaldo.Location = new System.Drawing.Point(5, 74);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(100, 13);
            this.labelSaldo.TabIndex = 2;
            this.labelSaldo.Text = "Saldo:";
            this.labelSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalContas
            // 
            this.labelTotalContas.Location = new System.Drawing.Point(5, 54);
            this.labelTotalContas.Name = "labelTotalContas";
            this.labelTotalContas.Size = new System.Drawing.Size(100, 13);
            this.labelTotalContas.TabIndex = 1;
            this.labelTotalContas.Text = "Total de Contas:";
            this.labelTotalContas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalCaixa
            // 
            this.labelTotalCaixa.Location = new System.Drawing.Point(5, 34);
            this.labelTotalCaixa.Name = "labelTotalCaixa";
            this.labelTotalCaixa.Size = new System.Drawing.Size(100, 13);
            this.labelTotalCaixa.TabIndex = 0;
            this.labelTotalCaixa.Text = "Total do Caixa:";
            this.labelTotalCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.groupBoxDadosMes);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelTopo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewPrincipal);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Categorias;
        private System.Windows.Forms.ListView listView2;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonIrData;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
    }
}

