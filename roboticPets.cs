using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace template_csharp_virtual_pet
{
   public class roboticPets : Pet
    {
        static roboticPets roboPet = new roboticPets();

        public override Pet createPet()
        {
            Console.Clear();
            roboPet = new roboticPets();
            roboPet.Pet_name();

            roboPet.Pet_species();

            roboPet.type_pet();

            return roboPet;
        }


        public override void ATimer_Elapsed(object sender, ElapsedEventArgs e) // ask if there a way to make it show in real time. (Theres not  for a console app ) // bring this into pet!!!!!!!!!!
        {
           roboPet.PetHealth = roboPet.PetHealth - 0.5;
           roboPet.PetHunger = roboPet.PetHunger - 0.5;
           roboPet.PetFun = roboPet.PetFun - 5; // For balance so that every one wont just make a robot
        }

        public override void Pet_menu()
        {
            bool Game = true;
            while (Game)
            {

                aTimer = new Timer();
                aTimer.Interval = 10000; // Yes ever 10 sec status changes. Robots are op
                aTimer.Elapsed += ATimer_Elapsed;
                aTimer.Enabled = true;
                aTimer.AutoReset = true;
                aTimer.Start();


                Console.Clear();
                Console.WriteLine("Health: " + roboPet.PetHealth + "\t\t\t\t\t\t\t\t\t\t\tRobot name: " + roboPet.PetNaming);
                Console.WriteLine("Hunger: " + roboPet.PetHunger + "\t\t\t\t\t\t\t\t\t\t\tRobot species: " + roboPet.PetSpecies);
                Console.WriteLine("Fun: " + roboPet.PetFun + "\t\t\t\t\t\t\t\t\t\t\t\tType: " + roboPet.Type);


                string[] choice = new string[9] { "\t\t\t\t\t\t1.Create a robotic Pet!", "\n\n\t\t\t\t\t\t2.Interact with pet", "\t\t\t\t\t\t3.Feed pet", "\t\t\t\t\t\t4.Take to the mechanic", "\t\t\t\t\t\t5.Put pet into shelter - (Note this will make you create a new pet)", "\t\t\t\t\t\t6.Vist the shelter", "\t\t\t\t\t\t7.switch to generic pet", "\t\t\t\t\t\t8.switch to  organic pet", "\t\t\t\t\t\t0.Exit game " };

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
                        Pet_interact();
                        break;
                    case 3:
                        Pet_feed();
                        break;
                    case 4:
                        Pet_medicine();
                        break;
                    case 5:
                        shelterPet.Add_pets(roboPet);
                        createPet();
                        break;
                    case 6:
                        roboPet = (roboticPets)shelterPet.adopt_pets();
                        petList.Remove(roboPet);

                        break;
                    case 7:          
                        virtualPet.Pet_menu();
                        break;
                    case 8:           //switching pet to be organic menu.

                        break;
                    case 0:
                        Game = false;

                        break;
                }
            }
        }


        public override void type_pet()
        {
            this.Type = "Robotic";
        }


        public override void Pet_medicine()
        {
            Console.Clear();
            Console.WriteLine("Current health: " + this.PetHealth);
            Console.WriteLine("Here a list of parts for your robotic pet");
            string[] Meds = new string[2] { "1.Parts", "2.Go back" };

            for (int count = 0; count < Meds.Length; count++)
            {
                Console.WriteLine(Meds[count]);
            }

            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                this.PetHealth += 60;

            }
            else
            {

            }
        }


        public override void Pet_interact()
        {
            Console.Clear();
            Console.WriteLine("Current fun: " + this.PetFun + " Current Pet: " + this.PetNaming);
            Console.WriteLine("Interact with your robo pet");
            string[] Fun = new string[3] { "1.Do my Homework for me", "2.Find buried treasure", "3.Flying robo pet" };

            for (int count = 0; count < Fun.Length; count++)
            {
                Console.WriteLine(Fun[count]);
            }

            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                this.PetFun += 5;

            }
            else if (input == 2)
            {
                this.PetFun += 20;

            }
            else if (input == 3)
            {
                this.PetFun += 30;
            }
        }

        public override void Pet_feed()  
        {
            Console.Clear();
            Console.WriteLine("Current hunger: " + this.PetHunger);
            Console.WriteLine("Feed your pet scrap");
            string[] Feed = new string[3] { "1.Copper", "2.Iron", "3.Steel" };

            for (int count = 0; count < Feed.Length; count++)
            {
                Console.WriteLine(Feed[count]);
            }

            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                this.PetHunger += 10;

            }
            else if (input == 2)
            {
                this.PetHunger += 15;

            }
            else if (input == 3)
            {
                this.PetHunger += 25;

            }

        }






    }
}