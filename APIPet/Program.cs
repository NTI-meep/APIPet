using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;


namespace APIPet
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client2 = new RestClient("https://swapi.dev/api/"); // Använder sig av rest addonen där man hämtar först in "sidans" api

            RestRequest request2 = new RestRequest("people/4/"); // Sedan så requestar jag just vilken/vem av datan jag vill ha så tillexempel jag får karaktären som representerar in just people 4 

            IRestResponse response2 = client2.Get(request2);

            Darkside darkside = JsonConvert.DeserializeObject<Darkside>(response2.Content); // Sedan så behöver jag konvertera den datan jag har fått in. 

            RestClient client = new RestClient("https://swapi.dev/api/");

            RestRequest request = new RestRequest("people/20/");

            IRestResponse response = client.Get(request);

            Starwars starwars = JsonConvert.DeserializeObject<Starwars>(response.Content);

            RestClient client3 = new RestClient("https://swapi.dev/api/");
            RestRequest request3 = new RestRequest("people/10/");
            IRestResponse response3 = client3.Get(request3);

            Edibles edible = JsonConvert.DeserializeObject<Edibles>(response3.Content);

            RestClient client4 = new RestClient("https://swapi.dev/api/");
            RestRequest request4 = new RestRequest("people/21/");
            IRestResponse response4 = client3.Get(request4);

            Edibles edible2 = JsonConvert.DeserializeObject<Edibles>(response4.Content);

            Queue<string> mycute = new Queue<string>(); // En ny queue som basically är som en lista fast man bara kan lägga till saker bak och ta bort fram 

            mycute.Enqueue("wiggly"); // Har dessa string lagrade i min queue 
            mycute.Enqueue("fluffy");

            

            string[] items = { starwars.name, darkside.name};  // Har en array där jag lagrar namnet från dessa klasser
            int selected = 0;  // En slags meny som beror på keyboarden där beroende var man klickar så tar menyn en till olika ställen 
            while (true) 
            {

                for (int i = 0; i < items.Length; i++) 
                {
                    if (i == selected) Console.Write(">");  
                    else Console.Write(" ");
                    Console.WriteLine(items[i]);
                }


                ConsoleKeyInfo key = Console.ReadKey(); 
                if (key.Key == ConsoleKey.UpArrow) selected--; // De som kontrollerar just keboard sammanhanget
                if (key.Key == ConsoleKey.DownArrow) selected++;
                if (key.Key == ConsoleKey.Enter) break;

                Console.Clear(); 
                if (selected > items.Length - 1) 
                {
                    selected = items.Length - 1;
                }

                if (selected < 0)
                {
                    selected = 0;
                }


            }


            if (selected == 0) // Om menyn klicket överstämmer med det här så tars du hit
            {
                Console.WriteLine("You have choosen to take care of " + starwars.name); // Skriver ut och tar information från klassen starwars som har lagrat api information
                Yoda y1 = new Yoda(); // Ny skapelse av klass
                y1.printInstructions(); // Hämtar in från den nya klassen en av metoderna 
                while (y1.IsAlive == true) // Loopen körs medan metoden returnerar true 
                {


                    
                    string[] choices = { "Feed", "Play", "Love" }; // Lagrar dessa tree som sedan efter keyboard interfacen kommer att väljas. 

                    int Choices = 0;
                    while (true)
                    {

                        for (int i = 0; i < choices.Length; i++)
                        {
                            if (i == Choices) Console.Write(">");
                            else Console.Write(" ");
                            Console.WriteLine(choices[i]);
                        }


                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.UpArrow) Choices--;
                        if (key.Key == ConsoleKey.DownArrow) Choices++;
                        if (key.Key == ConsoleKey.Enter) break;

                        Console.Clear();
                        if (Choices > choices.Length - 1)
                        {
                            Choices = choices.Length - 1;
                        }

                        if (Choices < 0)
                        {
                            Choices = 0;
                        }



                        if (Choices == 0) 
                        {
                            
                            y1.Feed(); // Man kör metoden för att mata och ändra värdet enligt den kallade metoden 
                            Console.WriteLine("You fed " + starwars.name + " a " + edible2.name); // Skriver ut den hämtade klass datan 
                            y1.printInstructions(); // Skriver ut statvärdena för ditt djur 
                            y1.IsAlives(); // Tittar så att metoden fortfarande returnerar true 
                            


                        }


                        if (Choices == 1) 
                        {
                            
                            y1.Play(); // Alla andra dessa följer samma mönster som den första men den första metoden som körs är annorlunda och har annorlunda världen baserat på klass. 
                            Console.WriteLine("You played with " + starwars.name);
                            Console.WriteLine(mycute.Peek());
                            y1.printInstructions();
                            y1.IsAlives();
                            

                        }

                        if (Choices == 2)

                        {
                            
                            y1.Cuddle();
                            Console.WriteLine("You cuddled " + starwars.name);
                            y1.printInstructions();
                            y1.IsAlives();
                            

                        }
                        if (y1.IsAlive == false) // Om metoden returnerar false så kommer du hit 
                        {


                            Console.WriteLine("Oh no the " + starwars.name + " died, game over"); // Skriver ut instruktioner
                            Pettypet pet = new Pettypet(); // Skapar en ny instans av klassen pettypet som drar från darth vader , eftersom att spelet inte behövde vara klar så är det här egentligen någonting som inte är fullt implenterat
                            pet.printInstructions(); // Printar ut instructioner de enda unika om de är att det är samma som darth vaders då den klassen ärver från den som ärver från en annan
                            Console.ReadLine(); // Läser in allting 

                        }
                    }

                   



                }




            }

            if (selected == 1) 
            {
                Console.WriteLine("You have choosen the " + darkside.name);

                Darth_Vader d1 = new Darth_Vader();
                d1.printInstructions();
                while (d1.IsAlive == true) 
                {
                    

                    string[] choices2 = { "Feed", "Play", "Cuddle" };

                    int Choices2 = 0;
                    while (true)
                    {

                        for (int i = 0; i < choices2.Length; i++)
                        {
                            if (i == Choices2) Console.Write(">");
                            else Console.Write(" ");
                            Console.WriteLine(choices2[i]);
                        }


                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.UpArrow) Choices2--;
                        if (key.Key == ConsoleKey.DownArrow) Choices2++;
                        if (key.Key == ConsoleKey.Enter) break;

                        Console.Clear();
                        if (Choices2 > choices2.Length - 1)
                        {
                            Choices2 = choices2.Length - 1;
                        }

                        if (Choices2 < 0)
                        {
                            Choices2 = 0;
                        }



                        if (Choices2 == 0)
                        {
                            
                            d1.Feed();
                            Console.WriteLine("You fed " + darkside.name + " a " + edible.name);
                            d1.printInstructions();
                            d1.IsAlives();
                            
                        }


                        if (Choices2 == 1)
                        {
                            
                            d1.Play();
                            Console.WriteLine("You played with " + darkside.name);
                            Console.WriteLine(mycute.Peek());
                            d1.printInstructions();
                            d1.IsAlives();
                            
                        }

                        if (Choices2 == 2)

                        {
                            
                            d1.Cuddle();
                            Console.WriteLine("You cuddled " + darkside.name);
                            d1.printInstructions();
                            d1.IsAlives();
                            
                        }

                        if (d1.IsAlive == false)
                        {


                            Console.WriteLine("Oh no the " +  darkside.name + " died ");
                            
                            Console.ReadLine();
                        }

                    }

                }

            }

            Console.ReadLine();
        }
    }

    

}


        
    

