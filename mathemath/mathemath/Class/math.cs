using System;
using System.Collections.Generic;
using System.Text;

namespace mathemath
{
   public class math
    {
        /*Utilizando o mesmo projeto, crie uma classe chamada “Math”. Esta classe deverá conter dois
        métodos, um que será responsável por fazer a divisão de dois números decimais (Número A /
        Número B) e um outro método que será responsável por fazer a multiplicação de dois números
        decimais (Número A * Número B). Além dos métodos a classe “Math” deverá conter um
        construtor, este construtor deverá receber dois números decimais como parâmetro.*/

        private double n1 { get; set; }
        public double n2 { get; set; }
        public double result1, result2;

        //contrutor da classe Math
        public math(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public math(double n2)
        {
            this.n2 = n2;
        }

        public math()
        {
        }

        public double divisao(double n1, double n2)
        {
            result1 = n1 / n2;
            return result1;
        }

        public double multiplicacao(double n1, double n2)
        {
            result2 = n1 * n2;
            return result2;
        }
    }
}

