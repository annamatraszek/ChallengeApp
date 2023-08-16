namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        private List<float> grades = new List<float>();

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                case "":
                    this.grades.Add(100);
                    break;
                case "-6":
                case "6-":
                    this.grades.Add(95);
                    break;
                case "+5":
                case "5+":
                    this.grades.Add(85);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "-5":
                case "5-":
                    this.grades.Add(75);
                    break;
                case "+4":
                case "4+":
                    this.grades.Add(65);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "-4":
                case "4-":
                    this.grades.Add(55);
                    break;
                case "+3":
                case "3+":
                    this.grades.Add(45);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "-3":
                case "3-":
                    this.grades.Add(35);
                    break;
                case "+2":
                case "2+":
                    this.grades.Add(25);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "-2":
                case "2-":
                    this.grades.Add(15);
                    break;
                case "+1":
                case "1+":
                    this.grades.Add(10);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
                default:
                    throw new Exception("False grade.");
            }
        }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        Statistics IEmployee.GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 100:
                    statistics.AverageLetter = '6';
                    break;
                case var average when average >= 80:
                    statistics.AverageLetter = '5';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = '4';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = '3';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = '2';
                    break;
                default:
                    statistics.AverageLetter = '1';
                    break;
            }
            return statistics;
        }
    }
    
}
