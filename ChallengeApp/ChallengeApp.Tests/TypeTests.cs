

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ThereAreDifferentEmployees()
        {
            // arrange
            var employee1 = GetUser("Kasia", "Nowakowska", "46");
            var employee2 = GetUser("Magda", "Nowakowska", "46");

            // act
            
            // assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void TheSameSurname()
        {
            // arrange
            var employee1 = GetUser("Kasia", "Nowakowska", "46");
            var employee2 = GetUser("Magda", "Nowakowska", "46");
          
            // act

            // assert
            Assert.AreEqual(employee1.Surname, employee2.Surname);
        }

        [Test]
        public void TheSameWeight()
        {
            // arrange
            float weight1 = 58;
            float weight2 = 58;

            // act

            // assert
            Assert.AreEqual(weight1, weight2);
        }

        [Test]
        public void TheSameScore()
        {
            // arrange
            int score1 = 150;
            int score2 = 150;

            // act

            // assert
            Assert.AreEqual(score1, score2);
        }

        private Employee GetUser(string name, string surname, string age) 
        {
            return new Employee(name, surname, age);

        }
    }
}
