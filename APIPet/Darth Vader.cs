using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPet
{
    class Darth_Vader : Spawner
    {
        public Darth_Vader() // Ändrar manuellt de värden som hämtas från spawner vilket är basklassen 
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


       Random generator = new Random(); // Randomiserar variabler 


       public int Feed() // Metod som ändrar den givna variabeln med hjälp av generatorn varav numrerna den kan sluta upp att använda skiljer sig mellan metoderna den returnera sedan numret den fått ut den fungerar samma för de andra metoderna
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




