using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace ArvoreBinaria
{
    class Bnode
    {
        private int x;
        private Bnode esq, dir;

        public Bnode(int v)
        {
            x = v;
            esq = dir = null;
        }

        public void setX(int v)
        {
            x = v;
        }

        public int getX()
        {
            return x;
        }

        public void setEsq(Bnode n)
        {
            esq = n;
        }

        public Bnode getEsq()
        {
            return esq;
        }

        public void setDir(Bnode n)
        {
            dir = n;
        }

        public Bnode getDir()
        {
            return dir;
        }

        public void add(int v)
        {
            if (v > x)
            { // v deve ir para o lado direito
                if (dir != null)
                {
                    dir.add(v);
                }
                else
                {
                    dir = new Bnode(v);
                }
            }
            else
            {  // v deve ir para o lado esquerdo
                if (esq != null)
                {
                    esq.add(v);
                }
                else
                {
                    esq = new Bnode(v);
                }
            }
        }

        public void show()
        {
            if (esq != null) esq.show();
            Console.WriteLine(x + " "); // exibe nó pelo caminhamento central
            if (dir != null) dir.show();
        }

        public int size()
        {
            int e = 0, d = 0;
            if (esq != null) e = esq.size(); // guarda qtd de nos do lado esquerdo
            if (dir != null) d = dir.size(); // guarda qtd de nos do lado direito
            return 1 + e + d;
        }

        public int altura()
        {
            int e = 0, d = 0;
            if (esq != null) e = esq.altura(); // guarda qtd de nos do lado esquerdo
            if (dir != null) d = dir.altura(); // guarda qtd de nos do lado direito
            return 1 + ((e > d) ? e : d);
        }

        public void showFolhas()
        {
            if (esq != null) esq.showFolhas();
            if (esq == null && dir == null) Console.WriteLine(x + " "); // exibe nó folha
            if (dir != null) dir.showFolhas();
        }

        public int soma()
        {
            int e = 0, d = 0;
            if (esq != null) e = esq.soma(); // guarda soma dos nos do lado esquerdo
            if (dir != null) d = dir.soma(); // guarda soma dos nos do lado direito
            return x + e + d;
        }

        public void menores(int v)
        {
            if (esq != null) esq.menores(v);
            if (x < v) Console.WriteLine(x + " "); // exibe nós menores que o inserido
            if (dir != null) dir.menores(v);
        }

        public int maiorValor()
        {
            if (dir == null) return x;
            if (dir != null) return dir.maiorValor(); // caminha até a extrema-direita da árvore
            else return 0;
        }

        public int menorValor()
        {
            if (esq == null) return x;
            if (esq != null) return esq.menorValor(); // caminha até a extrema-esquerda da árvore
            else return 0;
        }

        public int quantFolhas()
        {
            if (esq == null && dir == null) return 1; // se for nó folha retorna valor 1
            if (esq == null) return dir.quantFolhas();
            if (dir == null) return esq.quantFolhas();
            return dir.quantFolhas() + esq.quantFolhas(); // soma retornos
        }

        public Boolean busca(int v)
        {
            if (v == x) return true; 
            if (v < x && esq != null) return esq.busca(v); // se for menor e não nulo caminhe à esquerda
            if (v > x && dir != null) return dir.busca(v); // se for menor e não nulo caminhe à direita
            else return false;
        }
    }
}
