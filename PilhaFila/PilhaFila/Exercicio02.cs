using System;
using System.Collections.Generic;
using System.Text;

namespace PilhaFila
{
    class Exercicio02
    {
        public void Exercicio()
        {
            Console.Clear();

            Console.Write("Insira uma expressão matemática: ");
            String expressaoMatematica = Console.ReadLine(); // Lê a expressão matemática

            int aux = 0;
            int aberto = 0, fechado = 0;

            while (aux < expressaoMatematica.Length)
            {
                // Caso haja parênteses abertos, some 1 em aberto
                if (expressaoMatematica[aux].Equals('(') ||
                    expressaoMatematica[aux].Equals('{') ||
                    expressaoMatematica[aux].Equals('['))
                {
                    aberto++;
                }
                // Caso haja parênteses fechados, some 1 em fechado
                else if (expressaoMatematica[aux].Equals(')') ||
                         expressaoMatematica[aux].Equals('}') ||
                         expressaoMatematica[aux].Equals(']'))
                {
                    fechado++;

                    // Caso o número de fechado seja maior que aberto,
                    // encerre a varredura
                    if (fechado > aberto)
                    {
                        break;
                    }
                }
                aux++;
            }

            // Se o número das variáveis forem semelhantes, a expressão está correta.
            if (aberto == fechado)
            {
                Console.WriteLine("\nEstá correta em relação aos parênteses.\n");
            }
            else
            {
                Console.WriteLine("\nNão está correta em relação aos parênteses.\n");
            }
        }
    }
}
