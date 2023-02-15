namespace Interface_Segregation_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Before.Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.PrintSalarySlip());
            }
            Console.WriteLine("*************************************");
            var employees1 = After.Repository.LoadEmployees();
            foreach (var employee in employees1)
            {
                Console.WriteLine(employee.PrintSalarySlip());
            }
        }
    }
}