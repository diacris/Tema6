using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6
{
    class Problema2
    {
        public void NumarLumanariStinse()
        {
            Console.WriteLine("Introduceti varsta:");

            int varsta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti dimensiunile lumanarilor:");

            int[] SirLumanari = new int[varsta];

            for (int i = 0; i < varsta; i++)
            {
                SirLumanari[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = SirLumanari[0];

            foreach (int item in SirLumanari)
            {
                if (max < item)
                {
                    max = item;
                }
            }

            int numarLumanariStinse = 0;

            foreach(int item in SirLumanari)
            {
                if (item == max)
                {
                    numarLumanariStinse++;
                }
            }

            Console.WriteLine($"Numarul lumanarilor stinse este:{numarLumanariStinse}");
        }
    }
}

