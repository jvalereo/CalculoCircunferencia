using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula14, Calculer a area da Circunferencia , tipo double
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo double

            double pi, raio, area;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Digite o valor do pi: ");
            pi = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            //Declarando a variavel area


            area = Math.Pow(raio, 2.0) * pi; 


            //imprimir saida de dados no console,método WhriteLine, concatenação

            Console.WriteLine("O valor da area: " +  area.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Teste de novo!!!");

            // saida da aplicação console, método Readkey, Retorna o valor da tecla pressionada


            Console.ReadKey();

            //Fim do programa

        }
    }
}
