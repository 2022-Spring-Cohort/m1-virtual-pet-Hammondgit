using NUnit.Framework;
using template_csharp_virtual_pet;

namespace virtual_pet_tests
{
    [TestFixture]
    public class PetTests
    {
        private Pet testPet;

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
            // int testPetHunger = testPet.GetHunger();

            // Assert.Equal(50, testPetHunger);
        }

        [Test]
        public void Pet_Should_Have_Boredom()
        {
            // testPet.Boredom = 100;

            // Assert.Equal(100, testPet.Boredom);
        }

        [Test]
        public void GetBoredom_Should_Return_Initial_Boredom_Level_Of_60()
        {
            // int testPetBoredom = testPet.GetBoredom();

            // Assert.Equal(60, testPetBoredom);
        }

        [Test]
        public void Pet_Should_Have_Health()
        {
            // testPet.Health = 100; 

            // Assert.Equal(100, testPet.Health);
        }

        [Test]
        public void GetHealth_Should_Return_Initial_Health_Level_Of_30()
        {
            // int testPetHealth = testPet.GetHealth();

            // Assert.Equal(30, testPetHealth);
        }

        [Test]
        public void Feed_Should_Decrease_Hunger_By_40()
        {
            // testPet.Feed();

            // Assert.Equal(10, testPet.GetHunger());
        }

        [Test]
        public void SeeDoctor_Should_Increase_Health_By_30()
        {
            // testPet.SeeDoctor();

            // Assert.Equal(60, testPet.GetHealth());
        }

        [Test]
        public void Play_Should_Increase_Hunger_By_10()
        {
            // testPet.Play();

            // Assert.Equal(60, testPet.GetHunger());
        }

        [Test]
        public void Play_Should_Decrease_Boredom_By_20()
        {
            // testPet.Play();

            // Assert.Equal(40, testPet.GetBoredom());
        }

        [Test]
        public void Play_Should_Increase_Health_By_10()
        {
            // testPet.Play();

            // Assert.Equal(40, testPet.GetHealth());
        }

        [Test]
        public void Tick_Should_Increase_Hunger_By_5()
        {
            // testPet.Tick();

            // Assert.Equal(55, testPet.GetHunger());
        }

        [Test]
        public void Tick_Should_Increase_Boredom_By_5()
        {
            // testPet.Tick();

            // Assert.Equal(65, testPet.GetBoredom());
        }

        [Test]
        public void Tick_Should_Decrease_Health_By_5()
        {
            // testPet.Tick();

            // Assert.Equal(25, testPet.GetHealth());
        }
    }
}