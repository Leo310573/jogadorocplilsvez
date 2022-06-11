using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogadorocplilsvez
{
    internal class Program

    {	
			public static void Main()
			{
            int oc, p, li, ls, vez;

            li = 1;
            ls = 100;
            vez = 1;

            do
            {
                Console.WriteLine("Jogador neutro, digite um número entre 1 e 100");
                oc = int.Parse(Console.ReadLine());
            } while (oc <= li || oc >= ls);

            do
            {
                do
                {
                    Console.WriteLine($"Jogador {vez}, digite nº entre {li} e {ls}");
                    p = int.Parse(Console.ReadLine());
                } while (p <= li || p >= ls);
                
                if (p == oc)
                {
                    Console.WriteLine($"Parabéns, jogador {vez}, você ganhou!");
                }
                else if (p < oc)
                {
                    li = p;
                }
                else
                {
                    ls = p;
                }
                vez = vez + 1;

                if (vez > 2)
                {
                    vez = 1;
                }
            } while (p != oc);

            Console.ReadKey();
			}
	}
}
    

