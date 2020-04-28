using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPet
{
    class Spawner
    {
        public int Food = 5;

        public int Spirit = 6;

        public int Love = 9;

        public bool IsAlive = true;

        public bool IsAlives()
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
