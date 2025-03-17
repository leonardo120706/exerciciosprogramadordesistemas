using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maioroumenorquedez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            DialogResult soma = MessageBox.Show("Voce quer saber se e maior ou menor que 10?",
                                                  "Titulo aqui",
                                                  MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Information);
            if (int.TryParse(textBox1.Text, out int valor))
            {
                if (valor > 10)
                {
                    MessageBox.Show("O valor é maior que 10", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O valor é menor que 10", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
