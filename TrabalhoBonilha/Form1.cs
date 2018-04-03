using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoBonilha
{
    public partial class Form1 : Form
    {
        /*
            Cria variaveis Double e int em publico e estatico
            para poder modificar por toda classe sem a necessidade
            de criar variavel a cada metodo;
         */
        public static double ValorFinal, ValorPrimario, ValorSecundario;
        public static int Operacao, x = 0;


        public Form1()
        {
            InitializeComponent();
        }

        //NUMEROS NO LABEL
        private void Bt0_Click(object sender, EventArgs e)
        {
            LbValor.Text += "0";
        }
        //Adiciona o numero 0
        private void Bt1_Click(object sender, EventArgs e)
        {
            LbValor.Text += "1";
        }
        //Adiciona o numero 1 na label
        private void Bt2_Click(object sender, EventArgs e)
        {
            LbValor.Text += "2";
        }
        //Adiciona o numero 2
        private void Bt3_Click(object sender, EventArgs e)
        {
            LbValor.Text += "3";
        }
        //Adiciona o numero 3
        private void Bt4_Click(object sender, EventArgs e)
        {
            LbValor.Text += "4";
        }
        //Adiciona o numero 4
        private void Bt5_Click(object sender, EventArgs e)
        {
            LbValor.Text += "5";
        }
        //Adiciona o numero 5
        private void Bt6_Click(object sender, EventArgs e)
        {
            LbValor.Text += "6";
        }
        //Adiciona o numero 6
        private void Bt7_Click(object sender, EventArgs e)
        {
            LbValor.Text += "7";
        }
        //Adiciona o numero 7
        private void Bt8_Click(object sender, EventArgs e)
        {
            LbValor.Text += "8";
        }
        //Adiciona o numero 8
        private void BtMaisMenos_Click(object sender, EventArgs e)
        {
            LbValor.Text = "-" +LbValor.Text;
        }
        //Adiciona o numero 9
        private void Bt9_Click(object sender, EventArgs e)
        {
            LbValor.Text += "9";
        }
        //Adiciona Virgula
        private void BtVirgula_Click(object sender, EventArgs e)
        {
            LbValor.Text += ",";
        }
        //Adiciona 
        private void BtPi_Click(object sender, EventArgs e)
        {
            LbValor.Text += "3,14159265359";
        }
        //Limpa o conteudo
        private void BtClean_Click(object sender, EventArgs e)
        {
            LbValor.Text = "";
            ValorPrimario = 0;
            ValorSecundario = 0;
        }
        //Botao soma que adiciona o valorPrimario e salva a operacao 1
        private void BtMais_Click(object sender, EventArgs e)
        {
            ValorPrimario = double.Parse(LbValor.Text);
            LbValor.Text = "";
            Operacao = 1;
        }
        //Botao subtracao que adiciona o valorPrimario e salva a operacao 2
        private void BtMenos_Click(object sender, EventArgs e)
        {
            ValorPrimario = double.Parse(LbValor.Text);
            LbValor.Text = "";
            Operacao = 2;
        }
        //Botao Vezes que adiciona o valorPrimario e salva a operacao 3
        private void BtVezes_Click(object sender, EventArgs e)
        {
            ValorPrimario = double.Parse(LbValor.Text);
            LbValor.Text = "";
            Operacao = 3;
        }
        //Botao Divisao que adiciona o valorPrimario e salva a operacao 4
        private void BtDivisao_Click(object sender, EventArgs e)
        {
            
            ValorPrimario = double.Parse(LbValor.Text);
            LbValor.Text = "";
            Operacao = 4;
        }

        

        //apresenta as respostas realizando as contas
        private void BtIgual_Click(object sender, EventArgs e)
        {
             
            ValorSecundario = double.Parse(LbValor.Text);
            
            switch (Operacao)
            {
                case 1:
                    //Soma
                    ValorFinal = ValorPrimario + ValorSecundario;
                    LbValor.Text = ValorFinal.ToString();
                break;
                case 2:
                    //Subtracao
                    ValorFinal = ValorPrimario - ValorSecundario;
                    LbValor.Text = ValorFinal.ToString();

                    break;
                case 3:
                    //Multiplicacao
                    ValorFinal = ValorPrimario * ValorSecundario;
                    LbValor.Text = ValorFinal.ToString();
                    break;
                case 4:
                    //Divisao
                    if(ValorSecundario <= 0)
                    {
                        LbValor.Text = "Nao existe resposta";
                    }
                    else
                    {

                        ValorFinal = ValorPrimario / ValorSecundario;
                        LbValor.Text = ValorFinal.ToString();

                    }
                    break;

                    
            }
        }

       

        //Converte em Tangente
        private void BtSin_Click(object sender, EventArgs e)
        {
            double Resposta, Valor;
            Valor = double.Parse(LbValor.Text);
            Resposta = Convert.ToSingle(Math.Sin(Valor));
            LbValor.Text = Resposta.ToString();
        }
        //Converte em Cosseno
        private void BtCo_Click(object sender, EventArgs e)
        {
            double Resposta, Valor;
            Valor = double.Parse(LbValor.Text);
            Resposta = Convert.ToSingle(Math.Cos(Valor));
            LbValor.Text = Resposta.ToString();
        }
        //Converte para tangente
        private void BtTa_Click(object sender, EventArgs e)
        {
            double Resposta, Valor;
            Valor = double.Parse(LbValor.Text);
            Resposta = Convert.ToSingle(Math.Tan(Valor));
            LbValor.Text = Resposta.ToString();
        }
        //Fracao, 1 dividido pelo valor
        private void BtFracao_Click(object sender, EventArgs e)
        {
            double resultado;

            if(ValorSecundario == 0) { 
            ValorPrimario = double.Parse(LbValor.Text);
            resultado = 1 / ValorPrimario;
            LbValor.Text = resultado.ToString();
            }
            else
            {
            ValorSecundario = double.Parse(LbValor.Text);
            resultado = 1 / ValorSecundario;
            LbValor.Text = resultado.ToString();
            }
        }
        //Graus Pra Radianos
        private void BtGBarraR_Click(object sender, EventArgs e)
        {
            double resposta;
            resposta = double.Parse(LbValor.Text);
            resposta = resposta * 0.0174533;
            LbValor.Text = resposta.ToString();
        }
        //valor ao quadrado
        private void BtX_Click(object sender, EventArgs e)
        {
            double resposta;
            resposta = int.Parse(LbValor.Text);
            resposta = resposta * resposta;
            LbValor.Text = resposta.ToString();
        }

        //Radianos pra graus
        private void BtRBarraG_Click(object sender, EventArgs e)
        {
            double resposta;
            resposta = double.Parse(LbValor.Text);
            resposta = resposta * 57.2958;
            LbValor.Text = resposta.ToString();
        }
        //Porcentagem
        private void BtPorc_Click(object sender, EventArgs e)
        {
         
            ValorSecundario = double.Parse(LbValor.Text);
            double Resposta;
            // Soma
            if (Operacao == 1)
            { 
                Resposta = ValorPrimario * (ValorSecundario/100);
                Resposta = Resposta + ValorPrimario;
                LbValor.Text = Resposta.ToString();
            }
            // Subtracao
            if (Operacao == 2)
            {
                Resposta = ValorPrimario * (ValorSecundario / 100);
                Resposta = Resposta - ValorPrimario;
                LbValor.Text = Resposta.ToString();
            }
            // Multiplicacao
            if (Operacao == 3)
            {
                Resposta = ValorPrimario * (ValorSecundario / 100);
                Resposta = Resposta * ValorPrimario;
                LbValor.Text = Resposta.ToString();
            }
            //Divisao
            if (Operacao == 4)
            {
                Resposta = ValorPrimario * (ValorSecundario / 100);
                Resposta = Resposta / ValorPrimario;
                LbValor.Text = Resposta.ToString();
            }

        }
        //Raiz Quadrada
        private void BtRaiz_Click(object sender, EventArgs e)
        {
            double Resposta, Valor;
            Valor = double.Parse(LbValor.Text);
            Resposta = Convert.ToSingle(Math.Sqrt(Valor));
            LbValor.Text = Resposta.ToString();
        }
    }
}
