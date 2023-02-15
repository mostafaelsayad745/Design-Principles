namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Choice = 0;
            var pizza = new Pizza();
            do
            {
                Console.Clear();
                Choice = ReadChoice(Choice);
                if (Choice >= 1 && Choice <= 6)
                {
                    ITopping topping = null!;
                    topping = switching(Choice);
                    pizza.AddTopping(topping);
                    Console.WriteLine("Press any key to continue (0 to exit)");
                }
                Console.ReadKey();
            } while (Choice != 0);
            Console.WriteLine(pizza);
            Console.ReadKey();
        }

        private static ITopping switching(int Choice)
        {
            switch (Choice)
            {
                case 1:
                    return new Tomato();
                case 2:
                    return new Chesse();
                case 3:
                    return new Chicken();
                case 4:
                    return new GreenPepper();
                case 5:
                    return new BlackOlives();
                case 6:
                    return new Beef();
                default:
                    return null!;
            }

            
        }

        private static int ReadChoice(int choice)
        {
            Console.WriteLine("Today's Menu");
            Console.WriteLine("------------");
            Console.WriteLine("1. Tomato ");
            Console.WriteLine("2. Chesse");
            Console.WriteLine("3. Chicken");
            Console.WriteLine("4. GreenPepper");
            Console.WriteLine("5. BlackOlives");
            Console.WriteLine("6. Beef");
            Console.WriteLine("Add topping:");
            if (int.TryParse(Console.ReadLine(), out int ch))
            {
                choice = ch;
            }
            return choice;
        }
    }
    class Pizza
    {
        public virtual decimal Price => 10m;
        public List<ITopping> Toppings { get; private set; } = new List<ITopping>();

        public void AddTopping (ITopping topping) => Toppings.Add(topping);
        public decimal Calculate()
        {
            var total = Price;
            foreach (var item in Toppings)
            {
                total += item.Price;
            }
            return total;
        }
        public override string ToString()
        {
           var output = $"\n {nameof(Pizza)}";
            output += $"\n\t Base Price : {Price.ToString("C")}";
            foreach (var topping in Toppings)
            {
                output += $"\n\t {topping.Title} ({topping.Price.ToString("C")})";
            }
            output += "\n---------------------------";
            output += $"\n Total : {Calculate().ToString("C")}";
            return output;
        }

    }
    public interface ITopping
    {
        string Title { get; }
        decimal Price { get; }
    }
    class Chicken : ITopping
    {
        public string Title => nameof(Chicken);

        public decimal Price => 6m;
    }
    class Chesse : ITopping
    {
        public string Title => nameof(Chesse);

        public decimal Price => 5m;
    }
    class BlackOlives : ITopping
    {
        public string Title => nameof(BlackOlives);

        public decimal Price => 4m;
    }
    class Tomato : ITopping
    {
        public string Title => nameof(Tomato);

        public decimal Price => 3m;
    }
    class GreenPepper : ITopping
    {
        public string Title => nameof(GreenPepper);

        public decimal Price => 2.5m;
    }
    class Beef : ITopping
    {
        public string Title => nameof(Beef);

        public decimal Price => 10m;
    }
}