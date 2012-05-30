namespace WindowsFormsApplication1
{
    partial class Registros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDescricaoRegistro = new System.Windows.Forms.TextBox();
            this.textBoxValorRegistro = new System.Windows.Forms.TextBox();
            this.comboBoxCategoriaRegistro = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataCadastroReg = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataVencimentoReg = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataPagamentoReg = new System.Windows.Forms.DateTimePicker();
            this.radioButtonPagamentoAvistaReg = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonPagamentoParceladoReg = new System.Windows.Forms.RadioButton();
            this.radioButtonPagamentoRecorrenteReg = new System.Windows.Forms.RadioButton();
            this.labelQtdeParcReg = new System.Windows.Forms.Label();
            this.comboBoxQtdeParcelasReg = new System.Windows.Forms.ComboBox();
            this.buttonRegistrarRegistro = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCancelarRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Vencimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data de Pagamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Data de Cadastro:";
            // 
            // textBoxDescricaoRegistro
            // 
            this.textBoxDescricaoRegistro.Location = new System.Drawing.Point(12, 39);
            this.textBoxDescricaoRegistro.Name = "textBoxDescricaoRegistro";
            this.textBoxDescricaoRegistro.Size = new System.Drawing.Size(296, 20);
            this.textBoxDescricaoRegistro.TabIndex = 9;
            // 
            // textBoxValorRegistro
            // 
            this.textBoxValorRegistro.Location = new System.Drawing.Point(12, 105);
            this.textBoxValorRegistro.Name = "textBoxValorRegistro";
            this.textBoxValorRegistro.Size = new System.Drawing.Size(99, 20);
            this.textBoxValorRegistro.TabIndex = 10;
            // 
            // comboBoxCategoriaRegistro
            // 
            this.comboBoxCategoriaRegistro.FormattingEnabled = true;
            this.comboBoxCategoriaRegistro.Location = new System.Drawing.Point(331, 39);
            this.comboBoxCategoriaRegistro.Name = "comboBoxCategoriaRegistro";
            this.comboBoxCategoriaRegistro.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCategoriaRegistro.TabIndex = 11;
            // 
            // dateTimePickerDataCadastroReg
            // 
            this.dateTimePickerDataCadastroReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataCadastroReg.Location = new System.Drawing.Point(12, 167);
            this.dateTimePickerDataCadastroReg.Name = "dateTimePickerDataCadastroReg";
            this.dateTimePickerDataCadastroReg.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDataCadastroReg.TabIndex = 12;
            // 
            // dateTimePickerDataVencimentoReg
            // 
            this.dateTimePickerDataVencimentoReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataVencimentoReg.Location = new System.Drawing.Point(193, 167);
            this.dateTimePickerDataVencimentoReg.Name = "dateTimePickerDataVencimentoReg";
            this.dateTimePickerDataVencimentoReg.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDataVencimentoReg.TabIndex = 13;
            // 
            // dateTimePickerDataPagamentoReg
            // 
            this.dateTimePickerDataPagamentoReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataPagamentoReg.Location = new System.Drawing.Point(377, 167);
            this.dateTimePickerDataPagamentoReg.Name = "dateTimePickerDataPagamentoReg";
            this.dateTimePickerDataPagamentoReg.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDataPagamentoReg.TabIndex = 14;
            // 
            // radioButtonPagamentoAvistaReg
            // 
            this.radioButtonPagamentoAvistaReg.AutoSize = true;
            this.radioButtonPagamentoAvistaReg.Location = new System.Drawing.Point(138, 105);
            this.radioButtonPagamentoAvistaReg.Name = "radioButtonPagamentoAvistaReg";
            this.radioButtonPagamentoAvistaReg.Size = new System.Drawing.Size(58, 17);
            this.radioButtonPagamentoAvistaReg.TabIndex = 15;
            this.radioButtonPagamentoAvistaReg.TabStop = true;
            this.radioButtonPagamentoAvistaReg.Text = "Á Vista";
            this.radioButtonPagamentoAvistaReg.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Forma de Pagamento:";
            // 
            // radioButtonPagamentoParceladoReg
            // 
            this.radioButtonPagamentoParceladoReg.AutoSize = true;
            this.radioButtonPagamentoParceladoReg.Location = new System.Drawing.Point(286, 106);
            this.radioButtonPagamentoParceladoReg.Name = "radioButtonPagamentoParceladoReg";
            this.radioButtonPagamentoParceladoReg.Size = new System.Drawing.Size(73, 17);
            this.radioButtonPagamentoParceladoReg.TabIndex = 17;
            this.radioButtonPagamentoParceladoReg.TabStop = true;
            this.radioButtonPagamentoParceladoReg.Text = "Parcelado";
            this.radioButtonPagamentoParceladoReg.UseVisualStyleBackColor = true;
            this.radioButtonPagamentoParceladoReg.CheckedChanged += new System.EventHandler(this.radioButtonPagamentoParceladoReg_CheckedChanged);
            // 
            // radioButtonPagamentoRecorrenteReg
            // 
            this.radioButtonPagamentoRecorrenteReg.AutoSize = true;
            this.radioButtonPagamentoRecorrenteReg.Location = new System.Drawing.Point(202, 105);
            this.radioButtonPagamentoRecorrenteReg.Name = "radioButtonPagamentoRecorrenteReg";
            this.radioButtonPagamentoRecorrenteReg.Size = new System.Drawing.Size(78, 17);
            this.radioButtonPagamentoRecorrenteReg.TabIndex = 18;
            this.radioButtonPagamentoRecorrenteReg.TabStop = true;
            this.radioButtonPagamentoRecorrenteReg.Text = "Recorrente";
            this.radioButtonPagamentoRecorrenteReg.UseVisualStyleBackColor = true;
            // 
            // labelQtdeParcReg
            // 
            this.labelQtdeParcReg.AutoSize = true;
            this.labelQtdeParcReg.Location = new System.Drawing.Point(374, 91);
            this.labelQtdeParcReg.Name = "labelQtdeParcReg";
            this.labelQtdeParcReg.Size = new System.Drawing.Size(124, 13);
            this.labelQtdeParcReg.TabIndex = 19;
            this.labelQtdeParcReg.Text = "Quantidade de Parcelas:";
            // 
            // comboBoxQtdeParcelasReg
            // 
            this.comboBoxQtdeParcelasReg.FormattingEnabled = true;
            this.comboBoxQtdeParcelasReg.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "24",
            "36",
            "48",
            "60",
            "72"});
            this.comboBoxQtdeParcelasReg.Location = new System.Drawing.Point(377, 107);
            this.comboBoxQtdeParcelasReg.Name = "comboBoxQtdeParcelasReg";
            this.comboBoxQtdeParcelasReg.Size = new System.Drawing.Size(54, 21);
            this.comboBoxQtdeParcelasReg.TabIndex = 20;
            // 
            // buttonRegistrarRegistro
            // 
            this.buttonRegistrarRegistro.Location = new System.Drawing.Point(239, 213);
            this.buttonRegistrarRegistro.Name = "buttonRegistrarRegistro";
            this.buttonRegistrarRegistro.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrarRegistro.TabIndex = 21;
            this.buttonRegistrarRegistro.Text = "Cadastrar";
            this.buttonRegistrarRegistro.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(331, 213);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 22;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCancelarRegistro
            // 
            this.buttonCancelarRegistro.Location = new System.Drawing.Point(423, 213);
            this.buttonCancelarRegistro.Name = "buttonCancelarRegistro";
            this.buttonCancelarRegistro.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarRegistro.TabIndex = 23;
            this.buttonCancelarRegistro.Text = "Cancelar";
            this.buttonCancelarRegistro.UseVisualStyleBackColor = true;
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 248);
            this.Controls.Add(this.buttonCancelarRegistro);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonRegistrarRegistro);
            this.Controls.Add(this.comboBoxQtdeParcelasReg);
            this.Controls.Add(this.labelQtdeParcReg);
            this.Controls.Add(this.radioButtonPagamentoRecorrenteReg);
            this.Controls.Add(this.radioButtonPagamentoParceladoReg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonPagamentoAvistaReg);
            this.Controls.Add(this.dateTimePickerDataPagamentoReg);
            this.Controls.Add(this.dateTimePickerDataVencimentoReg);
            this.Controls.Add(this.dateTimePickerDataCadastroReg);
            this.Controls.Add(this.comboBoxCategoriaRegistro);
            this.Controls.Add(this.textBoxValorRegistro);
            this.Controls.Add(this.textBoxDescricaoRegistro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Registros";
            this.Text = "Registros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDescricaoRegistro;
        private System.Windows.Forms.TextBox textBoxValorRegistro;
        private System.Windows.Forms.ComboBox comboBoxCategoriaRegistro;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataCadastroReg;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataVencimentoReg;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataPagamentoReg;
        private System.Windows.Forms.RadioButton radioButtonPagamentoAvistaReg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonPagamentoParceladoReg;
        private System.Windows.Forms.RadioButton radioButtonPagamentoRecorrenteReg;
        private System.Windows.Forms.Label labelQtdeParcReg;
        private System.Windows.Forms.ComboBox comboBoxQtdeParcelasReg;
        private System.Windows.Forms.Button buttonRegistrarRegistro;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCancelarRegistro;
    }
}