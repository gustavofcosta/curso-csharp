namespace EmpresaWorker.Entities
{
    internal class Department
    {
        public string Name { get; private set; }

        public Department() { }

        public Department(string name)
        {
            Name = name;
        }
    }

}
