using System;
using System.Collections.Generic;
using mathemath.Class;

namespace mathemath
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancias
            util uc = new util();
            math mc = new math();

            //Variaveis
            int i = 0;
            long l = 0;
            double d, n1, n2, resultadod, resultadom = 0;
            string s = "";
            bool b = false;

            /*Utilizando o projeto console criado no passo 1 implemente 5 variáveis dos seguintes tipos: Int,
           long, double, string e bool.Atribua valores a cada uma delas.Imprima as mesmas variáveis, na
           sequência em que foram implementadas, utilizando o Console.WriteLine(), garanta que a
           impressão ocorre de duas formas diferentes, uma utilizando o operador “$” e o outro utilizando
           o operador “+”, antes da impressão do valor da variável sempre considerar a frase “O valor da
           variável é: ” .*/

            uc.cwl($"Atribua Valor a variavel int: ");
            i = Convert.ToInt32(Console.ReadLine());
            uc.cwl("o Valor int que você digitou é: " + i);

            uc.cwl($"Atribua Valor a variavel long: ");
            l = Convert.ToInt32(Console.ReadLine());
            uc.cwl("o Valor long que você digitou é: " + l);

            uc.cwl($"Atribua Valor a variavel double: ");
            d = Convert.ToDouble(Console.ReadLine());
            uc.cwl("o Valor double que você digitou é: " + d);

            uc.cwl($"Atribua Valor a variavel string: ");
            s = Console.ReadLine();
            uc.cwl("o Valor string que você digitou é: " + s);

            uc.cwl($"Atribua Valor a variavel boolean (Dica, digita Verdadeiro): ");
            if (Console.ReadLine() == "Verdadeiro")
            {
                b = true;
                uc.cwl("Sua condição digitada foi verdadeira: " + b);
            }
            else
            {
                uc.cwl("Valor invalido!");
            }

            /*Utilizando o mesmo projeto crie uma variável que armazena uma lista de strings, atribua à lista
           criada 3 valores (elementos). Imprima todos os elementos da lista utilizando o método
           Console.WriteLine() e o operador “$”, garanta que a seguinte frase seja adicionada antes de cada
           impressão da lista: “O valor da variável da lista de strings é: ”.*/

            //Lita de string
            int c = 0;
            List<string> lista = new List<string>();
            lista.Add("Matheus");
            lista.Add("Alves");
            lista.Add("Bonotto");
            lista.Add("Santos");

            do
            {
                Console.WriteLine($"O valor da varíavel {c + 1} da lista de strings é: {lista[c]}");
                c++;
            } while (c <= 3);

            Console.WriteLine();

            /*Utilizando o mesmo projeto, intancie a classe Math na classe Main uti lizando o construtor.
       Execute os dois métodos disponíveis na classe Math com números decimais de sua escolha,
       imprima o resultado no console.
        */

            math mt = new math();
            uc.cwl($"Atribua o primeiro valor para dividir: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            uc.cwl($"Atribua o segundo valor para divisão: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            resultadod = mt.divisao(n1, n2);
            Console.WriteLine($"O resultado da divisão é: {resultadod}");


            uc.cwl($"Atribua o primeiro valor para multiplicar: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            uc.cwl($"Atribua o segundo valor para multiplicação: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            resultadom = mt.multiplicacao(n1, n2);
            Console.WriteLine($"O resultado da multiplicação é: {resultadom}");

            Console.ReadKey();

            mathheranca math2 = new mathheranca(2.5, 2.5);

            //imprimindo o resutlado das contas com os valores aleatorios da MathHeranca
            Console.WriteLine($"O valor da soma da classe Herdada é: {math2.Soma(2.5, 5):F}");


        }
    }
}
