namespace Topic_4_User_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String name;

            //Console.Write("What is your name? ");
            //name = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Hello " + name.ToUpper());

            Console.WriteLine();
            Double price, discount;
            Console.WriteLine("What is the price?");
            Double.TryParse(Console.ReadLine(), out price);
            discount = price * 0.2;
            price = price - discount;
            Console.WriteLine("The price is " + price.ToString("C"));
            Console.WriteLine();



        }
    }
}
