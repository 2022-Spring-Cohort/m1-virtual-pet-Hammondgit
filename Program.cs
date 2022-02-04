using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;

namespace template_csharp_virtual_pet
{
    class Program
    {
        private static System.Timers.Timer aTimer;
        static Pet virtualPet = new Pet();
        static shelter shelterPet = new shelter();
        static roboticPets roboPet = new roboticPets();
        static List<Pet> petList = new List<Pet>();



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

  
        public static Pet createPet()
        {
            Console.Clear();
            virtualPet = new Pet();
            virtualPet.Pet_name();

            virtualPet.Pet_species();


            return virtualPet;
        }

   

        public static void game()
        {
           bool Game = true; 
            while (Game)
            {

                aTimer = new System.Timers.Timer();
                aTimer.Interval = 5000;
                aTimer.Elapsed += ATimer_Elapsed;
                aTimer.Enabled = true;
                aTimer.AutoReset = true;
                aTimer.Start();


                Console.Clear();
                Console.WriteLine("Health: " + virtualPet.PetHealth + "\t\t\t\t\t\t\t\t\t\t\t\t Name:" + virtualPet.PetNaming);
                Console.WriteLine("Hunger: " + virtualPet.PetHunger + "\t\t\t\t\t\t\t\t\t\t\t\t Species:" + virtualPet.PetSpecies);
                Console.WriteLine("Fun: " + virtualPet.PetFun);


                string[] choice = new string[8] { "\t\t\t\t\t\t1.Create a Pet!", "\n\n\t\t\t\t\t\t2.Interact with pet", "\t\t\t\t\t\t3.Feed pet", "\t\t\t\t\t\t4.Take to the vet", "\t\t\t\t\t\t5.Put pet into shelter", "\t\t\t\t\t\t6.Vist the shelter", "\t\t\t\t\t\t7.switch to robotic pet", "\t\t\t\t\t\t0.Exit game " };

                for (int count = 0; count < choice.Length; count++)
                {
                    Console.WriteLine(choice[count]);
                }


                int userInput = Convert.ToInt32(Console.ReadLine());


                switch (userInput)
                {
                    case 1:
                        createPet();
                        break;
                    case 2:
                        virtualPet.Pet_interact();
                        break;
                    case 3:
                        virtualPet.Pet_feed();
                        break;
                    case 4:
                        virtualPet.Pet_medicine();

                        break;
                    case 5:
                        shelterPet.Add_pets(virtualPet);
                        virtualPet = createPet();

                        break;
                    case 6:
                        virtualPet = shelterPet.adopt_pets();
                        petList.Remove(virtualPet);

                        break;
                    case 7:           //switching pet to be robotic menu.
             
                        break;
                    case 0:
                        Game = false;

                        break;
                }
            }

         

            exit_Game();
        }




        private static void ATimer_Elapsed(object sender, ElapsedEventArgs e) // ask if there a way to make it show in real time. (Theres not  for a console app ) // bring this into pet!!!!!!!!!!
        {
            virtualPet.PetHealth--;
            virtualPet.PetHunger--;
            virtualPet.PetFun--;
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
