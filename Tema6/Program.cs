using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6
{
    class Program
    {
        static void Main(string[] args)
        {
            Problema1 problema1 = new Problema1();

            problema1.RezolvareProblema();

            Problema2 problema2 = new Problema2();

            problema2.NumarLumanariStinse(); 

            Problema3 problema3 = new Problema3();

            problema3.Logare();

            Console.ReadKey();
        }
    }
}
