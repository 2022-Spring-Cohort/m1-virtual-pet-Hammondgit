using System;
using System.Collections.Generic;
using System.Timers;

namespace template_csharp_virtual_pet
{
    class Program
    {
        
        static Pet virtualPet = new Pet();


        static void Main(string[] args)
        {
            // Title 
            Console.WriteLine("\t\t\t\t\t\tWelcome to\n\n\t\t\t\t\t\tPOKNOMMMM!!!\n\n\t\t\t\t\tForm ther very not so copyrited game...\n\t\t\t\t\tBTW there a easter egg somewhere  ");

            //TEXT FOR THE MEAN MENU
            Console.WriteLine("\n\t\t\t\t\tENTER GAME:-Press 1\n\n\t\t\t\t\tEXEIT GAME:-Press 0 (Why open the game just to press this right now... (；一_一) ");
            int menuInput = Convert.ToInt32(Console.ReadLine());


            switch (menuInput)
            {
                case 1:
                    game();
                    break;

                case 0:
                    exit_Game(); 
                    break;
            }

        }

  
        public static void game()
        {

            virtualPet.Pet_menu();
         

            exit_Game();
        }


        static void exit_Game() 
        {
            Console.Clear();
            Console.WriteLine("Hope you enjoy the game ");
            Console.WriteLine("Sea yea next time");
            Console.WriteLine("Press any key to close appicaiton.......");
            Console.ReadKey();

        }



    }
}

