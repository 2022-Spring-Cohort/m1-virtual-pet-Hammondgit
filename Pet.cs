using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace template_csharp_virtual_pet
{

    public class Pet
    {


        public string PetNaming { get; set; }
        public string PetSpecies { get; set; }
        public double PetHealth { get; set; }
        public double PetHunger { get; set; }
        public double PetFun { get; set; } // Instead of using boredom, I think the user will understand fun going lower instead of bordom getting higher.
                                           // if fun is below  30 the user risk mental health

        public Pet()
        {
        }

        public Pet(string petnaming, string petspecies, double pethealth, double pethunger, double petfun)
        {
            this.PetNaming = petnaming;
            this.PetSpecies = petspecies;
            this.PetHealth = pethealth;
            this.PetHunger = pethunger;
            this.PetFun = petfun;

        }



        public void Pet_name()
        {
            Console.WriteLine("What is the name of your pet? ");
            string petnameing = Console.ReadLine();

            this.PetNaming = petnameing;
        }

        public void Pet_species()
        {
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
            Console.WriteLine("Invaid input.Try again!");
            Pet_species();
        }





        public void Pet_health()
        {

            this.PetHealth = 100;
        }


        public void Pet_hunger()
        {

            this.PetHunger = 100;
        }

        public void Pet_fun()
        {

            this.PetFun = 100;
        }

        public void Pet_medicine()
        {
            Console.Clear();
            Console.WriteLine("Current health: " + this.PetHealth);
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
                Program.game();
            }
            else
            {
                Program.game();
            }
        }

        public void Pet_interact()
        {
            Console.Clear();
            Console.WriteLine("Current fun: " + this.PetFun);
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
                Program.game();
            }
            else if (input == 2)
            {
                this.PetFun += 15;
                Program.game();
            }
            else if (input == 3)
            {
                this.PetFun += 20;
                Program.game();
            }
        }

        public void Pet_feed()
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
                Program.game();
            }
            else if (input == 2)
            {
                this.PetHunger += 10;
                Program.game();
            }
            else if (input == 3)
            {
                this.PetHunger += 20;
                Program.game();
            }
        }




    }
}