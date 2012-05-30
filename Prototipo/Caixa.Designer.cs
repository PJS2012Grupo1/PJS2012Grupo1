namespace WindowsFormsApplication1
{
    partial class Caixa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescricaoCaixa = new System.Windows.Forms.TextBox();
            this.textBoxValorCaixa = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataEntradaCaixa = new System.Windows.Forms.DateTimePicker();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Entrada";
            // 
            // textBoxDescricaoCaixa
            // 
            this.textBoxDescricaoCaixa.Location = new System.Drawing.Point(25, 39);
            this.textBoxDescricaoCaixa.Name = "textBoxDescricaoCaixa";
            this.textBoxDescricaoCaixa.Size = new System.Drawing.Size(371, 20);
            this.textBoxDescricaoCaixa.TabIndex = 5;
            // 
            // textBoxValorCaixa
            // 
            this.textBoxValorCaixa.Location = new System.Drawing.Point(25, 107);
            this.textBoxValorCaixa.Name = "textBoxValorCaixa";
            this.textBoxValorCaixa.Size = new System.Drawing.Size(99, 20);
            this.textBoxValorCaixa.TabIndex = 6;
            // 
            // dateTimePickerDataEntradaCaixa
            // 
            this.dateTimePickerDataEntradaCaixa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataEntradaCaixa.Location = new System.Drawing.Point(167, 107);
            this.dateTimePickerDataEntradaCaixa.Name = "dateTimePickerDataEntradaCaixa";
            this.dateTimePickerDataEntradaCaixa.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDataEntradaCaixa.TabIndex = 7;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(139, 154);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 8;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(230, 154);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 23);
            this.Limpar.TabIndex = 9;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 189);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.dateTimePickerDataEntradaCaixa);
            this.Controls.Add(this.textBoxValorCaixa);
            this.Controls.Add(this.textBoxDescricaoCaixa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Caixa";
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.Caixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescricaoCaixa;
        private System.Windows.Forms.TextBox textBoxValorCaixa;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataEntradaCaixa;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button button1;
    }
}