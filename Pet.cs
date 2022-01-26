using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet
    {

        //testing 
        public string PetNaming { get; set; }
        public string PetSpecies { get; set; }
        public double PetHealth { get; set; }
        public double PetHunger { get; set; }
        public double PetFun { get; set; } // Instead of using boredom, I think the user will understand fun going lower instead of bordom getting higher.
        // if fun is below  30 the user risk mental health



        public Pet()
        {
        }

        

        public Pet(string petnameing, string petspecies, double pethealth, double pethunger, double petfun)
        {
            this.PetNaming = petnameing;
            this.PetSpecies = petspecies;
            this.PetHealth = pethealth;
            this.PetHunger = pethunger;
            this.PetFun = petfun;
        }



        public string Pet_name()
        {
            Console.WriteLine("What is the name of your pet? ");
            string petnameing = Console.ReadLine();
            
            return this.PetNaming = petnameing;
        }

        public string Pet_species()  // MAKE A LOOP FOR THIS DARIUS!!!
        {
            Console.WriteLine(" 1.Water\n 2.Earth \n 3.FIre");
            int speciesInput = Convert.ToInt32(Console.ReadLine());
            string petspecies = "";

            if (speciesInput == 1)
            {

                return this.PetSpecies = petspecies = "Water";

            }
            else if (speciesInput == 2)
            {

                return this.PetSpecies = petspecies = "Earth";

            }
            else if (speciesInput == 3)
            {

                return this.PetSpecies = petspecies = "Fire";

            }
            else if (speciesInput == 4)
            {

                Console.WriteLine("Water. Earth. Fire. Air. Long ago, the four nations lived together in harmony.\nThen everything changed when the Fire Nation attacked. ");
                Console.WriteLine("Only the Avatar, master of all four elements, could stop them. But when the world needed him most, he vanished. ");
                Console.WriteLine("\nA hundred years passed and my brother and I discovered the new Avatar, an airbender named " + this.PetNaming + " Aang,\nand although his airbending skills are great, he still has a lot to learn before he's ready to save anyone.");
                Console.WriteLine("\nBut I believe Aang can save the world.");
                Console.WriteLine("\n\nPress any key.....");
                Console.ReadKey();

                // easter egg if the user input 4 -- avater the last airbander
                return this.PetSpecies = petspecies = "Air";
            }
            else
            {
                return "not working"; // fix this do recusion/ a loop / or last resort try to call game and look for pet sepcies 
            }

        }
        public double Pet_health()
        {

            double maxhealth = 100;
            double pethealth = maxhealth;

            return this.PetHealth = pethealth;
        }
    }
}
