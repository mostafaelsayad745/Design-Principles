namespace SOLID.OCP.After
{
    class TrueFalseQuestion : Question
    {
        public override void print()
        {
            Console.WriteLine($"{Title} [{Mark}]");

            Console.WriteLine("1. T  ");
            Console.WriteLine("2. F  ");
           
        }
    }
}
