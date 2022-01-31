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
        public string petnaming { get; set; }
        public string petspecies { get; set; }

        public double pethealth { get; set; }

        public double pethunger { get; set; }

        public double petfun { get; set; }


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
                    Add_pets( petnaming,  petspecies, pethealth, pethunger,  petfun);
                    break;
                case 2:

                    break;

            }

        }




        public void Add_pets(string petnaming, string petspecies, double pethealth, double pethunger, double petfun)
        {

            Pet incomingPets = new Pet(petnaming, petspecies, pethealth,  pethunger,  petfun);
            petList.Add(incomingPets);
            Console.WriteLine(petList);
            Console.WriteLine("notworking");
            Console.ReadKey();
        }



    }
}
