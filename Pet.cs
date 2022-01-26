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
        public double PetHunger { get; set; }
        public double PetFun { get; set; } // Instead of using boredom, I think the user will understand fun going lower instead of bordom getting higher.
        // if fun is below  30 the user risk mental health
        public double PetHealth { get; set; }



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

        public void Pet_species(int speciesInput) //!!!
        {
            string speciesType = "";
            

            if (speciesInput == 1)
            {
                speciesType = "Water";
                Console.WriteLine(" Species is " + speciesType); //--- test case To make sure everthing working.
               
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
            //else if (speciesInput == 4)
            //{
            //    //PLACEHOLDER
            //    //// MAKE A LOOP FOR THIS DARIUS!!!
            //    //Console.WriteLine("Water. Earth. Fire. Air. Long ago, the four nations lived together in harmony.\nThen everything changed when the Fire Nation attacked. ");
            //    //Console.WriteLine("Only the Avatar, master of all four elements, could stop them. But when the world needed him most, he vanished. ");
            //    //Console.WriteLine("\nA hundred years passed and my brother and I discovered the new Avatar, an airbender named " + Pet_name(name1) + " Aang,\nand although his airbending skills are great, he still has a lot to learn before he's ready to save anyone.");
            //    //Console.WriteLine("\n But I believe Aang can save the world.");
            //    //// easter egg if the user input 4 -- avater the last airbander
            //}
            else
            {

                Console.WriteLine("wait 5 sec and pls enter a vaild input");
                Thread.Sleep(5000);
                Program.gameSetupspecies();
                
            }


        }
    }
}
