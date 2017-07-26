using System;

namespace palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string palin;
            Console.WriteLine("Digite uma palavra");
            palin = Console.ReadLine();
            string[] palavra = new string[palin.Length];
            string[] pa = new string[palin.Length];
            int y = palin.Length -1;
            for (var a = 0 ; y >= 0  ; a++,y--)
            {
                palavra[y] = palin[a].ToString();
                pa[a] = palin[a].ToString();
            }
            int x = 0;
            for (int i = 0; i < palin.Length - 1; i++)
            {
                if (pa[i] == palavra[i])
                    x++;
            }
            if (x == palin.Length -1)
            {
                Console.WriteLine("Sua palavra e um palindromo!");
            }
            else
            {
                Console.WriteLine("Sua palavra nao e um palindromo!");
            }
            Console.ReadKey();
        }
    }
}