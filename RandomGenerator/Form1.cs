using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class Form1 : Form
    {
        int contagemAcima = 0;
        int contagemTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            lista.Items.Clear();

            for (int num = 0; num < 10; num++)
            {
                int resultado = aleatorio.Next(0, 200);
                lista.Items.Add(resultado);
                                                   
            }
            lista.Items.Add("==========");

        }
        private void btnAlfabeto_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            for (int m = 0; m < 10; m++)
            {               
                lista.Items.Add(codigo());
            }
            lista.Items.Add("==========");
        }
        private string codigo(int qtd = 10)
        {
            StringBuilder str = new StringBuilder();
            
            string chars = "ABCDEFGHIJKLMNOPEQRSTUXYZabcdefghijklmnopqrstuxyz";

            Random random = new Random();

            for (int v = 0; v < qtd; v++)
            {
                

                int x = random.Next(chars.Length);
                str.Append(chars[x]);               
            }

            return str.ToString();
        }
        private void Code()
        {
            Random random = new Random();            

            for (int i = 0; i < 10; i++)
            {
                
                int numeroAleatorio = random.Next(1, 101);
                if (numeroAleatorio > 50)
                {
                    lista.Items.Add(numeroAleatorio.ToString());
                    contagemAcima += 1;
                    //label1.Text = contagemAcima.ToString();
                    
                }
                else if (numeroAleatorio == 100)
                {
                    MessageBox.Show("BINGO");
                }
                else
                    lista.Items.Add("Abaixo de 50");

                
                
            }
            label1.Text = contagemTotal++.ToString();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Code();
            lista.Items.Add("===========");
            label3.Text = contagemAcima.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            contagemAcima = 0;
            contagemTotal= 0;
            label1.Text =contagemTotal.ToString();
            label3.Text=contagemAcima.ToString();
        }
    }
}
