

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ThereAreDifferentEmployees()
        {
            // arrange
            var employee1 = new Employee("Kasia", "Nowakowska");
            var employee2 = new Employee("Magda", "Nowakowska");

            // act
            
            // assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void TheSameSurname()
        {
            // arrange
            var employee1 = new Employee("Kasia", "Nowakowska");
            var employee2 = new Employee("Magda", "Nowakowska");
          
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

        private Employee GetUser(string name, string surname) 
        {
            return new Employee(name, surname);

        }
    }
}
