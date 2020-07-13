using System;
using System.Linq;

namespace PilhaFila
{
    class Principal
    {
        static void Main()
        {
            int opcao = 1;
            while (opcao != 0)
            {
                Console.WriteLine("Escolha um exercício para executar");
                Console.WriteLine("\nExercícios 1, 2, 3 ou 4");
                Console.WriteLine("0 para sair");
                Console.Write("\nOpção: ");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        Exercicio01 ex1 = new Exercicio01();
                        ex1.Exercicio();
                    break;
                    case 2:
                        Exercicio02 ex2 = new Exercicio02();
                        ex2.Exercicio();
                        break;
                    case 3:
                        Exercicio03 ex3 = new Exercicio03();
                        ex3.Exercicio();
                        break;
                    case 4:
                        Exercicio04 ex4 = new Exercicio04();
                        ex4.Exercicio();
                        break;
                    case 0:
                        Environment.Exit(0);
                    break;
                    default:
                        Console.WriteLine("Comando inválido");
                    break;
                }
            }
        }
    }
}
