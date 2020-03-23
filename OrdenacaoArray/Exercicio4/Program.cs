using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[15];
            Random randomNum = new Random();

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = randomNum.Next(1, 100);
            }

            ImprimirValores(valores);

            bool ordenar = true;

            while (ordenar)
            {
                ordenar = false;
                for (int i = 0; i < valores.Length; i++)
                {
                    if (i != valores.Length - 1)
                    {
                        if (valores[i] > valores[i + 1])
                        {
                            int aux = valores[i];
                            valores[i] = valores[i + 1];
                            valores[i + 1] = aux;
                            ordenar = true;
                        }
                    }
                }
            }

            ImprimirValores(valores);
        }

        static void ImprimirValores(int[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write(" " + valores[i]);
            }
            Console.WriteLine("");
        }
    }
}
