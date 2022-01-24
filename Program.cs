using System;

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
            Console.WriteLine("\n\t\t\t\t\t\tENTER GAME:-Press 1\n\t\t\t\t\t\tEXEIT GAME:-Press 2");
            int menuInput = Convert.ToInt32(Console.ReadLine());


 

            switch (menuInput)
            {
                case 1:
                    gameSetup(virtualPet);
                    break;

                case 2:
                    Console.WriteLine("PLACEHOLDER"); // EXIT THE GAME
                    break;
            }

          //  Pet virtualPet = new Pet(string namingPet);



            static void gameSetup(Pet virtualPet)
            {

                // Geting players name 
                Console.Clear();
                Console.WriteLine("Welcome to the game");
                Console.WriteLine("I hope you enjoy the expranicne ");
                Console.WriteLine("What is the name of your pet? ");
                virtualPet.Pet_name();


                // Getting players speecies
                Console.Clear();
                Console.WriteLine("what species is your pet");
                Console.WriteLine(" 1.Water\n 2.Earth \n 3.FIre");
                int speciesInput = Convert.ToInt32(Console.ReadLine());
                virtualPet.Pet_species(speciesInput);

                //----------------------------------------
                //maybe add another method and rename game to gameSetup

                Console.WriteLine("\n\nSetup complete \nPress any button to contuine...");
                Console.ReadLine();
            }





        }
    }
}
