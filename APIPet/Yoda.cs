using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPet
{
    class Yoda : Spawner
    {
       // Använder samma logik som darth wader 


        public void printInstructions()
        {
            Console.WriteLine(Food);
            Console.WriteLine(Spirit);
            Console.WriteLine(Love);

        }




        Random generator = new Random();

        public int Feed()
        {

            

            Food = Food + generator.Next(1, 2);

            return Food;



        }


        public int Play()
        {

            Spirit = Spirit - generator.Next(1, 5);


            return Spirit;

        }


        public int Cuddle()
        {

            Love = Love + generator.Next(1, 2);


            return Love;

        }

    }


}



