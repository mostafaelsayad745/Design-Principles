
namespace SOLID.OCP.After
{
    class MatchQuestion : Question
    {
        public Dictionary<string, string> Rows { get; set; }
            = new Dictionary<string, string>();
        public override void print()
        {
            Console.WriteLine($"{Title} [{Mark}]");

            foreach (var item in Rows)
            {
                Console.WriteLine($"{item.Key}            {item.Value}");
            }
        }
    }
}