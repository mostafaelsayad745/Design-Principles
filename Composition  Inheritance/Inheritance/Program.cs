using System.ComponentModel.Design;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Choice = 0;
            do
            {
                Console.Clear();
                Choice = ReadChoice(Choice);
                if (Choice >= 1 && Choice <=3)
                {
                    var pizza = CreatPizza(Choice);
                    Console.WriteLine(pizza);
                    Console.WriteLine("Press any key to continue (0 to exit)");
                }
                Console.ReadKey();
            } while (Choice != 0);
        }

        private static Pizza CreatPizza(int choice)
        {
            Pizza pizza = null!;
            switch (choice)
            {
                case 1:
                    pizza = new Chicken();
                    break;
                case 2:
                    pizza = new Mexican();
                    break;
                case 3:
                    pizza = new Vegeterian();
                    break;

                default:
                    break;
            }
            return pizza;
        }

        private static int ReadChoice(int choice)
        {
            Console.WriteLine("Today's Menu");
            Console.WriteLine("------------");
            Console.WriteLine("1. Chicken ") ;
            Console.WriteLine("2. Vegeterian");
            Console.WriteLine("3. Mexican");
            Console.WriteLine("what is your order:");
            if (int.TryParse(Console.ReadLine(), out int ch))
            {
                choice = ch;
            }
            return choice;
        }
       
    }
    class Pizza
    {
        public virtual string Title => $"{nameof(Pizza)}";
        public virtual decimal Price => 10m;
        private static void Prepare()
        {
            Console.Write("preparing....");
            Thread.Sleep(500);
            Console.WriteLine("completed");
        }
        private static void Cook()
        {
            Console.Write("preparing....");
            Thread.Sleep(500);
            Console.WriteLine("completed");
        }
        private static void Cut()
        {
            Console.Write("preparing....");
            Thread.Sleep(500);
            Console.WriteLine("completed");
        }
        public override string ToString()
        {
            return $"\n{Title}" +
                   $"\n\tPrice: {Price.ToString("c")}";
        }

    }
    class Mexican : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Mexican)}";
        public override decimal Price => base.Price + 3m;

    }
    class Chicken : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Chicken)}";
        public override decimal Price => base.Price + 4m;

    }
    class Vegeterian : Pizza
    {
        public override string Title => $"{base.Title} {nameof(Vegeterian)}";
        public override decimal Price => base.Price + 5m;

    }
}