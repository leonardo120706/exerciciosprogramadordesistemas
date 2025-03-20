
namespace calculoDeDescoto
{
    partial class frmcalculodesconto
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescontoPorcentagem = new System.Windows.Forms.Label();
            this.lblValorDaCompra = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblTotalDaCompra = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(200, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE CALCULO DE DESCONTO";
            // 
            // lblDescontoPorcentagem
            // 
            this.lblDescontoPorcentagem.AutoSize = true;
            this.lblDescontoPorcentagem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoPorcentagem.ForeColor = System.Drawing.Color.White;
            this.lblDescontoPorcentagem.Location = new System.Drawing.Point(22, 231);
            this.lblDescontoPorcentagem.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescontoPorcentagem.Name = "lblDescontoPorcentagem";
            this.lblDescontoPorcentagem.Size = new System.Drawing.Size(379, 22);
            this.lblDescontoPorcentagem.TabIndex = 1;
            this.lblDescontoPorcentagem.Text = "Insira o desconto (considerar que 10 significa10%):";
            // 
            // lblValorDaCompra
            // 
            this.lblValorDaCompra.AutoSize = true;
            this.lblValorDaCompra.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaCompra.ForeColor = System.Drawing.Color.White;
            this.lblValorDaCompra.Location = new System.Drawing.Point(26, 188);
            this.lblValorDaCompra.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValorDaCompra.Name = "lblValorDaCompra";
            this.lblValorDaCompra.Size = new System.Drawing.Size(194, 22);
            this.lblValorDaCompra.TabIndex = 2;
            this.lblValorDaCompra.Text = "Insira o valor da compra:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.ForeColor = System.Drawing.Color.Black;
            this.lblresultado.Location = new System.Drawing.Point(22, 305);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(356, 26);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "Resultado da compra com desconto R$";
            // 
            // lblTotalDaCompra
            // 
            this.lblTotalDaCompra.AutoSize = true;
            this.lblTotalDaCompra.Location = new System.Drawing.Point(390, 305);
            this.lblTotalDaCompra.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalDaCompra.Name = "lblTotalDaCompra";
            this.lblTotalDaCompra.Size = new System.Drawing.Size(20, 24);
            this.lblTotalDaCompra.TabIndex = 5;
            this.lblTotalDaCompra.Text = "0";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(221, 183);
            this.txtValor.Margin = new System.Windows.Forms.Padding(6);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(180, 29);
            this.txtValor.TabIndex = 6;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(413, 229);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(6);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(180, 29);
            this.txtDesconto.TabIndex = 7;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // frmcalculodesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(956, 395);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblTotalDaCompra);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblValorDaCompra);
            this.Controls.Add(this.lblDescontoPorcentagem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmcalculodesconto";
            this.Text = "Sistema de Calculo de Desconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescontoPorcentagem;
        private System.Windows.Forms.Label lblValorDaCompra;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblTotalDaCompra;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDesconto;
    }
}

