using Empresa;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empoyee> empoyees = new List<Empoyee>();

            Console.Write("How many employees will be registered? ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= number; i++)
            {
                Console.Write("id: ");
                int idfor = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                empoyees.Add(new Empoyee(idfor, name, salary));

                Console.WriteLine();
            }

            Console.Write("Enter the empoyee id that will have salary increase: ");
            int id = int.Parse(Console.ReadLine());

            Empoyee hasId = empoyees.Find(x => x.Id == id);

            if (hasId != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                hasId.IncreaseSalary(percentage);
            } else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");

            foreach (Empoyee e in empoyees)
            {
                Console.WriteLine(e);
            }
        }
    }
}