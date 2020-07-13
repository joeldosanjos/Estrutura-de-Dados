using System;

namespace Recursividade
{
    class Recursividade
    {
        private static void Binario(int N)
        {
            if (N > 1)
            {
                Binario(N / 2); // imprimir o binário de N/2
                Console.Write(N % 2);
            }
            else
                Console.Write(N);
        }
        private static void Hanoi(int N, char Orig, char Dest, char Temp)
        {
            if (N > 1)
            {
                Hanoi(N - 1, Orig, Temp, Dest);
                Console.WriteLine("Mover o anel " + N + " do pino " + Orig + " para o pino " + Dest);
                Hanoi(N - 1, Temp, Dest, Orig);
            }
            else
            {
                Console.WriteLine("Mover o anel " + N + " do pino " + Orig + " para o pino " + Dest);
            }
        }
        private static int Misterio(int a, int b)
        {
            if (b == 1) return a;
            else return a + Misterio(a, b - 1);
        } // Ex 1
        private static int Soma(int n)
        {
            if (n == 0) return 0;
            else return n + Soma(n-1);
        } // Ex 2
        private static int Potencia(int Base, int Expoente)
        {
            if (Expoente > 0) return Base * (Potencia(Base, Expoente - 1));
            else return 1;
        } // Ex 3
        private static int SomaSimplesWhile(int a, int b)
        {
            if (a >= 0 && b >= 0)
            {
                while (a != 0)
                {
                    b++;
                    a--;
                }
                return b;
            }
            else return 0;
        } // Ex 4.1
        private static int SomaSimplesRecursiva(int a, int b)
        {
            if (a >= 0 && b >= 0)
            {
                if (b > 1) a = SomaSimplesRecursiva(a, b - 1);
                return a + 1;
            }
            else return 0;
        } // Ex 4.2 
        private static int ff(int n)
        {
            if (n == 1) return 1;
            if (n % 2 == 0) return ff(n / 2);
            return ff((n - 1) / 2) + ff((n + 1) / 2);
        } // Ex 5
        private static int fusc(int n, int profund)
        {
            int i;
            for (i = 0; i < profund; i++)
                Console.Write("...");
                Console.WriteLine(fusc(n , profund));
                if (n == 1) return 1;
                if (n % 2 == 0) return fusc(n / 2, profund + 1);
                return fusc((n - 1) / 2, profund + 1) + fusc((n + 1) / 2, profund + 1);
        } // Ex 6
        private static int h(int m, int n)
        {
            if (n == 1) return m + 1;
            else if (m == 1) return n + 1;
            else return h(m,n - 1) + h(m - 1, n);
        } // Ex 7
        private static int MDC(int x, int y)
        {
            if (x == y) return x;
            else if (x > y) return MDC(x - y, y);
            else return MDC(y, x);
        } // Ex 8
        private static int exercicio9(int n, int x)
        {
            if (n == 0) return x;
            else return exercicio9(n - 1, x + 10);
        } // Ex 9
        private static int exercicio10(int n)
        {
            if (n != 0)
            {
                if (n % 2 != 0) return n + exercicio10(n - 1);
                else return exercicio10(n - 1);
            }
            else return 0;
        } // Ex 10
        private static int MOD(int n, int m)
        {
            if (n >= m) return MOD(n-m, m);
            else return n;
        } // Ex 11
        private static void hexadecimal(int n)
        {
            if (n > 0)
            {
                hexadecimal(n / 16);
                Console.Write(hexadecimalVerificador(n % 16));
            }

        } // Ex 12
        private static char hexadecimalVerificador(int n)
        {
            if (n == 0) return '0';
            else if (n == 1) return '1';
            else if (n == 2) return '2';
            else if (n == 3) return '3';
            else if (n == 4) return '4';
            else if (n == 5) return '5';
            else if (n == 6) return '6';
            else if (n == 7) return '7';
            else if (n == 8) return '8';
            else if (n == 9) return '9';
            else if (n == 10) return 'A';
            else if (n == 11) return 'B';
            else if (n == 12) return 'C';
            else if (n == 13) return 'D';
            else if (n == 14) return 'E';
            else if (n == 15) return 'F';
            else return '-';
        } // Ex 12 Aux
        private static int F(int x)
        {
            if (x % 3 == 0) return x * x;
            else if (x % 3 == 1) return x + 3;
            else if (x % 3 == 2) return x!;
            else return -9999999;
        } // Ex 13
        private static int puzzle(int baseh, int limit)
        { 
            if (baseh > limit) return -1;
            else if (baseh == limit) return 1;
            else return baseh * puzzle(baseh + 1, limit);
        } // Ex 14
        private static double sum(double n)
        {
            if (n > 1) return sum(n - 1) + (1 / n);
            else return n + 1;
        } // Ex 15
        private static double s(double n)
        {
            if (n > 1)
            {
                if (n % 2 != 0) return s(n - 1) + (1 / n); // ímpar
                else return s(n - 1) - (1 / n); // par
            }
            else
            {
                return n - 1;
            }
        } // Ex 16
        private static int F2(int N)
        {
            if (N < 4) return 3 * N;
            else return 2 * F(N - 4) + 5;
        } // Ex 17
        private static void OrdenacaoInsercao(int[] vetor, int n)
        {
            if (n <= 1) return;

            OrdenacaoInsercao(vetor, n - 1);

            int ultimo = vetor[n - 1];
            int penultimo = n - 2;

            while (penultimo >= 0 && vetor[penultimo] > ultimo)
            {
                vetor[penultimo + 1] = vetor[penultimo];
                penultimo--;
            }
            vetor[penultimo + 1] = ultimo;
        } // Ex 18

        static void Main()
        {
            // Input function here
        }
    }
}
