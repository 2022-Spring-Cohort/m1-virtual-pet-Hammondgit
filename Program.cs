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
            Console.WriteLine("\t\t\t\t\t\tWelcome to\n\n\t\t\t\t\t\tPOKNOMMMM!!!\n\t\t\t\t\t\tForm ther very not so copyrited game... ");

            //TEXT FOR THE MEAN MENU
            Console.WriteLine("\n\t\t\t\t\t\tENTER GAME:-Press 1\n\n\t\t\t\t\t\tTO EXEIT GAME:-Press 0 at any time  ");
            int menuInput = Convert.ToInt32(Console.ReadLine());


            switch (menuInput)
            {
                case 1:
                    game_Setup();
                    break;

                case 0:
                    exit_Game(); // EXIT THE GAME ay any time. Thinking about making a utilitie class and putting it in it.
                    break;
            }

        }

       public static void game_Setup()
        {
            // Geting players name  
            Console.Clear();

            Console.WriteLine("Welcome to the game");
            Console.WriteLine("I hope you enjoy the expranicne ");

            virtualPet.Pet_name();

            // Getting players species    
            Console.Clear();

            virtualPet.Pet_species();

            virtualPet.Pet_health();
            virtualPet.Pet_hunger();
            virtualPet.Pet_fun();

            Program.game();

          //  return virtualPet;
        }




        public static void game()
        {
           Boolean Game = true;
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


                string[] choice = new string[6] { "\n\n\t\t\t\t\t\t1.Interact with pet", "\t\t\t\t\t\t2.Feed pet", "\t\t\t\t\t\t3.Take to doctor", "\t\t\t\t\t\t4.Add pet to shelter", "\t\t\t\t\t\t5.Adopt pet to shelter", "\t\t\t\t\t\t6.Exit game " };

                for (int count = 0; count < choice.Length; count++)
                {
                    Console.WriteLine(choice[count]);
                }


                int userInput = Convert.ToInt32(Console.ReadLine());

              



                switch (userInput)
                {
                    case 1:
                        virtualPet.Pet_interact();
                        break;
                    case 2:
                        virtualPet.Pet_feed();
                        break;
                    case 3:
                        virtualPet.Pet_medicine();
                        break;
                    case 4:
                        shelterPet.Add_pets();
                        break;
                    case 5:
                   virtualPet =  shelterPet.adopt_pets();

                        break;
                    case 6:
                        Game = false;
                       
                        break;
                }

          }
            exit_Game();
        }



        //static void shelter_menu()
        //{
        //    Console.Clear();
        //    string[] choice = new string[3] { "\n\n\t\t\t\t\t\t1.Add pet into shelter? ", "\t\t\t\t\t\t2.Adopt Pet? ", "\t\t\t\t\t\t3.Go Back" };

        //    for (int count = 0; count < choice.Length; count++)
        //    {
        //        Console.WriteLine(choice[count]);
        //    }


        //    int userInput = Convert.ToInt32(Console.ReadLine());

        //    switch (userInput)
        //    {
        //        case 1:
        //            shelterPet.Add_pets();
        //            break;
        //        case 2:
        //            shelterPet.adopt_pets();
        //            break;
        //        case 3:
        //            game();
        //            break;


        //    }

        //}



        private static void ATimer_Elapsed(object sender, ElapsedEventArgs e) // ask if ther a way to make it show in real time
        {
            virtualPet.PetHealth--;
            virtualPet.PetHunger--;
            virtualPet.PetFun--;
        }



        static void exit_Game() // need to test this!!!!!!
        {
            Console.Clear();
            Console.WriteLine("Hope you enjoy the game ");
            Console.WriteLine("Sea yea next time");
            Thread.Sleep(5000);

        }
        // if (userInput == 0 || userInput == "0" ) { exitGame()}  --------------  use this later 


    }
}
