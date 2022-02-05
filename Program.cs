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
//bool robot = true;
//while (robot)
//{
//    Console.Clear();
//    Console.WriteLine("Robot Health: " + roboPet.PetHealth + "\t\t\t\t\t\t\t\t\t\t\t Robot Name:" + virtualPet.PetNaming);
//    Console.WriteLine("Robot Hunger: " + roboPet.PetHunger + "\t\t\t\t\t\t\t\t\t\t\t Robot Species:" + virtualPet.PetSpecies);
//    Console.WriteLine("Robot Fun: " + roboPet.PetFun);

//    Console.WriteLine("\n\n\t\t\t\t\t\t1.Interact with robo pet \n\n\t\t\t\t\t\t2.Feed robo pet \n\n\t\t\t\t\t\t3.Take to the mechanic \n\n\t\t\t\t\t\t4.Put pet into shelter \n\n\t\t\t\t\t\t5.Vist the shelter");
//    int robotInput = Convert.ToInt32(Console.ReadLine());

//    switch (robotInput)
//    {
//        case 1:
//            roboPet.Pet_interact();
//            break;
//        case 2:
//            roboPet.Pet_feed();
//            break;
//        case 3:
//            roboPet.Pet_medicine();
//            break;
//        case 4:
//            shelterPet.Add_pets(roboPet);
//            virtualPet = createPet();
//            robot = false;
//            break;
//        case 5:
//            virtualPet = shelterPet.adopt_pets();
//            petList.Remove(virtualPet);
//            break;
//        case 6:
//            robot = false;
//            break;
//    }

//}
