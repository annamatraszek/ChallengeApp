
namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsCalled_TenReturnCorrectMax()
        {
            // arrange
            var employee = new Employee("Kasia", "Nowakowska");
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_TenReturnCorrectMin()
        {
            // arrange
            var employee = new Employee("Kasia", "Nowakowska");
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(2, statistics.Min);
        }

        
        [Test]
        public void WhenGetStatisticsCalled_TenReturnCorrectAverage()
        {
            // arrange
            var employee = new Employee("Kasia", "Nowakowska");
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(4.0, 1), Math.Round(statistics.Average, 1));
        }

    }

}