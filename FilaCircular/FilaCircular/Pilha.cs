using System;
using System.Collections.Generic;
using System.Text;

namespace FilaCircular
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
                Console.WriteLine("Pilha cheia!");
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
                Console.WriteLine("Pilha vazia!");
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
