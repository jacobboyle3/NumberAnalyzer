public class Program
{
    public static bool Loop = true;
    public static void Main()
    {

        while (Loop == true)
        {
            Console.WriteLine($"Hello Please enter your name below:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter an integer between 0 and 100");
            int num = int.Parse(Console.ReadLine());
            bool even;
            if (num > 0 && num < 100)
            {
                Console.WriteLine("Thank you! ");
            }
            if (num % 2 == 0)
            {
                even = true;
            }
            else
            {
                even = false;
            }
            if (num <= 60 && even == false)
            {
                Console.WriteLine($"{name}, your number {num} is Odd and less than 60");
            }
            else if (num >= 2 && num <= 24 && even == true)
            {
                Console.WriteLine($"{name}, your number is even and less than 25");
            }
            else if (num >= 26 && num <= 60 && even == true)
            {
                Console.WriteLine($"{name}, your number is even and between 26 and 60 inclusive");
            }
            else if (num > 60 && even == true)
            {
                Console.WriteLine($"{name}, your number {num} is even and greater than 60");
            }
            else if (num > 60 && even == false)
            {
                Console.WriteLine($"{name}, your number {num} is odd and greater than 60");
            }
            Console.WriteLine($"Would you like to continue? ");
            string cont = Console.ReadLine().ToLower();
            if (cont == "yes")
            {
                Loop = true;
            }
            else
            {
                Loop = false;
            }


        }

    }
}