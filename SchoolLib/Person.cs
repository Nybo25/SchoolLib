namespace SchoolLib
{
    public abstract class Person
    {
        private string _name;
        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name is null");
                }
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentException("Name must be at least 1 character long");
                }
                _name = value;
            }
        }

        protected Person(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return Id + " " + Name;
        }
    }
}