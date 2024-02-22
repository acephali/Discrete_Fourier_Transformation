using System;
using System.Collections.Generic;

namespace algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 3;
            //Complex[] f = new Complex[N] { new Complex(52 / 4, 0), new Complex(-28 / 4, 0), new Complex(12 / 4, 0), new Complex(32 / 4, 0) }; // example for 4 elements
            Complex[] f = new Complex[N] { new Complex(-81 / 3, 0), new Complex(27 / 3, 0), new Complex(3 / 3, 0) };
            Complex[] F = new Complex[N];

            List<int> k_l_szorzatok = new List<int>();
            List<Complex> W = new List<Complex>();
            Dictionary<int, Complex> W_dict = new Dictionary<int, Complex>();

            for (int i = 0; i < f.Length; i++)
            {
                for (int j = 0; j < F.Length; j++)
                {
                    if (!k_l_szorzatok.Contains(-i * j))
                    {
                        k_l_szorzatok.Add(-i * j);
                    }
                }
            }

            foreach (var item in k_l_szorzatok)
            {
                int degree = 360 / f.Length * item;
                W.Add(new Complex(degree));
            }

            for (int i = 0; i < k_l_szorzatok.Count; i++)
            {
                W_dict.Add(k_l_szorzatok[i], W[i]);
            }

            for (int i = 0; i < F.Length; i++)
            {
                Complex szorzatOsszeg = new Complex(0, 0);
                for (int j = 0; j < f.Length; j++)
                {
                    int szorzat = -i * j;
                    Complex szorzando = W_dict[szorzat];
                    szorzatOsszeg += f[j] * szorzando;
                }
                F[i] = szorzatOsszeg;
            }

            foreach (var item in F)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
