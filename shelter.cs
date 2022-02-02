using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    class shelter
    {
        List<Pet> petList = new List<Pet>();
        Pet addPets = new Pet();


        public void Add_pets()
        {


            petList.Add(addPets);
            Program.game_Setup();// make a if statment to see if list already has pets or ask them if they like to adopt one.
            Console.ReadKey();



        }

        public Pet adopt_pets()
        {
            Console.Clear();
            // ask the user what pet they want 
            Console.WriteLine("Our shelter has this many pets:" + petList.Count);

            // someh0w show a list of pets???
            Console.WriteLine("Here a list of pets");
        

          //  string hi = "hi"; // wanted to see if it was possble to track current pet names. 
            int count = 1;
            foreach (Pet pet in petList)
            {
                
                Console.WriteLine(count + ": "+ pet );
                count++;
            }

           int userInput = Convert.ToInt32(Console.ReadLine());

            return petList[userInput - 1];
          


        }



    }
}
