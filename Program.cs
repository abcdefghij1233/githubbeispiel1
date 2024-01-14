using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubbeispiel
{
    class Program
    {
        static bool IstPrimzahl(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            else if (n == 2)
            {
                return true;
            }
            else if (n % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i <= Math.Sqrt(n); i += 2)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            
            Console.Write("Eingabe: n=");
            int zahl = Convert.ToInt32(Console.ReadLine());

            
            if (IstPrimzahl(zahl))
            {
                Console.WriteLine($"{zahl} ist eine Primzahl.");
            }
            else
            {
                Console.WriteLine($"{zahl} ist keine Primzahl.");
            }
            Console.ReadKey();
        }
    }
}
