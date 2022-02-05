using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace template_csharp_virtual_pet
{
   public class organicPets : Pet
    {

       
        public override Pet createPet()
        {
            Console.Clear();
            OrganicPet = new organicPets();
            OrganicPet.Pet_name();

            OrganicPet.Pet_species();

            OrganicPet.type_pet();

            return OrganicPet;
        }


        public override void ATimer_Elapsed(object sender, ElapsedEventArgs e) // ask if there a way to make it show in real time. (Theres not for a console app ) 
        {
            OrganicPet.PetHealth = OrganicPet.PetHealth - 15;
            OrganicPet.PetHunger = OrganicPet.PetHunger - 15;
            OrganicPet.PetFun--; 
        }

        public override void Pet_menu()
        {
            bool Game = true;
            while (Game)
            {

                aTimer = new Timer();
                aTimer.Interval = 3000; 
                aTimer.Elapsed += ATimer_Elapsed;
                aTimer.Enabled = true;
                aTimer.AutoReset = true;
                aTimer.Start();


                Console.Clear();
                Console.WriteLine("Hearts: " + OrganicPet.PetHealth + "\t\t\t\t\t\t\t\t\t\t\tOrganic name: " + OrganicPet.PetNaming);
                Console.WriteLine("Hunger: " + OrganicPet.PetHunger + "\t\t\t\t\t\t\t\t\t\t\tOrganic species: " + OrganicPet.PetSpecies);
                Console.WriteLine("Fun: " + OrganicPet.PetFun + "\t\t\t\t\t\t\t\t\t\t\t\tType: " + OrganicPet.Type);


                string[] choice = new string[9] { "\t\t\t\t\t\t1.Create a Organic Pet!", "\n\n\t\t\t\t\t\t2.Interact with pet", "\t\t\t\t\t\t3.ReEnergize pet", "\t\t\t\t\t\t4.Take to the Super vet", "\t\t\t\t\t\t5.Put pet into shelter - (Note this will make you create a new pet)", "\t\t\t\t\t\t6.Vist the shelter", "\t\t\t\t\t\t7.switch to generic pet", "\t\t\t\t\t\t8.switch to robotic pet", "\t\t\t\t\t\t0.Exit game " };

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
                        shelterPet.Add_pets(OrganicPet);
                        createPet();
                        break;
                    case 6:
                        OrganicPet = (organicPets)shelterPet.adopt_pets();
                        petList.Remove(OrganicPet);
                        break;
                    case 7:
                        virtualPet.Pet_menu();
                        break;
                    case 8:
                        roboPet.Pet_name();
                        break;
                    case 0:
                        Game = false;
                        break;
                }
            }
        }


        public override void type_pet()
        {
            this.Type = "Organic";
        }


        public override void Pet_medicine()
        {
            Console.Clear();
            Console.WriteLine("Current health: " + this.PetHealth);
            Console.WriteLine("Here a list of herbs for your organic pet");
            string[] Meds = new string[2] { "1.Lavender", "2.Go back" };

            for (int count = 0; count < Meds.Length; count++)
            {
                Console.WriteLine(Meds[count]);
            }

            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                this.PetHealth += 40;
                this.PetHunger += 5;

            }
            else
            {

            }
        }


        public override void Pet_interact()
        {
            Console.Clear();
            Console.WriteLine("Current fun: " + this.PetFun + " Current Pet: " + this.PetNaming);
            Console.WriteLine("Interact organic with your pet");
            string[] Fun = new string[3] { "1.Highfive Pet", "2.Water skiing with pet", "3.Praise the SUNNNN with pet" };

            for (int count = 0; count < Fun.Length; count++)
            {
                Console.WriteLine(Fun[count]);
            }

            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                this.PetFun += 10;

            }
            else if (input == 2)
            {
                this.PetFun += 20;

            }
            else if (input == 3)
            {
                this.PetFun += 30;
                this.PetHunger += 10;
                this.PetHealth += 5;
            }
        }

        public override void Pet_feed()
        {
            Console.Clear();
            Console.WriteLine("Current hunger: " + this.PetHunger);
            Console.WriteLine("Feed your pet fruits and vegetables");
            string[] Feed = new string[3] { "1. Broccoli", "2. Tomato", "3.Pineapples" };

            for (int count = 0; count < Feed.Length; count++)
            {
                Console.WriteLine(Feed[count]);
            }

            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                this.PetHunger += 5;

            }
            else if (input == 2)
            {
                this.PetHunger += 10;

            }
            else if (input == 3)
            {
                this.PetHunger += 25;
                this.PetHealth += 5;
                this.PetFun += 1;
            }

        }










    }
}
