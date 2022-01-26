using System;
using System.Threading;

namespace template_csharp_virtual_pet
{
    class Program
    {
        static void Main(string[] args)
        {

            Pet virtualPet = new Pet();


            // titlte 
            Console.WriteLine("\t\t\t\t\t\tWelcome to\n\n\t\t\t\t\t\tPOKNOMMMM!!!\n\t\t\t\t\t\tForm ther very not so copyrited game... ");

            //TEXT FOR THE MEAN MENU
            Console.WriteLine("\n\t\t\t\t\t\tENTER GAME:-Press 1\n\n\t\t\t\t\t\tTO EXEIT GAME:-Press 0 at any time  ");
            int menuInput = Convert.ToInt32(Console.ReadLine());


            switch (menuInput)
            {
                case 1:
                    gameSetupname();
                    break;

                case 0:
                    exitGame(); // EXIT THE GAME ay any time. Thinking about making a utilitie class and putting it in it.
                    break;
            }

        }
        // Geting players name 
        public static void gameSetupname()
        {
            Pet virtualPet = new Pet();
            Console.Clear();
            Console.WriteLine("Welcome to the game");
            Console.WriteLine("I hope you enjoy the expranicne ");
            virtualPet.Pet_name();
            gameSetupspecies();

        }

        // Getting players species
        public static void gameSetupspecies()
        {
            Pet virtualPet = new Pet();
            Console.Clear();
            Console.WriteLine("what species is your pet");
            Console.WriteLine(" 1.Water\n 2.Earth \n 3.FIre");
            int speciesInput = Convert.ToInt32(Console.ReadLine());
            virtualPet.Pet_species(speciesInput);

            Console.WriteLine("\n\nSetup complete \nPress any button to contuine..."); // I dont like how this looks and works. Might change this later
            Console.ReadLine();
            mainGame();

        }
        public static void mainGame()
        {
            Pet virtualPet = new Pet();
            Console.Clear();


            Console.WriteLine("is this working" + virtualPet.Pet_name());
            // Console.WriteLine("Health "  + );
        }




        static void exitGame()
        {
            Console.Clear();
            Console.WriteLine("Hope you enjoy the game ");
            Console.WriteLine("Sea yea next time");
            Thread.Sleep(5000);

        }
        // if ( )   { exitGame()} use this latter  ----------  use this later 


    }
}
