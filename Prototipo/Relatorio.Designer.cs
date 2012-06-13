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
            this.labelCategoria = new System.Windows.Forms.Label();
            this.buttonCancelarRelat = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataCadastro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // comboBoxRelatorioCategoria
            // 
            this.comboBoxRelatorioCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRelatorioCategoria.FormattingEnabled = true;
            this.comboBoxRelatorioCategoria.Location = new System.Drawing.Point(566, 42);
            this.comboBoxRelatorioCategoria.Name = "comboBoxRelatorioCategoria";
            this.comboBoxRelatorioCategoria.Size = new System.Drawing.Size(163, 21);
            this.comboBoxRelatorioCategoria.TabIndex = 1;
            // 
            // labelCategoria
            // 
            this.labelCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(563, 26);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(55, 13);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.Text = "Categoria:";
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDescricao,
            this.columnHeaderValor,
            this.columnHeaderCategoria,
            this.columnHeaderDataCadastro,
            this.columnHeaderDataVencimento,
            this.columnHeaderDataPagamento});
            this.listView1.Location = new System.Drawing.Point(29, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 543);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 691);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonCancelarRelat);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.comboBoxRelatorioCategoria);
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRelatorioCategoria;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Button buttonCancelarRelat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderDescricao;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.ColumnHeader columnHeaderCategoria;
        private System.Windows.Forms.ColumnHeader columnHeaderDataCadastro;
        private System.Windows.Forms.ColumnHeader columnHeaderDataVencimento;
        private System.Windows.Forms.ColumnHeader columnHeaderDataPagamento;
    }
}