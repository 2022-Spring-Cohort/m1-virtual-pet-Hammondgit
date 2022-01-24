using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet
    {

        //testing 
        public string PetNaming { get; set; }
        public string PetSpecies { get; set; }
        public double PetHunger { get; set; }
        public double PetFun { get; set; } // Instead of using boredom, I think the user will understand fun going lower instead of bordom getting higher.
        public double PetHealth { get; set; }



        public Pet()
        {
        }


        public Pet(string petnameing, string petspecies)
        {
            this.PetNaming = petnameing;
            this.PetSpecies = petspecies;
        }



        public void Pet_name()
        {
            string Name1 = Console.ReadLine();
            Console.WriteLine(" Name is " + Name1); 

        }
        public void Pet_species(int speciesInput) //!!!
        {
            string speciesType = "";

            if (speciesInput == 1)
            {
                speciesType = "Water";
                Console.WriteLine( " Species is " + speciesType); //--- test case To make sure everthing working.
            }
            else if (speciesInput == 2)
            {
                speciesType = "Earth";
                Console.WriteLine(" Species is " + speciesType);
            }
            else if (speciesInput == 3)
            {
                speciesType = "Fire";
                Console.WriteLine(" Species is " + speciesType);
            }
            else
            {
                //PLACEHOLDER
                // MAKE A LOOP FOR THIS DARIUS!!!

                // easter egg if the user input 4 -- avater the last airbander
            }
        }
    }
}
