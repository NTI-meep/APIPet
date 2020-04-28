using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPet
{
    class Darth_Vader : Spawner
    {
        public Darth_Vader()
        {
            Food = 9;
            Spirit = 8;
            Love = 11;
        }
        
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




