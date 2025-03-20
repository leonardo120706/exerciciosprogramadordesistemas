
namespace calculadora
{
    partial class frmcalculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(45, 13);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(210, 20);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(99, 248);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(48, 53);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnDois
            // 
            this.btnDois.Location = new System.Drawing.Point(99, 193);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(48, 49);
            this.btnDois.TabIndex = 2;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(153, 193);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(48, 49);
            this.btnTres.TabIndex = 3;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(45, 193);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(48, 49);
            this.btnUm.TabIndex = 4;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Location = new System.Drawing.Point(45, 139);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(48, 48);
            this.btnQuatro.TabIndex = 5;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(99, 137);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(48, 50);
            this.btnCinco.TabIndex = 6;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(153, 137);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(48, 50);
            this.btnSeis.TabIndex = 7;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnSete
            // 
            this.btnSete.Location = new System.Drawing.Point(45, 81);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(48, 50);
            this.btnSete.TabIndex = 8;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnOito
            // 
            this.btnOito.Location = new System.Drawing.Point(99, 81);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(48, 50);
            this.btnOito.TabIndex = 9;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnNove
            // 
            this.btnNove.Location = new System.Drawing.Point(153, 81);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(48, 50);
            this.btnNove.TabIndex = 10;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(45, 248);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(48, 53);
            this.btnVirgula.TabIndex = 11;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(153, 248);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(48, 53);
            this.btnIgual.TabIndex = 12;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(207, 137);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(48, 48);
            this.btnMultiplicacao.TabIndex = 13;
            this.btnMultiplicacao.Text = "x";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(207, 81);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(48, 50);
            this.btnDivisao.TabIndex = 14;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.Location = new System.Drawing.Point(207, 248);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(48, 53);
            this.btnAdicao.TabIndex = 15;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(207, 193);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(48, 51);
            this.btnSubtracao.TabIndex = 16;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(207, 45);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(48, 30);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "c";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(58, 13);
            this.lblOperacao.Name = "label1";
            this.lblOperacao.Size = new System.Drawing.Size(0, 13);
            this.lblOperacao.TabIndex = 18;
            // 
            // frmcalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 327);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.txtResultado);
            this.Name = "frmcalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblOperacao;
    }
}

