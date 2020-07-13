using System;

namespace FilaCircular
{
    class Principal
    {
        static void Main(string[] args)
        {
            String fraseCompleta = "I wish I was dry but at least I'm alive. rain on me";
            FilaCircular f = new FilaCircular(20); 

            int indiceDoPonto = 0;
            for (int i = 0; i < fraseCompleta.Length; ++i)
            {
                if (fraseCompleta[i] == '.')
                {
                    indiceDoPonto = i;
                    break;
                }
                else
                {
                    indiceDoPonto = fraseCompleta.Length;
                }
            }

            char[] c = new char[indiceDoPonto];
            for (int i = 0; i < indiceDoPonto; ++i)
            {
                c[i] = fraseCompleta[i];
            }

            String fraseResumida = new String(c);
            String[] fraseSplit = fraseResumida.Split(" ");

            int x = 0;


            while (x < fraseSplit.Length)
            {
                c = fraseSplit[x].ToCharArray();

                for (int i = 0; i < c.Length; i++)
                {
                    f.push(c[i]);
                }

                for (int i = 0; i < c.Length; i++)
                {
                    Console.Write(f.pop());
                }

                Console.Write(" ");
                x++;
            }
        }
    }
}
