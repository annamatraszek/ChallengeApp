namespace challengeapp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void addgrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new    EventArgs());
                }
            }
            else
            {
                throw new Exception("nieprawidłowa wartość");
            }
        }

        public override void addgrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.addgrade(result);
            }
            else
            {
                throw new Exception("string is not float");
            }
        }

        public override void addgrade(int grade)
        {
            float value = grade;
            this.addgrade(value);
        }

        public override void addgrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Nieprawidłowa litera.");
            }
        }

        public override void AddGrade(double grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.addgrade(grade);
            }

            return statistics;
        }

    }
}
