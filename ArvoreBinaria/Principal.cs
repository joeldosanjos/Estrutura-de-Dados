using System;

namespace ArvoreBinaria
{
    class Principal
    {
        static void Main(string[] args)
        {
            Btree b = new Btree();

            b.add(2);
            b.add(7);
            b.add(2);
            b.add(6);
            b.add(5);
            b.add(11);
            b.add(5);
            b.add(9);
            b.add(4);

            Console.WriteLine("Árvore: ");
            b.show();
            Console.WriteLine("\n-----\n");

            Console.WriteLine("Quantidade de nós: " + b.size());
            Console.WriteLine("Altura dos nós: " + b.altura());
            Console.WriteLine("Soma dos nós: " + b.soma());
            Console.WriteLine("Média dos nós: " + b.media());

            Console.WriteLine("\n-----\n");

            Console.WriteLine("Resultado da busca: " + b.busca(15));
            Console.WriteLine("Resultado da busca: " + b.busca(19));
            Console.WriteLine("Resultado da busca: " + b.busca(42));
            Console.WriteLine("Resultado da busca: " + b.busca(12));
            Console.WriteLine("Resultado da busca: " + b.busca(51));
            Console.WriteLine("Resultado da busca: " + b.busca(8));

            Console.WriteLine("\n-----\n");

            Console.WriteLine("Nós menores que 10:");
            b.menores(10);

            Console.WriteLine("\n-----\n");

            Console.WriteLine("Maior nó da árvore: "+ b.maiorValor());
            Console.WriteLine("Menor nó da árvore: " + b.menorValor());

            Console.WriteLine("\n-----\n");

            Console.WriteLine("Nós folhas:");
            b.showFolhas();

            Console.WriteLine("\n-----\n");

            Console.WriteLine("Quantidade de nós folhas: " + b.quantFolhas());
        }
    }
}
