namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
           : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Nieprawidłowa wartość");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(result);
                }
            }
            else
            {
                throw new Exception("Nieprawidłowa wartość");
            }
        }

        public override void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    float value = grade;
                    writer.WriteLine(value);
                }
            }
            else
            {
                throw new Exception("Nieprawidłowa wartość");
            }
        }

        public override void AddGrade(char grade)
        {
            throw new Exception("Nieprawidłowa wartość");
        }

        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    float value = (float)grade;
                    writer.WriteLine(value);
                }
            }
            else
            {
                throw new Exception("Nieprawidłowa wartość");
            }
        }
        

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            foreach (var number in grades)
            {
                statistics.Max = Math.Max(statistics.Max, number);
                statistics.Min = Math.Min(statistics.Min, number);
                statistics.Average += number;
            }
            statistics.Average /= grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
