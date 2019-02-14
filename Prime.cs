using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static int prime(int n)
        {
            int i,aux=0;
            for (i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    aux = 1;
            return aux;
                
        }
        static void Main(string[] args)
        {
            int n,m,i;
            Console.WriteLine("Enter the inferior range: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the superior range: ");
            m = int.Parse(Console.ReadLine());
            for (i = n; i <= m; i++)
                if (prime(i) == 0)
                    Console.WriteLine(i);
            Console.ReadLine();

        }
    }
}
