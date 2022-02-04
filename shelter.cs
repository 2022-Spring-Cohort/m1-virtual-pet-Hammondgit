using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace template_csharp_virtual_pet
{
    class shelter
    {
        static List<Pet> petList = new List<Pet>();
        static Pet virtualPet = new Pet();



        public void Add_pets(Pet addPet)
        {


            petList.Add(addPet);





        }

        public  Pet adopt_pets()
        {
            Console.Clear();


            int petInput = 1;
            int I = 1;
            int count = 1;
            int iPet = 1;
            Console.Write("What do you want to do in the Shelter?");
            Console.WriteLine("\n\n1.Interact with all pets\n2.Feed pet\n3.Call the vet\n4.Adopt pet");
            Console.WriteLine("\nHere a list of pets Count:" + petList.Count);

            foreach (Pet pet in petList)
            {
                virtualPet = petList[I - 1];
                Console.WriteLine(count + ". " + virtualPet.PetNaming + ": Health:" + virtualPet.PetHealth + " , Hunger:" + virtualPet.PetHunger + " , Fun:" + virtualPet.PetFun);
                count++;
                I++;

            }

            int userInput = Convert.ToInt32(Console.ReadLine());



            switch (userInput)
            {
                case 1:
                    foreach (Pet pet in petList) // give the user some feedback
                    {
                        virtualPet = petList[iPet - 1];
                        virtualPet.PetFun += 2;
                        iPet++;

                    }
                    break;
                case 2:
                    foreach (Pet pet in petList)
                    {
                        virtualPet = petList[iPet - 1];
                        virtualPet.PetHunger += 5;
                        iPet++;

                    }
                    break;
                case 3:
                    foreach (Pet pet in petList)
                    {
                        virtualPet = petList[iPet - 1];
                        virtualPet.PetHealth += 100;
                        iPet++;

                    }

                    break;
                case 4:
                    Console.WriteLine("Pick the pets number");
                    petInput = Convert.ToInt32(Console.ReadLine());
                    break;

            }
            
            return petList[petInput - 1];
        }

    }
}
