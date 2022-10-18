class QuotientAndRemainder
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter a Dividend: ");
        int dividend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a Divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        int quotient = dividend / divisor;
        int remainder = dividend % divisor;

        Console.WriteLine("Quotient = " + quotient);
        Console.WriteLine("Remainder = " + remainder);
        Console.ReadLine();
    }
}