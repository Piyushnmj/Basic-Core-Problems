class QuotientAndRemainder
{
    static void Main(String[] args)
    {
<<<<<<< HEAD
        Console.WriteLine("Enter a Dividend: ");
        int dividend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a Divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());
=======
        Console.WriteLine("Enter value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int temp;
        
        Console.WriteLine("Before Swapping: Value of a={0}, b={1}", a, b);
>>>>>>> Swap2Num

        int quotient = dividend / divisor;
        int remainder = dividend % divisor;

        Console.WriteLine("Quotient = " + quotient);
        Console.WriteLine("Remainder = " + remainder);
        Console.ReadLine();
    }
}