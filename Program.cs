using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07Sesara
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int opcao;
            string nome;
            Console.WriteLine("Cadastro de usúarios");
            Console.WriteLine();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1--Cadastrar");
            Console.WriteLine("2--Buscar");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome que deseja cadastrar:");
                nome = Console.ReadLine();
                Console.WriteLine("Nome cadastrado com sucesso!");
                Main(null);
            }
           
            if (opcao == 2)
            {
                Console.WriteLine("Essa opção esta vazia...");
                Main(null);
            }
            else
            {
                Console.WriteLine("Digite a posição que deseja buscar:");
            }








            Console.ReadKey();
        }
    }
}
