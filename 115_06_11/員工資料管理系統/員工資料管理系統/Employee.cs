namespace 戈恨瞶╰参
{
    public class Employee
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        // 礚把计篶
        public Employee()
        {
            Name = "";
            IdNumber = 0;
            Department = "";
            Position = "";
        }

        // ㄢ把计篶
        public Employee(string name, int idNumber)
        {
            Name = name;
            IdNumber = idNumber;
            Department = "";
            Position = "";
        }

        // 把计篶
        public Employee(string name, int idNumber, string department, string position)
        {
            Name = name;
            IdNumber = idNumber;
            Department = department;
            Position = position;
        }

        // ToString 滦糶
        public override string ToString()
        {
            return $"{IdNumber}\t{Name}";
        }
    }
}
