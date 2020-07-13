using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    class Btree
    {
        private Bnode raiz;

        public Btree()
        {
            raiz = null;
        }

        public void add(int v)
        {
            if (raiz != null)
            {
                raiz.add(v);
            }
            else
            {
                raiz = new Bnode(v);
            }
        }

        public void show()
        {
            if (raiz != null)
            {
                raiz.show();
            }
        }

        public int size()
        {
            if (raiz != null)
            {
                return raiz.size();
            }
            else return 0;
        }

        public int altura()
        {
            if (raiz != null)
            {
                return raiz.altura();
            }
            else return 0;
        }

        public void showFolhas()
        {
            if (raiz != null)
            {
                raiz.showFolhas();
            }
        }

        public int soma()
        {
            if (raiz != null)
            {
                return raiz.soma();
            }
            else return 0;
        }

        public float media()
        {
            if (raiz != null)
            {
                return (float)raiz.soma() / raiz.size();
            }
            else return 0;
        }

        public void menores(int v)
        {
            if (raiz != null)
            {
                raiz.menores(v);
            }
        }
        public int maiorValor()
        {
            if (raiz != null)
            {
                return raiz.maiorValor();
            }
            else return 0;
        }

        public int menorValor()
        {
            if (raiz != null)
            {
                return raiz.menorValor();
            }
            else return 0;
        }

        public int quantFolhas()
        {
            if (raiz != null)
            {
                return raiz.quantFolhas();
            }
            else return 0;
        }

         public Boolean busca(int v)
        {
            if (raiz != null)
            {
                return raiz.busca(v); 
            }
             else return false;
        }
    }
}
