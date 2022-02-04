using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace template_csharp_virtual_pet
{
    class roboticPets : Pet
    {


        public override void Pet_menu()
        {

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


        public override void Pet_interact()//!!!!!!!!!!!!!!!!!!!!!
        {
            Console.Clear();
            Console.WriteLine("Current fun: " + this.PetFun + " Current Pet: " + this.PetNaming);
            Console.WriteLine("Interact with your robo pet");
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

        public override void Pet_feed() //!!!!!!!!!!!
        {
            Console.Clear();
            Console.WriteLine("Current hunger: " + this.PetHunger);
            Console.WriteLine("Feed your pet scrap");
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