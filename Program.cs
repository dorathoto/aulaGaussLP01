using System.Globalization;

namespace ExemploDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataNiverRespostaUsuario;
            var dataNiverEinsten = new DateTime(1879, 3, 14);

            //aqui vou usar um LOOP para ficar perguntando pro usuário até ele digitar uma data válida
            bool converteu;
            do
            {
                Console.WriteLine("Tente descobrir quando Einstein nasceu, informe dd/mm/aaaa");
                converteu = DateTime.TryParse(Console.ReadLine(), out dataNiverRespostaUsuario);
                //utilizei o TryParse para converter a string digitada pelo usuário em um DateTime
                //já que DateTime.Parse lança uma exceção caso a string não seja convertida
            } while (!converteu);

            //aqui vou comparar se as datas são iguais
            if (dataNiverEinsten == dataNiverRespostaUsuario)
            {
                Console.WriteLine("Parabéns, você acertou!");
            }
            else
            {
                Console.WriteLine("Você errou, tente novamente!");
            }



            //========== Outra forma de fazer
            Console.WriteLine("Tente descobrir quando Einstein nasceu, informe o ano que você acha que ele nasceu");
            var anoNiverRespostaUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Tente descobrir quando Einstein nasceu, informe o mês que você acha que ele nasceu");
            var mesNiverRespostaUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Tente descobrir quando Einstein nasceu, informe o dia que você acha que ele nasceu");
            var diaNiverRespostaUsuario = int.Parse(Console.ReadLine());

            dataNiverRespostaUsuario = new DateTime(anoNiverRespostaUsuario, mesNiverRespostaUsuario, diaNiverRespostaUsuario);
            //aqui vou comparar se as datas são iguais
            if (dataNiverEinsten == dataNiverRespostaUsuario)
            {
                Console.WriteLine("Parabéns, você acertou!");
            }
            else
            {
                Console.WriteLine("Você errou, tente novamente!");
            }

            //Exemplo de como exibir datetime com Culture info
             Console.WriteLine(dataNiverEinsten.ToString("D", new CultureInfo("pt-BR")));
            //opções do ToString para DateTime
            //d = 14/03/1879
            //D = 14 de março de 1879
            //t = 14/03/1879 00:00
            //T = 14/03/1879 00:00:00
            //f = 14/03/1879 00:00:00



            //Exemplo de como exibir Datetime com ToString
            Console.WriteLine(dataNiverEinsten.ToString("dd/MM/yyyy"));
            //dd = dia com 2 dígitos
            //MM = mês com 2 dígitos
            //yyyy = ano com 4 dígitos
            //hh = hora com 2 dígitos
            //HH = hora 24h com 2 dígitos
            //mm = minutos com 2 dígitos
            //ss = segundos com 2 dígitos


            //mais informações
            //https://learn.microsoft.com/pt-br/dotnet/standard/base-types/standard-date-and-time-format-strings
            //e
            //https://learn.microsoft.com/pt-br/dotnet/standard/base-types/custom-date-and-time-format-strings


            //TimeSpan, retorna parte de uma data, por exemplo, quantos dias, horas, minutos, segundos, etc
            TimeSpan diffDatas = dataNiverEinsten - dataNiverRespostaUsuario;
            Console.WriteLine("Você errou as datas por "+ diffDatas.TotalSeconds + " segundos.");
            Console.WriteLine("Você errou as datas por " + diffDatas.TotalDays + " dias.");


        }
    }
}