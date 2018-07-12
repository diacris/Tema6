using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6
{
    public class Problema3
    {
        string usernameSalvat;
        string parolaSalvata;
        int numarIncercariPosibile;

        public void Logare()
        {
            usernameSalvat = "diana";
            parolaSalvata = "iunie";
            numarIncercariPosibile = 3;
            int incercari = 0;
            bool userValid = false;

            while (incercari < numarIncercariPosibile && userValid == false)
            {
                Console.WriteLine("Introduceti username:");

                string username = Console.ReadLine();

                Console.WriteLine("Introduceti parola:");

                string parola = Console.ReadLine();

                if (username == usernameSalvat && parola == parolaSalvata)
                {
                    userValid = true;
                }
                else
                {
                    Console.WriteLine($"Mai aveti {numarIncercariPosibile - incercari-1} incercari");
                }
                incercari++;
            }
            if (userValid == true)
            {
                Console.WriteLine("Logare cu succes!");
            }
            else
            {
                Console.WriteLine("Ne pare rau s-a terminat numarul de incercari!");
            }
        }
    }
}
