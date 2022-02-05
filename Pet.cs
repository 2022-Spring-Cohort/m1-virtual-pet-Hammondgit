using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace template_csharp_virtual_pet
{

    public class Pet
    {

        public string Type { get; set; } // So the user be able to keep track of different pets in shelter 
        public string PetNaming { get; set; }
        public string PetSpecies { get; set; }
        public double PetHealth { get; set; }
        public double PetHunger { get; set; }
        public double PetFun { get; set; } // Instead of using boredom, I think the user will understand fun going lower instead of bordom getting higher.
       

        public static Pet virtualPet = new Pet();
        public static roboticPets roboPet = new roboticPets();
        public static organicPets OrganicPet = new organicPets();

        public static shelter shelterPet = new shelter();
        public static List<Pet> petList = new List<Pet>();
        public static Timer aTimer;




        public Pet()
        {

            this.PetFun = 100;
            this.PetHunger = 100;
            this.PetHealth = 100;
           
        }

   
        public virtual Pet createPet()
        {
            Console.Clear();
            virtualPet = new Pet();
            virtualPet.Pet_name();

            virtualPet.Pet_species();

            virtualPet.type_pet();

            return virtualPet;
        }


        public virtual void ATimer_Elapsed(object sender, ElapsedEventArgs e) // ask if there a way to make it show in real time. (Theres not  for a console app )
        {
            virtualPet.PetHealth = virtualPet.PetHealth - 5;
            virtualPet.PetHunger = virtualPet.PetHunger - 5;
            virtualPet.PetFun = virtualPet.PetFun - 5;
        }


        public virtual void Pet_menu()
        {
            bool Game = true;
            while (Game)
            {
                
                aTimer = new Timer();
                aTimer.Interval = 5000;
                aTimer.Elapsed += ATimer_Elapsed;
                aTimer.Enabled = true;
                aTimer.AutoReset = true;
                aTimer.Start();


                Console.Clear();
                Console.WriteLine("Health: " + virtualPet.PetHealth + "\t\t\t\t\t\t\t\t\t\t\t\tName: " + virtualPet.PetNaming);
                Console.WriteLine("Hunger: " + virtualPet.PetHunger + "\t\t\t\t\t\t\t\t\t\t\t\tSpecies: " + virtualPet.PetSpecies);
                Console.WriteLine("Fun: " + virtualPet.PetFun + "\t\t\t\t\t\t\t\t\t\t\t\tType: " + virtualPet.Type);

                type_pet();
                string[] choice = new string[9] { "\t\t\t\t\t\t1.Create a Pet!", "\n\n\t\t\t\t\t\t2.Interact with pet", "\t\t\t\t\t\t3.Feed pet", "\t\t\t\t\t\t4.Take to the vet", "\t\t\t\t\t\t5.Put pet into shelter - (Note this will make you create a new pet)", "\t\t\t\t\t\t6.Vist the shelter", "\t\t\t\t\t\t7.switch to robotic pet", "\t\t\t\t\t\t8.switch to  organic pet", "\t\t\t\t\t\t0.Exit game " };

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
                         createPet();
                        break;
                    case 6:
                        virtualPet = shelterPet.adopt_pets();
                        petList.Remove(virtualPet);

                        break;
                    case 7:          
                       roboPet.Pet_menu();
                        break;
                    case 8:
                        OrganicPet.Pet_menu();
                        break;
                    case 0:
                        Game = false;

                        break;
                }
            }
        }

        public virtual void type_pet()
        {
            this.Type = "Generic";
        }


        public void Pet_name() 
        {
            Console.WriteLine("What is the name of your pet? ");
            string petnameing = Console.ReadLine();

            this.PetNaming = petnameing;
        }
 

        public void Pet_species()
        {
            Console.Clear();
            Console.WriteLine("what species is your pet");
            Console.WriteLine(" 1.Water\n 2.Earth \n 3.FIre");
            int speciesInput = Convert.ToInt32(Console.ReadLine());


            if (speciesInput == 1)
            {

                this.PetSpecies = "Water";

            }
            else if (speciesInput == 2)
            {

                this.PetSpecies = "Earth";

            }
            else if (speciesInput == 3)
            {

                this.PetSpecies = "Fire";

            }
            else if (speciesInput == 4)
            {

                Console.WriteLine("Water. Earth. Fire. Air. Long ago, the four nations lived together in harmony.\nThen everything changed when the Fire Nation attacked. ");
                Console.WriteLine("Only the Avatar, master of all four elements, could stop them. But when the world needed him most, he vanished. ");
                Console.WriteLine("\nA hundred years passed and my brother and I discovered the new Avatar, an airbender named " + this.PetNaming + " ,\nand although his airbending skills are great, he still has a lot to learn before he's ready to save anyone.");
                Console.WriteLine("\nBut I believe " + this.PetNaming + " can save the world.");
                Console.WriteLine("\n\nPress any key.....");
                Console.ReadKey();

                // easter egg if the user input 4 -- avater the last airbander
                this.PetSpecies = "Air";
            }
            else
            {
                call_Species_again();
            }
        }


        public void call_Species_again()
        {
            Console.WriteLine("Invaid input. Try again!");
            Pet_species();
        }



     

        public virtual void Pet_medicine()
        {
            Console.Clear();
            Console.WriteLine("Current health: " + this.PetHealth );
            Console.WriteLine("Here a list of medicine for your pet");
            string[] Meds = new string[2] { "1.Pills", "2.Go back" };

            for (int count = 0; count < Meds.Length; count++)
            {
                Console.WriteLine(Meds[count]);
            }

            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                this.PetHealth += 25;
          
            }
            else
            {
            
            }
        }

        public virtual void Pet_interact()
        {
            Console.Clear();
            Console.WriteLine("Current fun: " + this.PetFun + "Current Pet: " + this.PetNaming);
            Console.WriteLine("Interact with your pet");
            string[] Fun = new string[3] { "1.Headpat", "2.Go for a walk", "3.Playing fetch" };

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
                this.PetFun += 15;
        
            }
            else if (input == 3)
            {
                this.PetFun += 20;
       
            }
        }

        public virtual void Pet_feed()
        {
            Console.Clear();
            Console.WriteLine("Current hunger: " + this.PetHunger);
            Console.WriteLine("Feed your pet");
            string[] Feed = new string[3] { "1.Apple", "2.Sandwich", "3.Pizza" };

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
                this.PetHunger += 20;
              
            }
        }




    }
}