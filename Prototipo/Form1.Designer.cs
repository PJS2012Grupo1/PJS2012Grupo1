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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategoria1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadatroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regitroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBusca = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataMinima = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Categorias = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeaderCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelDataMinima = new System.Windows.Forms.Label();
            this.labelDataMaxima = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBusca.SuspendLayout();
            this.Categorias.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDescricao,
            this.columnHeaderValor,
            this.columnHeaderCategoria1,
            this.columnHeaderStatus,
            this.columnHeaderDataVencimento,
            this.columnHeaderDataPagamento});
            this.listView1.Location = new System.Drawing.Point(12, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(747, 444);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDescricao
            // 
            this.columnHeaderDescricao.Text = "Descrição";
            this.columnHeaderDescricao.Width = 270;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor";
            this.columnHeaderValor.Width = 83;
            // 
            // columnHeaderCategoria1
            // 
            this.columnHeaderCategoria1.Text = "Categoria";
            this.columnHeaderCategoria1.Width = 98;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 86;
            // 
            // columnHeaderDataVencimento
            // 
            this.columnHeaderDataVencimento.Text = "Data Vencimento";
            this.columnHeaderDataVencimento.Width = 105;
            // 
            // columnHeaderDataPagamento
            // 
            this.columnHeaderDataPagamento.Text = "Data Pagamento";
            this.columnHeaderDataPagamento.Width = 102;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadatroToolStripMenuItem,
            this.relatorioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadatroToolStripMenuItem
            // 
            this.cadatroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regitroToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.caixaToolStripMenuItem});
            this.cadatroToolStripMenuItem.Name = "cadatroToolStripMenuItem";
            this.cadatroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.cadatroToolStripMenuItem.Text = "Cadatro";
            // 
            // regitroToolStripMenuItem
            // 
            this.regitroToolStripMenuItem.Name = "regitroToolStripMenuItem";
            this.regitroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.regitroToolStripMenuItem.Text = "Registro";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 517);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gasto mês: 0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Saldo: 0.00";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageBusca);
            this.tabControl1.Controls.Add(this.Categorias);
            this.tabControl1.Location = new System.Drawing.Point(776, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 444);
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
            this.tabPageBusca.Size = new System.Drawing.Size(232, 418);
            this.tabPageBusca.TabIndex = 0;
            this.tabPageBusca.Text = "Busca";
            this.tabPageBusca.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 20);
            this.textBox2.TabIndex = 9;
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
            this.Categorias.Size = new System.Drawing.Size(232, 418);
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
            this.listView2.Location = new System.Drawing.Point(-4, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(236, 414);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCategoria
            // 
            this.columnHeaderCategoria.Text = "Categoria";
            this.columnHeaderCategoria.Width = 191;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 34);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Março 2012";
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
            // labelDataMinima
            // 
            this.labelDataMinima.AutoSize = true;
            this.labelDataMinima.Location = new System.Drawing.Point(9, 68);
            this.labelDataMinima.Name = "labelDataMinima";
            this.labelDataMinima.Size = new System.Drawing.Size(68, 13);
            this.labelDataMinima.TabIndex = 11;
            this.labelDataMinima.Text = "Data Miníma";
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
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(6, 166);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 12;
            this.labelCategoria.Text = "Categoria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageBusca.ResumeLayout(false);
            this.tabPageBusca.PerformLayout();
            this.Categorias.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderDescricao;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.ColumnHeader columnHeaderDataVencimento;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderDataPagamento;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem cadatroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regitroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelDataMinima;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelDataMaxima;
    }
}

