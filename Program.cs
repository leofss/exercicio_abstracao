using System;
using System.Collections.Generic;
using exercicio_abstração.Entities;

namespace exercicio_abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte>();

            Console.WriteLine("Quantos contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; n >= i; i++)
            {
                Console.WriteLine($"Contribuinte {i}");
                Console.WriteLine("Nome: ");
                string name = Console.ReadLine();
                Console.WriteLine("Renda anual: ");
                double renda = double.Parse(Console.ReadLine());
                Console.WriteLine("Pessoa Juridia ou fisica (PJ/PF)");
                string pess = (Console.ReadLine());
                if(pess == "PF")
                {
                    Console.WriteLine("Gastos com saúde: ");
                    double gastos = double.Parse(Console.ReadLine());
                    list.Add(new PessoaFisica(gastos, name, renda));
                }
                else if(pess == "PJ")
                {
                    Console.WriteLine("Quantos funcionarios: ");
                    int qtdfunc = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(qtdfunc, name, renda));
                   
                }
            }
            double total = 0;
            Console.WriteLine("");
            Console.WriteLine("Impostos pagos");
            foreach(Contribuinte contribuinte in list)
            {
                double imp = contribuinte.Imposto();
                Console.WriteLine($"{contribuinte.Nome}: ${contribuinte.Imposto()}");
                total += imp;
            }

            Console.WriteLine("");
            Console.WriteLine($"Total de imposto: {total}");
        }
    }
}
