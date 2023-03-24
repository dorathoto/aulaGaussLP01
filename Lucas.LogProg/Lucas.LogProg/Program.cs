using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lucas.LogProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha; //redudancia definir um inteiro e colocar valor zero

            do
            {
                Console.WriteLine("Escolha o exercicio");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("1 - Média       2- fibonacci");
                Console.Write("Digite apenas o número 1 ou 2 para escolher um dos problemas: ");
                var converteu = int.TryParse(Console.ReadLine(), out escolha);
                //toda vez que tiver que converter algo e não sabe se vai vir número, utilize TryParse, pois não irá quebrar o código caso o usuário digite letras.
                //variavel converteu recebe true/false se conseguiu converter, a saida é no out
            } while (escolha != 1 && escolha != 2);

            if (escolha == 1)
            {
                FuncMedia();
            }
            else
            {
                FuncFibonacci();
            }
            Console.ReadKey();
        }

        private static void FuncFibonacci()
        {
            int soma = 0;
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("Fibonacci");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.Write("Deseja ir até que número ? ");
            _ = int.TryParse(Console.ReadLine(), out int N); //declarei e usei aqui a variavel N, e não mais no começo...
            for (int sub = 0; soma <= N;)
            {
                sub = soma - sub;

                //Console.Write(soma + " ");
                Console.Write($"{soma} "); //mesma coisa q linha de cima, só que nova interpolação

                //soma = soma + sub;
                soma += sub; //mesma coisa que a linha de cima

                if (soma == 0)
                {
                    sub++;
                    soma++;
                }
            }
        }

        private static void FuncMedia()
        {
            double media;
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("Problema calculo de media de um aluno");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.Write("Digite a primeira nota: ");
            _ = double.TryParse(Console.ReadLine(), out double nota1);
            //aqui uso o discards _ ou seja, falo pra função TryParse q vou ignorar o retorno
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.Write("Digite a segunda nota: ");
            _ = double.TryParse(Console.ReadLine(), out double nota2);
            media = (nota1 + nota2) / 2;


            //aqui vou fazer a nova forma de interpolar string com $".....{variavel}" mais moderna e não precisamos colocar o ToString
            if (media > 5)
            {
                Console.WriteLine($"Sua média final foi: {media.ToString("F2", CultureInfo.InvariantCulture)}\nParabéns você passou de ano");
            }
            else
            {
                //melhor forma de fazer o ToString(F2)
                Console.WriteLine($"Sua média final foi: {media:F2}\ninfelizmente não passou de ano");
            }
        }
    }
}
