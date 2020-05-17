using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPet
{
    class Spawner
    {
        public int Food = 5; // Är basklass för två andra klasser och här bestäms vad dessa ints ska vara värda 

        public int Spirit = 6;

        public int Love = 9;

        public bool IsAlive = true; // Används i metoden för att deklarera true eller false

        public bool IsAlives() // En bool som testar att djuret är levande igenom att titta att värdena är över en viss nummer och att den returnera antingen false eller true baserat på detta
        {
            if (Food > 1 && Spirit > 1 && Love > 1)
            {

                return IsAlive = true;

            }

            else
            {
                return IsAlive = false;

            }


        }

        

    }
}
