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
        static Pet virtualPet = new Pet();
        


        public void Add_pets(Pet addPet)
        {


            petList.Add(addPet);
            
            



        }

        public Pet adopt_pets()
        {
            Console.Clear();
            // ask the user what pet they want 
            Console.WriteLine("Our shelter has this many pets:" + petList.Count);

            // someh0w show a list of pets???
            Console.WriteLine("Here a list of pets");


            int I = 1;
            int count = 1;
           
            foreach (Pet pet in petList)
            {
                virtualPet = petList[I - 1];
                Console.WriteLine(count + ". " +virtualPet.PetNaming+ ": Health:"+ virtualPet.PetHealth + " , Hunger:" + virtualPet.PetHunger + " , Fun:" + virtualPet.PetFun);
                count++;
                I++;

            }

            int userInput = Convert.ToInt32(Console.ReadLine());


            return petList[userInput - 1];
          


        }



    }
}
