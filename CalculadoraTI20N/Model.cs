using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
    internal class Model
    {
        //Área de variáveis

        private double num1;
        private double num2;

        //Método Construtor = Instancia as Variáveis 
        public Model ()
        {
            ConsultarNum1 = 0;
            num2 = 0;
        }//fim do Construtor

        //Métods GET E SET
        public double ConsultarNum1
        {

            get { return num1;}
            set { num1 = value; }
        }//fim do get e set

        public double ConsultarNum2
        {

            get { return num2;  }
            set { num2 = value; }
        }//fim do get e set


        public double Somar()
        {
           
            return ConsultarNum1 + ConsultarNum2;
        }//fim do somar

        public double Subtrair()
        {  
            return ConsultarNum1 + ConsultarNum2;
        }//fim do método subtrair

        public double Multiplicar()
        {

            return ConsultarNum1 + ConsultarNum2;
        }//fim multiplicar


        public double Dividir()
        {
            if(ConsultarNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return ConsultarNum1 / ConsultarNum2;

            }
        }//fim dividir





    }//fim da Classe
}//fim do projeto
