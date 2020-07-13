using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PilhaFila
{
    class Exercicio03
    {
        public void Exercicio()
        {
            Console.Clear();

            String sequencia = ("123456"); // Define a sequência

            Console.Write("Sequência A: ");
            Pilha pilha = new Pilha(6);

            pilha.push(sequencia[0]); // Adiciona 1 à pilha
            pilha.push(sequencia[1]); // Adiciona 2 à pilha
            pilha.push(sequencia[2]); // Adiciona 3 à pilha

            Console.Write(pilha.pop()); // Retira 3 da pilha
            Console.Write(pilha.pop()); // Retira 2 da pilha

            pilha.push(sequencia[3]); // Adiciona 4 à pilha
            pilha.push(sequencia[4]); // Adiciona 5 à pilha

            Console.Write(pilha.pop()); // Retira 5 da pilha

            pilha.push(sequencia[5]); // Adiciona 6 à pilha

            Console.Write(pilha.pop());     // Retira 6 da pilha
            Console.Write(pilha.pop());     // Retira 4 da pilha
            Console.WriteLine(pilha.pop()); // Retira 1 da pilha


            Console.Write("Sequência B: ");
            Fila fila = new Fila(6);

            for (int i = 0; i < 6; i++)
            {
                fila.push(sequencia[i]); // Adiciona toda a sequência à fila
            }

            Console.Write(fila.pop()); // Retira 1 da fila

            pilha.push(sequencia[0]); // Adiciona 1 à pilha
            pilha.push(sequencia[1]); // Adiciona 2 à pilha
            pilha.push(sequencia[2]); // Adiciona 3 à pilha
            pilha.push(sequencia[3]); // Adiciona 4 à pilha
            pilha.push(sequencia[4]); // Adiciona 5 à pilha

            Console.Write(pilha.pop()); // Retira 5 da pilha
            Console.Write(pilha.pop()); // Retira 4 da pilha

            pilha.push(sequencia[5]); // Adiciona 6 à pilha

            Console.Write(pilha.pop());          // Retira 6 da pilha
            Console.Write(fila.pop());           // Retira 2 da fila
            Console.WriteLine(fila.pop()+"\n");  // Retira 3 da fila
        }
    }
}
