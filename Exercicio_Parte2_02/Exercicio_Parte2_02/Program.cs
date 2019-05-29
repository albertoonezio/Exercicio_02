using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Parte2_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int cigarroDia = 0;
            double anosFumou = 0;
            double valorCarteira = 0;
            int CarteiraCigarroTotal = 20;
            int cigarroAvulso = 0;
            double quantidadeCarteiraCigarro = 0;
            double resultadoTotal = 0;

            Console.Write("Informe a quantidade de anos que fuma: ");
            anosFumou = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de cigarros fumados diariamente: ");
            cigarroDia = int.Parse(Console.ReadLine());

            Console.Write("Informe o preço da carteira: ");
            valorCarteira = double.Parse(Console.ReadLine());

            quantidadeCarteiraCigarro = ((anosFumou * 365) * cigarroDia) / CarteiraCigarroTotal;
            cigarroAvulso = Convert.ToInt32(((anosFumou * 365) * cigarroDia) % CarteiraCigarroTotal);

            if (cigarroAvulso > 0)
            {
                quantidadeCarteiraCigarro += 1;
            }

            resultadoTotal = quantidadeCarteiraCigarro * valorCarteira;

            Console.WriteLine("Custo total dos cigarros fumados: {0}", resultadoTotal);
        }
    }
}
