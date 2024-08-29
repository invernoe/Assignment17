namespace WebApplication1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"emp id = {Id}, emp name = {Name}";
        }
    }
}
