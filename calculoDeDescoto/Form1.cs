using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculoDeDescoto
{
    public partial class frmcalculodesconto : Form
    {
        public frmcalculodesconto()
        {
            InitializeComponent();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            CalcularResultado();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            CalcularResultado();
        }
        private void CalcularResultado()
        {
            if (!string.IsNullOrWhiteSpace(txtValor.Text) &&
            !string.IsNullOrWhiteSpace(txtDesconto.Text))
            {
                // Converter os textos para números
                decimal valor1 = Convert.ToDecimal(txtValor.Text);
                decimal valor2 = Convert.ToDecimal(txtDesconto.Text);

                decimal valorDesconto = (valor1 * valor2) / 100;
                decimal valorFinal = valor1 - valorDesconto;

                // Exibir o resultado no Label
                lblTotalDaCompra.Text = $"Desconto: R$ {valorDesconto:F2}% \nValor Final: R$ {valorFinal:F2}";
            }
            else
            {
                // Limpar o label se algum campo estiver vazio
                lblTotalDaCompra.Text = string.Empty;
            }
        }
    }
}
