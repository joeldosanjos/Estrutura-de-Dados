using System;
using System.Collections.Generic;
using System.Text;

namespace PilhaFila
{
    public class Fila
    {
        private char[] vetor;
        private int fim;
        private Pilha p;

        public Fila(int tam)
        {
            vetor = new char[tam];
            fim = -1;
            p = new Pilha(tam);
        }

        public void push (char valor)
        {
            if (fim == vetor.Length - 1)
            {
                Console.WriteLine("\nFila Cheia!\n");
            }
            else
            {
                fim++;
                vetor[fim] = valor;
            }
        }

        public char pop()
        {
            char aux = vetor[0];
            if (fim >= 0)
            {
                for (int i = 0; i < fim; i++)
                {
                    vetor[i] = vetor[i + 1];
                }
                fim--;
                return aux;
            }
            else
            {
                Console.WriteLine("\nFila Vazia!\n");
                return ' ';
            }
        }

        public Boolean isFull()
        {
            return (fim == vetor.Length - 1);
        }
        public Boolean isEmpty()
        {
            return (fim == -1);
        }
    }
}
