namespace Topic_4_User_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;

            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + name.ToUpper());

            int age;
            double price;

            Console.WriteLine("Enter you age:");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Your age is: " + age);
            Console.ReadLine();

            Console.WriteLine();
            Double discount;
            Console.WriteLine("What is the price?");
            Double.TryParse(Console.ReadLine(), out price);
            discount = price * 0.2;
            price = price - discount;
            Console.WriteLine("The price is " + price.ToString("C"));
            Console.WriteLine();

            string topping, name;
            Double price, total, diameter, radius;

            //Console.WriteLine("What is your favorite pizza topping?");
            topping = Console.ReadLine();
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hey " + name + " my favorite topping is also " + topping);

            //Console.WriteLine("What is the item name that your buying?");
            name = Console.ReadLine();
            Console.WriteLine("What is the price of the item?");
            price = Double.Parse(Console.ReadLine());
            total = price * 3;
            Console.WriteLine("It costs " + total.ToString("C") + " to buy 3 of them");

            Console.WriteLine("What is the diameter of the circle?");
            diameter = Double.Parse(Console.ReadLine());
            radius = diameter / 2;
            Console.WriteLine("the radius is " + radius);
        }
    }
}
