namespace Atividade
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValorVendasTotal = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtValorCarro = new System.Windows.Forms.TextBox();
            this.lblVendasTotal = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblValorPorCarro = new System.Windows.Forms.Label();
            this.lblComissao = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtSalarioFinal = new System.Windows.Forms.TextBox();
            this.txtCincoPorcento = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorVendasTotal
            // 
            this.txtValorVendasTotal.Location = new System.Drawing.Point(386, 152);
            this.txtValorVendasTotal.Name = "txtValorVendasTotal";
            this.txtValorVendasTotal.Size = new System.Drawing.Size(151, 20);
            this.txtValorVendasTotal.TabIndex = 1;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(386, 183);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(151, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // txtValorCarro
            // 
            this.txtValorCarro.Location = new System.Drawing.Point(386, 221);
            this.txtValorCarro.Name = "txtValorCarro";
            this.txtValorCarro.Size = new System.Drawing.Size(151, 20);
            this.txtValorCarro.TabIndex = 3;
            this.txtValorCarro.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblVendasTotal
            // 
            this.lblVendasTotal.AutoSize = true;
            this.lblVendasTotal.Location = new System.Drawing.Point(196, 152);
            this.lblVendasTotal.Name = "lblVendasTotal";
            this.lblVendasTotal.Size = new System.Drawing.Size(171, 13);
            this.lblVendasTotal.TabIndex = 5;
            this.lblVendasTotal.Text = "Insira o valor total de suas vendas:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(196, 186);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(137, 13);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Insira o valor do salário fixo:";
            this.lblSalario.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblValorPorCarro
            // 
            this.lblValorPorCarro.AutoSize = true;
            this.lblValorPorCarro.Location = new System.Drawing.Point(196, 224);
            this.lblValorPorCarro.Name = "lblValorPorCarro";
            this.lblValorPorCarro.Size = new System.Drawing.Size(138, 13);
            this.lblValorPorCarro.TabIndex = 7;
            this.lblValorPorCarro.Text = "Insira o valor total por carro:";
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Location = new System.Drawing.Point(196, 259);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(132, 13);
            this.lblComissao.TabIndex = 9;
            this.lblComissao.Text = "Insira o valor da comissão:";
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(386, 256);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(151, 20);
            this.txtComissao.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(332, 390);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(332, 361);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtSalarioFinal
            // 
            this.txtSalarioFinal.Location = new System.Drawing.Point(321, 296);
            this.txtSalarioFinal.Name = "txtSalarioFinal";
            this.txtSalarioFinal.ReadOnly = true;
            this.txtSalarioFinal.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioFinal.TabIndex = 12;
            // 
            // txtCincoPorcento
            // 
            this.txtCincoPorcento.Location = new System.Drawing.Point(321, 322);
            this.txtCincoPorcento.Name = "txtCincoPorcento";
            this.txtCincoPorcento.ReadOnly = true;
            this.txtCincoPorcento.Size = new System.Drawing.Size(100, 20);
            this.txtCincoPorcento.TabIndex = 13;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(696, 406);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtCincoPorcento);
            this.Controls.Add(this.txtSalarioFinal);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblComissao);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.lblValorPorCarro);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblVendasTotal);
            this.Controls.Add(this.txtValorCarro);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtValorVendasTotal);
            this.Name = "Form1";
            this.Text = "Calculo de salário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValorVendasTotal;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtValorCarro;
        private System.Windows.Forms.Label lblVendasTotal;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblValorPorCarro;
        private System.Windows.Forms.Label lblComissao;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtSalarioFinal;
        private System.Windows.Forms.TextBox txtCincoPorcento;
        private System.Windows.Forms.Button btnSair;
    }
}

