using System;
using System.Collections.Generic;
using System.Text;

namespace PilhaFila
{
    class Exercicio04
    {
        public void Exercicio()
        {
            Console.Clear();

            String sequenciaBase, sequenciaFinal, comando;
            Console.Write("Sequência Base: ");
            sequenciaBase = Console.ReadLine();
            Console.Write("Sequência Final: ");
            sequenciaFinal = Console.ReadLine();
            Console.Write("Sequência de Comandos: ");
            comando = Console.ReadLine();

            int aux = 0, sequenciaBasePosicao = 0, sequenciaNovaPosicao = 0;
            char[] sequenciaNovaChar = new char[sequenciaFinal.Length];
            Pilha pilha = new Pilha(comando.Length);

            while(aux < comando.Length)
            {
                if(comando[aux].Equals('I') || comando[aux].Equals('i'))
                {
                    pilha.push(sequenciaBase[sequenciaBasePosicao]);
                    sequenciaBasePosicao++;

                }
                else if (comando[aux].Equals('R') || comando[aux].Equals('r'))
                {
                    sequenciaNovaChar[sequenciaNovaPosicao] = pilha.pop();
                    sequenciaNovaPosicao++;
                }
                else
                {
                    Console.WriteLine("Comando inválido. Insira somente I ou R.\n");
                    return;
                }
                aux++;
            }

            String sequenciaNova = new String(sequenciaNovaChar);

            if (sequenciaNova == sequenciaFinal)
            {
                Console.WriteLine("\nO resultado dos comandos é igual à sequência final.\n");
            }
            else
            {
                Console.WriteLine("\nO resultado dos comandos não é igual à sequência final.\n");
            }
        }
    }
}
