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
            this.comboBoxDescCat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.checkBoxSemana = new System.Windows.Forms.CheckBox();
            this.checkBoxMes = new System.Windows.Forms.CheckBox();
            this.checkBoxAno = new System.Windows.Forms.CheckBox();
            this.checkBoxCategoria = new System.Windows.Forms.CheckBox();
            this.dateTimePickerSemana = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxRelatorioCategoria
            // 
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
            this.listViewRelatorio.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderDescricao
            // 
            this.columnHeaderDescricao.Text = "Descrição";
            this.columnHeaderDescricao.Width = 200;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor";
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
            this.groupBox1.Controls.Add(this.comboBoxDescCat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 478);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBoxDescCat
            // 
            this.comboBoxDescCat.FormattingEnabled = true;
            this.comboBoxDescCat.Location = new System.Drawing.Point(66, 122);
            this.comboBoxDescCat.Name = "comboBoxDescCat";
            this.comboBoxDescCat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDescCat.TabIndex = 8;
            this.comboBoxDescCat.Visible = false;
            this.comboBoxDescCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxDescCat_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Crédito ou Débito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Menor Gasto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maior Gasto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Média de Gasto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(394, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxMes
            // 
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
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 691);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDescCat;
        private System.Windows.Forms.CheckBox checkBoxSemana;
        private System.Windows.Forms.CheckBox checkBoxMes;
        private System.Windows.Forms.CheckBox checkBoxAno;
        private System.Windows.Forms.CheckBox checkBoxCategoria;
        private System.Windows.Forms.DateTimePicker dateTimePickerSemana;
    }
}