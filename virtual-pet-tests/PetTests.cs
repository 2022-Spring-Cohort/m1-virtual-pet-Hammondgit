using NUnit.Framework;
using System.Timers;
using template_csharp_virtual_pet;

namespace virtual_pet_tests
{
    [TestFixture]
    public class PetTests
    {
        private Pet testPet;
        public static Timer aTimer;

        [SetUp]
        public void SetUp()
        {
            testPet = new Pet();
        }

        [Test]
        public void Pet_Constructor_Should_Instantiate_Pet_Object()
        {
            Assert.NotNull(testPet);
        }

        // INSTRUCTIONS:
        // Uncomment code in the test body one test at a time
        // Add source code to eliminate the build errors (red squiggle) and pass the test

        [Test]
        public void Pet_Should_Have_Name()
        {
            testPet.PetNaming = "Pet Name";

             Assert.Equals("Pet Name", testPet.PetNaming);
        }

        [Test]
        public void SetName_Should_Assign_Pet_Name_Property()
        {
             testPet.Pet_name();

             Assert.Equals("Fluffy", testPet.PetNaming);
        }

        [Test]
        public void GetName_Should_Get_Pet_Name_Value()
        {
             testPet.Pet_name();

             string testPetName = testPet.PetNaming;

            Assert.Equals("Fido", testPetName);
        }

        [Test]
        public void Pet_Should_Have_Species()
        {
              testPet.PetSpecies = "Pet Species";

             Assert.Equals("Pet Species", testPet.PetSpecies);
        }

        [Test]
        public void SetSpecies_Should_Assign_Pet_Species_Property()
        {
              testPet.Pet_species();

             Assert.Equals("Cat", testPet.PetSpecies);
        }

        [Test]
        public void GetSpecies_Should_Get_Pet_Species_Value()
        {
            testPet.Pet_species();

            string testPetSpecies = testPet.PetSpecies;

            Assert.Equals("Dog", testPetSpecies);
        }

        [Test]
        public void Pet_Should_Have_Hunger()
        {
               testPet.PetHunger = 100;

               Assert.Equals(100, testPet.PetHunger);
        }

        [Test]
        public void GetHunger_Should_Return_Initial_Hunger_Level_Of_50()
        {
            double testPetHunger = testPet.PetHunger;

             Assert.Equals(50, testPetHunger);
        }

        [Test]
        public void Pet_Should_Have_Boredom()
        {
             testPet.PetFun = 100;

             Assert.Equals(100, testPet.PetFun);
        }

        [Test]
        public void GetBoredom_Should_Return_Initial_Boredom_Level_Of_60()
        {
             double testPetBoredom = testPet.PetFun;

             Assert.Equals(60, testPetBoredom);
        }

        [Test]
        public void Pet_Should_Have_Health()
        {
             testPet.PetHealth = 100; 

             Assert.Equals(100, testPet.PetHealth);
        }

        [Test]
        public void GetHealth_Should_Return_Initial_Health_Level_Of_30()
        {
             double testPetHealth = testPet.PetHealth;

             Assert.Equals(30, testPetHealth);
        }

        [Test]
        public void Feed_Should_Decrease_Hunger_By_40()
        {
              testPet.Pet_feed();

            Assert.Equals(10, testPet.PetHunger); 
        }

        [Test]
        public void SeeDoctor_Should_Increase_Health_By_30()
        {
               testPet.Pet_medicine();

               Assert.Equals(60, testPet.PetHealth); 
        }

        [Test]
        public void Play_Should_Increase_Hunger_By_10()
        {
            testPet.Pet_feed();

            Assert.Equals(60, testPet.PetHunger); 
        }

        [Test]
        public void Play_Should_Decrease_Boredom_By_20()
        {
             testPet.Pet_interact();

             Assert.Equals(40, testPet.PetFun); 
        }

        [Test]
        public void Play_Should_Increase_Health_By_10()
        {
             testPet.Pet_medicine();

             Assert.Equals(40, testPet.PetHealth);
        }

        [Test]
        public void Tick_Should_Increase_Hunger_By_5()
        {
            testPet.ATimer_Elapsed(object sender, ElapsedEventArgs e);

            Assert.Equals(55, testPet.PetHunger );
        }

        [Test]
        public void Tick_Should_Increase_Boredom_By_5()
        {
            testPet.ATimer_Elapsed(object sender, ElapsedEventArgs e);

            Assert.Equals(65, testPet.PetFun);
        }

        [Test]
        public void Tick_Should_Decrease_Health_By_5()
        {
            testPet.ATimer_Elapsed(object sender, ElapsedEventArgs e);

            Assert.Equals(25, testPet.PetHealth);
        }
    }
}