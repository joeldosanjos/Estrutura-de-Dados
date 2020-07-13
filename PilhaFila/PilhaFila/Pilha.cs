using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PilhaFila
{
    class Pilha
    {
        private char[] vetor;
        private int topo;

        public Pilha(int tam)
        {
            vetor = new char[tam];
            topo = -1;
        }

        public void push(char valor)
        {
            if (topo == vetor.Length - 1)
            {
                Console.WriteLine("\nPilha cheia!\n");
            }
            else
            {
                topo++;
                vetor[topo] = valor;
            }
        }

        public char pop()
        {
            int aux = topo;
            if (topo >= 0)
            {
                topo--;
                return vetor[aux];
            }
            else
            {
                Console.WriteLine("\nPilha vazia!\n");
                return ' ';
            }

        }

        public Boolean isFull()
        {
            return (topo == vetor.Length - 1);
        }
        public Boolean isEmpty()
        {
            return (topo == -1);
        }
    }
}
