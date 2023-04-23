using ChallengeApp;
using System.Threading.Tasks.Sources;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectScore_ThenResult()
        {
            // arrange
            var employee = new Employee("Kasia", "Nowakowska", "46");
            employee.AddScore(5);
            employee.AddScore(2);
            employee.AddScore(3);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void WhenEmployeeCollectOneMinusScore_ThenResult()
        {
            // arrange
            var employee = new Employee("Kasia", "Nowakowska", "46");
            employee.AddScore(5);
            employee.AddScore(2);
            employee.AddScore(-3);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(4, result);
        }

        [Test]
        public void WhenEmployeeCollectSomeMinusScore_ThenResult()
        {
            // arrange
            var employee = new Employee("Kasia", "Nowakowska", "46");
            employee.AddScore(5);
            employee.AddScore(2);
            employee.AddScore(-3);
            employee.AddScore(3);
            employee.AddScore(-1);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void WhenEmployeeCollectSomeMinusScore_ThenResultMinus()
        {
            // arrange
            var employee = new Employee("Kasia", "Nowakowska", "46");
            employee.AddScore(5);
            employee.AddScore(2);
            employee.AddScore(-3);
            employee.AddScore(-10);
            employee.AddScore(-1);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(-7, result);
        }

        [Test]
        public void WhenEmployee1CollectScore_ThenResult()
        {
            // arrange
            var employee1 = new Employee("Adam", "Kowalski", "30");
            employee1.AddScore(6);
            employee1.AddScore(2);
            employee1.AddScore(10);
            employee1.AddScore(3);
            employee1.AddScore(0);

            // act
            var result = employee1.Result;

            // assert
            Assert.AreEqual(21, result);
        }

        [Test]
        public void WhenEmployee2CollectScore_ThenResult()
        {
            // arrange
            var employee2 = new Employee("Ewa", "Kowalska", "25");
            employee2.AddScore(10);
            employee2.AddScore(10);
            employee2.AddScore(8);
            employee2.AddScore(10);
            employee2.AddScore(6);

            // act
            var result = employee2.Result;

            // assert
            Assert.AreEqual(44, result);
        }

        [Test]
        public void WhenEmployee3CollectScore_ThenResult()
        {
            // arrange
            var employee3 = new Employee("Anna", "Kowalska", "28");
            employee3.AddScore(5);
            employee3.AddScore(1);
            employee3.AddScore(2);
            employee3.AddScore(8);
            employee3.AddScore(3);

            // act
            var result = employee3.Result;

            // assert
            Assert.AreEqual(19, result);
        }

        [Test]
        public void WhenEmployeeeSumScore_ThenMaxResult() 
        {
            // arrange
            var employee1 = new Employee("Adam", "Kowalski", "30");
            employee1.AddScore(6);
            employee1.AddScore(2);
            employee1.AddScore(10);
            employee1.AddScore(3);
            employee1.AddScore(0);

            var result1 = employee1.Result;

            var employee2 = new Employee("Ewa", "Kowalska", "25");
            employee2.AddScore(10);
            employee2.AddScore(10);
            employee2.AddScore(8);
            employee2.AddScore(10);
            employee2.AddScore(6);
            
            var result2 = employee2.Result;

            // act
            bool maxResult = result1 < result2;

            // assert
            Assert.AreEqual(true, maxResult); 
        }

    }

}