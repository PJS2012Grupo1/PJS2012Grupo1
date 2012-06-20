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
            this.textBoxDescricaoRegistro = new System.Windows.Forms.TextBox();
            this.textBoxValorRegistro = new System.Windows.Forms.TextBox();
            this.comboBoxCategoriaRegistro = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataVencimentoReg = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataPagamentoReg = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.labelQtdeParcReg = new System.Windows.Forms.Label();
            this.comboBoxQtdeParcelasReg = new System.Windows.Forms.ComboBox();
            this.buttonRegistrarRegistro = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCancelarRegistro = new System.Windows.Forms.Button();
            this.labelCampoPreenchidos = new System.Windows.Forms.Label();
            this.comboBoxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Vencimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data de Pagamento:";
            // 
            // textBoxDescricaoRegistro
            // 
            this.textBoxDescricaoRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescricaoRegistro.Location = new System.Drawing.Point(12, 39);
            this.textBoxDescricaoRegistro.Name = "textBoxDescricaoRegistro";
            this.textBoxDescricaoRegistro.Size = new System.Drawing.Size(268, 20);
            this.textBoxDescricaoRegistro.TabIndex = 1;
            // 
            // textBoxValorRegistro
            // 
            this.textBoxValorRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValorRegistro.Location = new System.Drawing.Point(12, 105);
            this.textBoxValorRegistro.Name = "textBoxValorRegistro";
            this.textBoxValorRegistro.Size = new System.Drawing.Size(99, 20);
            this.textBoxValorRegistro.TabIndex = 3;
            // 
            // comboBoxCategoriaRegistro
            // 
            this.comboBoxCategoriaRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategoriaRegistro.FormattingEnabled = true;
            this.comboBoxCategoriaRegistro.Location = new System.Drawing.Point(306, 39);
            this.comboBoxCategoriaRegistro.Name = "comboBoxCategoriaRegistro";
            this.comboBoxCategoriaRegistro.Size = new System.Drawing.Size(192, 21);
            this.comboBoxCategoriaRegistro.Sorted = true;
            this.comboBoxCategoriaRegistro.TabIndex = 2;
            // 
            // dateTimePickerDataVencimentoReg
            // 
            this.dateTimePickerDataVencimentoReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataVencimentoReg.Location = new System.Drawing.Point(15, 165);
            this.dateTimePickerDataVencimentoReg.Name = "dateTimePickerDataVencimentoReg";
            this.dateTimePickerDataVencimentoReg.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDataVencimentoReg.TabIndex = 9;
            // 
            // dateTimePickerDataPagamentoReg
            // 
            this.dateTimePickerDataPagamentoReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataPagamentoReg.Location = new System.Drawing.Point(199, 165);
            this.dateTimePickerDataPagamentoReg.Name = "dateTimePickerDataPagamentoReg";
            this.dateTimePickerDataPagamentoReg.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDataPagamentoReg.TabIndex = 10;
            this.dateTimePickerDataPagamentoReg.Value = new System.DateTime(2012, 6, 4, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Forma de Pagamento:";
            // 
            // labelQtdeParcReg
            // 
            this.labelQtdeParcReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQtdeParcReg.AutoSize = true;
            this.labelQtdeParcReg.Location = new System.Drawing.Point(374, 91);
            this.labelQtdeParcReg.Name = "labelQtdeParcReg";
            this.labelQtdeParcReg.Size = new System.Drawing.Size(124, 13);
            this.labelQtdeParcReg.TabIndex = 19;
            this.labelQtdeParcReg.Text = "Quantidade de Parcelas:";
            // 
            // comboBoxQtdeParcelasReg
            // 
            this.comboBoxQtdeParcelasReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxQtdeParcelasReg.Enabled = false;
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
            this.comboBoxQtdeParcelasReg.TabIndex = 7;
            this.comboBoxQtdeParcelasReg.Text = "1";
            // 
            // buttonRegistrarRegistro
            // 
            this.buttonRegistrarRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegistrarRegistro.Location = new System.Drawing.Point(239, 203);
            this.buttonRegistrarRegistro.Name = "buttonRegistrarRegistro";
            this.buttonRegistrarRegistro.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrarRegistro.TabIndex = 11;
            this.buttonRegistrarRegistro.Text = "Cadastrar";
            this.buttonRegistrarRegistro.UseVisualStyleBackColor = true;
            this.buttonRegistrarRegistro.Click += new System.EventHandler(this.buttonRegistrarRegistro_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpar.Location = new System.Drawing.Point(331, 203);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 12;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCancelarRegistro
            // 
            this.buttonCancelarRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelarRegistro.Location = new System.Drawing.Point(423, 203);
            this.buttonCancelarRegistro.Name = "buttonCancelarRegistro";
            this.buttonCancelarRegistro.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarRegistro.TabIndex = 13;
            this.buttonCancelarRegistro.Text = "Cancelar";
            this.buttonCancelarRegistro.UseVisualStyleBackColor = true;
            this.buttonCancelarRegistro.Click += new System.EventHandler(this.buttonCancelarRegistro_Click);
            // 
            // labelCampoPreenchidos
            // 
            this.labelCampoPreenchidos.AutoSize = true;
            this.labelCampoPreenchidos.Location = new System.Drawing.Point(12, 212);
            this.labelCampoPreenchidos.Name = "labelCampoPreenchidos";
            this.labelCampoPreenchidos.Size = new System.Drawing.Size(0, 13);
            this.labelCampoPreenchidos.TabIndex = 20;
            this.labelCampoPreenchidos.Visible = false;
            // 
            // comboBoxFormaPagamento
            // 
            this.comboBoxFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFormaPagamento.FormattingEnabled = true;
            this.comboBoxFormaPagamento.Items.AddRange(new object[] {
            "Á vista",
            "Parcelado",
            "Recorrente"});
            this.comboBoxFormaPagamento.Location = new System.Drawing.Point(176, 107);
            this.comboBoxFormaPagamento.Name = "comboBoxFormaPagamento";
            this.comboBoxFormaPagamento.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFormaPagamento.TabIndex = 21;
            this.comboBoxFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormaPagamento_SelectedIndexChanged);
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 241);
            this.Controls.Add(this.comboBoxFormaPagamento);
            this.Controls.Add(this.labelCampoPreenchidos);
            this.Controls.Add(this.buttonCancelarRegistro);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonRegistrarRegistro);
            this.Controls.Add(this.comboBoxQtdeParcelasReg);
            this.Controls.Add(this.labelQtdeParcReg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDataPagamentoReg);
            this.Controls.Add(this.dateTimePickerDataVencimentoReg);
            this.Controls.Add(this.comboBoxCategoriaRegistro);
            this.Controls.Add(this.textBoxValorRegistro);
            this.Controls.Add(this.textBoxDescricaoRegistro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 300);
            this.MinimumSize = new System.Drawing.Size(530, 279);
            this.Name = "Registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Registros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDescricaoRegistro;
        private System.Windows.Forms.TextBox textBoxValorRegistro;
        private System.Windows.Forms.ComboBox comboBoxCategoriaRegistro;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataVencimentoReg;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataPagamentoReg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelQtdeParcReg;
        private System.Windows.Forms.ComboBox comboBoxQtdeParcelasReg;
        private System.Windows.Forms.Button buttonRegistrarRegistro;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCancelarRegistro;
        private System.Windows.Forms.Label labelCampoPreenchidos;
        private System.Windows.Forms.ComboBox comboBoxFormaPagamento;
    }
}