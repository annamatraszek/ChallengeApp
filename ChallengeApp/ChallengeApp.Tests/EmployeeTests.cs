
namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsCalled_ThenReturnCorrectMax()
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
        public void WhenGetStatisticsCalled_ThenReturnCorrectMin()
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
        public void WhenGetStatisticsCalled_ThenReturnCorrectAverage()
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

        [Test]
        public void WhenGetStatisticsAverage_ThenReturnCorrectAverageLetter_A()
        {
            // arrange
            var employee = new Employee("Kasia", "Nowakowska");
            employee.AddGrade(100);
            employee.AddGrade(90);
            employee.AddGrade(70);
            employee.AddGrade(60);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('A', statistics.AverageLetter);
        }

        [Test]
        public void WhenGetStatisticsAverage_ThenReturnCorrectAverageLetter_B()
        {
            // arrange
            var employee = new Employee("Kasia", "Nowakowska");
            employee.AddGrade(100);
            employee.AddGrade(60);
            employee.AddGrade(20);
            employee.AddGrade(60);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('B', statistics.AverageLetter);
        }
        [Test]
        public void WhenGetStatisticsAverage_ThenReturnCorrectAverageLetter_C()
        {
            // arrange
            var employee = new Employee("Kasia", "Nowakowska");
            employee.AddGrade(80);
            employee.AddGrade(20);
            employee.AddGrade(35);
            employee.AddGrade(25);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('C', statistics.AverageLetter);
        }

        [Test]
        public void WhenGetStatisticsAverage_ThenReturnCorrectAverageLetter_D()
        {
            // arrange
            var employee = new Employee("Kasia", "Nowakowska");
            employee.AddGrade(60);
            employee.AddGrade(20);
            employee.AddGrade(5);
            employee.AddGrade(15);
            employee.AddGrade(0);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('D', statistics.AverageLetter);
        }

        [Test]
        public void WhenGetStatisticsAverage_ThenReturnCorrectAverageLetter_E()
        {
            // arrange
            var employee = new Employee("Kasia", "Nowakowska");
            employee.AddGrade(0);
            employee.AddGrade(10);
            employee.AddGrade(20);
            employee.AddGrade(5);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('E', statistics.AverageLetter);
        }

    }
}