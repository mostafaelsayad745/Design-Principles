namespace SOLID.OCP.After
{
    class MultipteChoiceQuestion : Question
    {
        public List<string> Choices { get; set; } = new List<string>();
        public override void print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            foreach (var choice in Choices)
            {
                Console.WriteLine($"   {choice}");
            }
        }
    }
}
