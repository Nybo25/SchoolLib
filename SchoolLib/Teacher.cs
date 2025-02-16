namespace SchoolLib
{
    public class Teacher : Person
    {
        private int _salary;

        public int Salary
        {
            get => _salary;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary must be >= 0");
                }
                _salary = value;
            }
        }

        public Teacher(int id, string name, int salary) : base(id, name)
        {
            this.Salary = salary;
        }

        public Teacher() : this(-1, "Unknown", 0) { }

        public override string ToString()
        {
            return base.ToString() + " " + Salary;
        }
    }
}