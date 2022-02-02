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


        static void Main(string[] args)
        {




            // Title 
            Console.WriteLine("\t\t\t\t\t\tWelcome to\n\n\t\t\t\t\t\tPOKNOMMMM!!!\n\n\t\t\t\t\tForm ther very not so copyrited game...\n\t\t\t\t\tBTW there a easter egg somewhere  ");

            //TEXT FOR THE MEAN MENU
            Console.WriteLine("\n\t\t\t\t\t\tENTER GAME:-Press 1\n\n\t\t\t\t\t\tEXEIT GAME:-Press 0 ");
            int menuInput = Convert.ToInt32(Console.ReadLine());


            switch (menuInput)
            {
                case 1:
                    game();
                    break;

                case 0:
                    exit_Game(); // EXIT THE GAME ay any time. Thinking about making a utilitie class and putting it in it.
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


                string[] choice = new string[7] { "\t\t\t\t\t\t1.Create a Pet!", "\n\n\t\t\t\t\t\t2.Interact with pet", "\t\t\t\t\t\t3.Feed pet", "\t\t\t\t\t\t4.Take to doctor", "\t\t\t\t\t\t5.Put pet into shelter", "\t\t\t\t\t\t6.Vist the shelter", "\t\t\t\t\t\t0.Exit game " };

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
                        break;

                    case 0:
                        Game = false;

                        break;
                }

            }

            exit_Game();
        }




        private static void ATimer_Elapsed(object sender, ElapsedEventArgs e) // ask if there a way to make it show in real time
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
