namespace SOLID.OCP.After
{
    class WHQuestion : Question
    {
        public override void print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
          
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
        }
    }
}
