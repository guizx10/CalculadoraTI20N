﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


        public string Tabuada()
        {
            string resultado = "";

            resultado += "\nTabuada de " + ConsultarNum1;
            for (int i=0; i <= 10; i++ )
            {
                resultado += "\n" + ConsultarNum1 + " * " + i + " = " + (ConsultarNum1* i);
              
            }//fim do for


            resultado += "\n\nTabuada de " + ConsultarNum2;
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n " + ConsultarNum2 + " * " + i + " = " + (ConsultarNum2 * i);

            }//fim do for

            return resultado; 
                
        }//fim do método Tabuada

        public string Raiz()
        {
            string resultado = "";

            resultado = "A raiz de " + ConsultarNum1 + " é: " + Math.Sqrt(ConsultarNum1) +
                        "\nA raiz de " + ConsultarNum2 + " é: " + Math.Sqrt(ConsultarNum2);

            return resultado; 
        }//fim do Raiz 

        public double Potencia()
        {
            return Math.Pow(ConsultarNum1, ConsultarNum2); 

        }//fim do Método Potencia 


    }//fim da Classe
}//fim do projeto
