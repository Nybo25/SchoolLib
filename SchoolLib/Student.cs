namespace SchoolLib
{
    public class Student : Person
    {
        private int _semester;

        public int Semester
        {
            get => _semester;
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("Semester must be between 1 and 5");
                }
                _semester = value;
            }
        }

        public Student(int id, string name, int semester) : base(id, name)
        {
            this.Semester = semester;
        }

        public Student() : this(-1, "Unknown", 1) { }

        public override string ToString()
        {
            return base.ToString() + " " + Semester;
        }
    }
}