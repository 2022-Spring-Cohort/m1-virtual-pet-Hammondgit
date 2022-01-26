using System;
using System.Threading;

namespace template_csharp_virtual_pet
{
    class Program
    {
        static void Main(string[] args)
        {

            


            // titlte 
            Console.WriteLine("\t\t\t\t\t\tWelcome to\n\n\t\t\t\t\t\tPOKNOMMMM!!!\n\t\t\t\t\t\tForm ther very not so copyrited game... ");

            //TEXT FOR THE MEAN MENU
            Console.WriteLine("\n\t\t\t\t\t\tENTER GAME:-Press 1\n\n\t\t\t\t\t\tTO EXEIT GAME:-Press 0 at any time  ");
            int menuInput = Convert.ToInt32(Console.ReadLine());


            switch (menuInput)
            {
                case 1:
                    game();
                    break;

                case 0:
                    exitGame(); // EXIT THE GAME ay any time. Thinking about making a utilitie class and putting it in it.
                    break;
            }

            static void game()
            {
                Pet virtualPet = new Pet();


                // Geting players name  
                Console.Clear();
                Console.WriteLine("Welcome to the game");
                Console.WriteLine("I hope you enjoy the expranicne ");
                string userName = virtualPet.Pet_name();


                // Getting players species    
                Console.Clear();
                Console.WriteLine("what species is your pet");
               string userSpecies = virtualPet.Pet_species();


                double userHealth = virtualPet.Pet_health();
                Console.Clear();
                Console.WriteLine("Health: "  + virtualPet.PetHealth + "\t\t\t\t\t\t\t\t\t\t\t\t Name: " + userName);
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t Species: " + userSpecies);
   
            }




        }
        static void exitGame() // need to test this!!!!!!
        {
            Console.Clear();
            Console.WriteLine("Hope you enjoy the game ");
            Console.WriteLine("Sea yea next time");
            Thread.Sleep(5000);

        }
        // if (userInput == 0 || userInput == "0" ) { exitGame()}  --------------  use this later 


    }
}
