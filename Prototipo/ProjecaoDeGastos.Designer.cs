namespace WindowsFormsApplication1
{
    partial class ProjecaoDeGastos
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
            this.radioButtonGastosParc = new System.Windows.Forms.RadioButton();
            this.radioButtonGastosPeri = new System.Windows.Forms.RadioButton();
            this.comboBoxSemanaProj = new System.Windows.Forms.ComboBox();
            this.comboBoxMesProj = new System.Windows.Forms.ComboBox();
            this.comboBoxAnoProj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelMes = new System.Windows.Forms.Label();
            this.labelSemana = new System.Windows.Forms.Label();
            this.columnHeaderDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDescricao});
            this.listView1.Location = new System.Drawing.Point(28, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(459, 313);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // radioButtonGastosParc
            // 
            this.radioButtonGastosParc.AutoSize = true;
            this.radioButtonGastosParc.Location = new System.Drawing.Point(112, 76);
            this.radioButtonGastosParc.Name = "radioButtonGastosParc";
            this.radioButtonGastosParc.Size = new System.Drawing.Size(114, 17);
            this.radioButtonGastosParc.TabIndex = 4;
            this.radioButtonGastosParc.TabStop = true;
            this.radioButtonGastosParc.Tag = "1";
            this.radioButtonGastosParc.Text = "Gastos Parcelados";
            this.radioButtonGastosParc.UseVisualStyleBackColor = true;
            this.radioButtonGastosParc.CheckedChanged += new System.EventHandler(this.radioButtonGastosParc_CheckedChanged);
            this.radioButtonGastosParc.Click += new System.EventHandler(this.radioButtonClicado);
            // 
            // radioButtonGastosPeri
            // 
            this.radioButtonGastosPeri.AutoSize = true;
            this.radioButtonGastosPeri.Location = new System.Drawing.Point(282, 76);
            this.radioButtonGastosPeri.Name = "radioButtonGastosPeri";
            this.radioButtonGastosPeri.Size = new System.Drawing.Size(110, 17);
            this.radioButtonGastosPeri.TabIndex = 5;
            this.radioButtonGastosPeri.TabStop = true;
            this.radioButtonGastosPeri.Tag = "2";
            this.radioButtonGastosPeri.Text = "Gastos Periódicos";
            this.radioButtonGastosPeri.UseVisualStyleBackColor = true;
            this.radioButtonGastosPeri.Click += new System.EventHandler(this.radioButtonClicado);
            // 
            // comboBoxSemanaProj
            // 
            this.comboBoxSemanaProj.FormattingEnabled = true;
            this.comboBoxSemanaProj.Location = new System.Drawing.Point(28, 49);
            this.comboBoxSemanaProj.Name = "comboBoxSemanaProj";
            this.comboBoxSemanaProj.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSemanaProj.TabIndex = 1;
            // 
            // comboBoxMesProj
            // 
            this.comboBoxMesProj.FormattingEnabled = true;
            this.comboBoxMesProj.Location = new System.Drawing.Point(197, 49);
            this.comboBoxMesProj.Name = "comboBoxMesProj";
            this.comboBoxMesProj.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMesProj.TabIndex = 2;
            // 
            // comboBoxAnoProj
            // 
            this.comboBoxAnoProj.FormattingEnabled = true;
            this.comboBoxAnoProj.Location = new System.Drawing.Point(366, 49);
            this.comboBoxAnoProj.Name = "comboBoxAnoProj";
            this.comboBoxAnoProj.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAnoProj.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Gasto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(412, 429);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(366, 30);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(26, 13);
            this.labelAno.TabIndex = 8;
            this.labelAno.Text = "Ano";
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Location = new System.Drawing.Point(197, 30);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(27, 13);
            this.labelMes.TabIndex = 9;
            this.labelMes.Text = "Mês";
            // 
            // labelSemana
            // 
            this.labelSemana.AutoSize = true;
            this.labelSemana.Location = new System.Drawing.Point(25, 30);
            this.labelSemana.Name = "labelSemana";
            this.labelSemana.Size = new System.Drawing.Size(46, 13);
            this.labelSemana.TabIndex = 10;
            this.labelSemana.Text = "Semana";
            // 
            // columnHeaderDescricao
            // 
            this.columnHeaderDescricao.Text = "Descrição";
            this.columnHeaderDescricao.Width = 100;
            // 
            // ProjecaoDeGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 464);
            this.Controls.Add(this.labelSemana);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAnoProj);
            this.Controls.Add(this.comboBoxMesProj);
            this.Controls.Add(this.comboBoxSemanaProj);
            this.Controls.Add(this.radioButtonGastosPeri);
            this.Controls.Add(this.radioButtonGastosParc);
            this.Controls.Add(this.listView1);
            this.Name = "ProjecaoDeGastos";
            this.Text = "ProjecaoDeGastos";
            this.Load += new System.EventHandler(this.ProjecaoDeGastos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton radioButtonGastosParc;
        private System.Windows.Forms.RadioButton radioButtonGastosPeri;
        private System.Windows.Forms.ComboBox comboBoxSemanaProj;
        private System.Windows.Forms.ComboBox comboBoxMesProj;
        private System.Windows.Forms.ComboBox comboBoxAnoProj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.Label labelSemana;
        private System.Windows.Forms.ColumnHeader columnHeaderDescricao;
    }
}