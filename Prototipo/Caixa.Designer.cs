﻿namespace WindowsFormsApplication1
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
            this.textBoxDescricaoCaixa = new System.Windows.Forms.TextBox();
            this.textBoxValorCaixa = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategoriaCaixa = new System.Windows.Forms.ComboBox();
            this.labelCampoPreenchimento = new System.Windows.Forms.Label();
            this.checkBoxRecorrente = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // textBoxDescricaoCaixa
            // 
            this.textBoxDescricaoCaixa.Location = new System.Drawing.Point(12, 39);
            this.textBoxDescricaoCaixa.Name = "textBoxDescricaoCaixa";
            this.textBoxDescricaoCaixa.Size = new System.Drawing.Size(406, 20);
            this.textBoxDescricaoCaixa.TabIndex = 1;
            // 
            // textBoxValorCaixa
            // 
            this.textBoxValorCaixa.Location = new System.Drawing.Point(12, 95);
            this.textBoxValorCaixa.Name = "textBoxValorCaixa";
            this.textBoxValorCaixa.Size = new System.Drawing.Size(121, 20);
            this.textBoxValorCaixa.TabIndex = 2;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(206, 137);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 5;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(292, 137);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 23);
            this.Limpar.TabIndex = 6;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categoria";
            // 
            // comboBoxCategoriaCaixa
            // 
            this.comboBoxCategoriaCaixa.FormattingEnabled = true;
            this.comboBoxCategoriaCaixa.Location = new System.Drawing.Point(276, 94);
            this.comboBoxCategoriaCaixa.Name = "comboBoxCategoriaCaixa";
            this.comboBoxCategoriaCaixa.Size = new System.Drawing.Size(177, 21);
            this.comboBoxCategoriaCaixa.TabIndex = 4;
            // 
            // labelCampoPreenchimento
            // 
            this.labelCampoPreenchimento.AutoSize = true;
            this.labelCampoPreenchimento.Location = new System.Drawing.Point(12, 129);
            this.labelCampoPreenchimento.Name = "labelCampoPreenchimento";
            this.labelCampoPreenchimento.Size = new System.Drawing.Size(0, 13);
            this.labelCampoPreenchimento.TabIndex = 12;
            this.labelCampoPreenchimento.Visible = false;
            // 
            // checkBoxRecorrente
            // 
            this.checkBoxRecorrente.AutoSize = true;
            this.checkBoxRecorrente.Location = new System.Drawing.Point(164, 97);
            this.checkBoxRecorrente.Name = "checkBoxRecorrente";
            this.checkBoxRecorrente.Size = new System.Drawing.Size(79, 17);
            this.checkBoxRecorrente.TabIndex = 3;
            this.checkBoxRecorrente.Text = "Recorrente";
            this.checkBoxRecorrente.UseVisualStyleBackColor = true;
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 172);
            this.Controls.Add(this.checkBoxRecorrente);
            this.Controls.Add(this.labelCampoPreenchimento);
            this.Controls.Add(this.comboBoxCategoriaCaixa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textBoxValorCaixa);
            this.Controls.Add(this.textBoxDescricaoCaixa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(473, 206);
            this.MinimumSize = new System.Drawing.Size(473, 206);
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.Caixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescricaoCaixa;
        private System.Windows.Forms.TextBox textBoxValorCaixa;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategoriaCaixa;
        private System.Windows.Forms.Label labelCampoPreenchimento;
        private System.Windows.Forms.CheckBox checkBoxRecorrente;
    }
}