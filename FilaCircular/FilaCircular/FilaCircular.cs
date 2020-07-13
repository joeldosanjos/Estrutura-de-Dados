using System;
using System.Collections.Generic;
using System.Text;

namespace FilaCircular
{
    class FilaCircular
    {
        private char[] vetor;
        private int inicio, fim;
        private Pilha p;

        public FilaCircular(int tam)
        {
            vetor = new char[tam];
            inicio = fim = -1; // fila vazia
            p = new Pilha(tam);
        }

        public void push(char valor)
        {
            int novoFim = chamarNovoFim();

            if (novoFim != inicio)
            {
                vetor[novoFim] = valor;
                p.push(vetor[novoFim]); // Chama o método push de Pilha()

                if (inicio != -1)
                    fim = novoFim;
                else
                    inicio = fim = novoFim;
            }
            else Console.WriteLine("Fila Cheia!");
        }

        public char pop()
        {

            if (inicio != -1)
            {
                if (inicio != fim)
                {
                    inicio = inicio + 1;
                    if (inicio == vetor.Length)
                        inicio = 0;
                }
                else
                {
                    inicio = fim = -1;
                }
                return p.pop(); // Retorna chamando o método pop de Pilha()
            }
            else
            {
                Console.WriteLine("Fila Vazia!");
                return ' ';
            }
        }

        private int chamarNovoFim()
        {
            int novoFim = fim + 1;

            if (novoFim == vetor.Length)
            {
                novoFim = 0;
            }

            return novoFim;
        }

        public Boolean isFull()
        {
            int novoFim = chamarNovoFim();

            return (inicio == novoFim);
        }

        public Boolean isEmpty()
        {
            return (fim == -1);
        }

        public void status()
        {
            Console.WriteLine("Tam = " + vetor.Length +
                               " Inicio: " + (inicio + 1) + " Fim: " + (fim + 1));
            for (int i = 0; i < vetor.Length; i++)
                Console.Write(vetor[i]);
            Console.WriteLine();
        }
    }
}
