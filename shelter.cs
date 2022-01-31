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
        Pet incomingPets = new Pet();

        public void shelter_menu()
        {
            Console.Clear();
            string[] choice = new string[2] { "\n\n\t\t\t\t\t\t1.Add pet into shelter? ", "\t\t\t\t\t\t2.Adopt Pet? " };

            for (int count = 0; count < choice.Length; count++)
            {
                Console.WriteLine(choice[count]);
            }


            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Add_pets();
                    break;
                case 2:

                    break;

            }

        }




        public void Add_pets()
        {
            

            petList.Add(incomingPets);
            Console.WriteLine(petList.Count); // testing
            Console.ReadKey();
        }

        public void adopt_pets()
        {
            // ask the user what pet they want 



            // someh0w show a list of pets???


            // 



        }


    }
}
