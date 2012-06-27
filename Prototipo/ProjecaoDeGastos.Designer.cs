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
            this.comboBoxMesProj = new System.Windows.Forms.ComboBox();
            this.comboBoxAnoProj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelMes = new System.Windows.Forms.Label();
            this.labelSemana = new System.Windows.Forms.Label();
            this.dateTimePickerSemana = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Location = new System.Drawing.Point(12, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(671, 381);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // radioButtonGastosParc
            // 
            this.radioButtonGastosParc.AutoSize = true;
            this.radioButtonGastosParc.Checked = true;
            this.radioButtonGastosParc.Location = new System.Drawing.Point(151, 76);
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
            this.radioButtonGastosPeri.Location = new System.Drawing.Point(388, 76);
            this.radioButtonGastosPeri.Name = "radioButtonGastosPeri";
            this.radioButtonGastosPeri.Size = new System.Drawing.Size(110, 17);
            this.radioButtonGastosPeri.TabIndex = 5;
            this.radioButtonGastosPeri.Tag = "2";
            this.radioButtonGastosPeri.Text = "Gastos Periódicos";
            this.radioButtonGastosPeri.UseVisualStyleBackColor = true;
            this.radioButtonGastosPeri.CheckedChanged += new System.EventHandler(this.radioButtonGastosPeri_CheckedChanged);
            this.radioButtonGastosPeri.Click += new System.EventHandler(this.radioButtonClicado);
            // 
            // comboBoxMesProj
            // 
            this.comboBoxMesProj.FormattingEnabled = true;
            this.comboBoxMesProj.Items.AddRange(new object[] {
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
            this.comboBoxMesProj.Location = new System.Drawing.Point(264, 49);
            this.comboBoxMesProj.Name = "comboBoxMesProj";
            this.comboBoxMesProj.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMesProj.TabIndex = 2;
            this.comboBoxMesProj.SelectedIndexChanged += new System.EventHandler(this.comboBoxMesProj_SelectedIndexChanged);
            // 
            // comboBoxAnoProj
            // 
            this.comboBoxAnoProj.FormattingEnabled = true;
            this.comboBoxAnoProj.Items.AddRange(new object[] {
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
            this.comboBoxAnoProj.Location = new System.Drawing.Point(497, 49);
            this.comboBoxAnoProj.Name = "comboBoxAnoProj";
            this.comboBoxAnoProj.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAnoProj.TabIndex = 3;
            this.comboBoxAnoProj.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnoProj_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Gasto:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSair.Location = new System.Drawing.Point(608, 501);
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
            this.labelAno.Location = new System.Drawing.Point(494, 30);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(26, 13);
            this.labelAno.TabIndex = 8;
            this.labelAno.Text = "Ano";
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Location = new System.Drawing.Point(261, 30);
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
            // dateTimePickerSemana
            // 
            this.dateTimePickerSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSemana.Location = new System.Drawing.Point(28, 50);
            this.dateTimePickerSemana.Name = "dateTimePickerSemana";
            this.dateTimePickerSemana.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerSemana.TabIndex = 14;
            this.dateTimePickerSemana.Value = new System.DateTime(2012, 5, 22, 19, 32, 0, 0);
            this.dateTimePickerSemana.ValueChanged += new System.EventHandler(this.dateTimePickerSemana_ValueChanged);
            // 
            // ProjecaoDeGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 536);
            this.Controls.Add(this.dateTimePickerSemana);
            this.Controls.Add(this.labelSemana);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAnoProj);
            this.Controls.Add(this.comboBoxMesProj);
            this.Controls.Add(this.radioButtonGastosPeri);
            this.Controls.Add(this.radioButtonGastosParc);
            this.Controls.Add(this.listView1);
            this.MaximumSize = new System.Drawing.Size(703, 850);
            this.MinimumSize = new System.Drawing.Size(703, 570);
            this.Name = "ProjecaoDeGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjecaoDeGastos";
            this.Load += new System.EventHandler(this.ProjecaoDeGastos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton radioButtonGastosParc;
        private System.Windows.Forms.RadioButton radioButtonGastosPeri;
        private System.Windows.Forms.ComboBox comboBoxMesProj;
        private System.Windows.Forms.ComboBox comboBoxAnoProj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.Label labelSemana;
        private System.Windows.Forms.DateTimePicker dateTimePickerSemana;
    }
}