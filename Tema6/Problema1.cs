using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6
{
    public class Problema1
    {
        public void RezolvareProblema()
        {
            Console.WriteLine("Introduceti baza");

            int baza = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Scara:");

            int i = 1;

            while (i <= baza)
            {
                for (int y = baza - 1; y >= 0; y--)
                {
                    if (y < i)
                    {
                        Console.Write("3");
                    }
                    else 
                    {
                        Console.Write(" ");
                    }
                }
                i++;
                Console.WriteLine();
            }
        }
    }
}
