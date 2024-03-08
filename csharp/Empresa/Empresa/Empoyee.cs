namespace Empresa
{
    internal class Empoyee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Empoyee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary = Salary + (Salary * (percentage / 100));
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2")}";
        }
    }
}
