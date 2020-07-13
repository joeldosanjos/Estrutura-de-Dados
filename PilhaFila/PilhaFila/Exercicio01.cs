using System;
using System.Collections.Generic;
using System.Text;

namespace PilhaFila
{
    class Exercicio01
    {
        public void Exercicio()
        {
            Console.Clear();

            Console.Write("Insira uma frase: ");
            String frase = Console.ReadLine(); // Lê a frase

            Pilha p = new Pilha(frase.Length);
            Fila f = new Fila(frase.Length);
            int aux = 0;

            foreach (char c in frase)
            {
                if (c.Equals(' ') || c.Equals(',') || c.Equals('.') || c.Equals(':') || c.Equals('-')) {}
                else
                {
                    p.push(c);
                    f.push(c);
                    // Envia à fila e pilha somente letras do alfabeto
                }
            }

            char[] pilhaC = new char[frase.Length];
            char[] filaC = new char[frase.Length];

            while (!p.isEmpty() && !f.isEmpty())
            {
                pilhaC[aux] = p.pop();
                filaC[aux] = f.pop();
                aux++;
                // Retorna as frases em ordem normal e invertida
            }

            String novaFrase = new String(filaC);
            String novaFraseInvertida = new String(pilhaC);

            // Compara as duas frases
            if (novaFrase == novaFraseInvertida)
            {
                Console.WriteLine("É um palíndromo\n");
            }
            else
            {
                Console.WriteLine("Não é um palíndromo\n");
            } 
        }
    }
}
