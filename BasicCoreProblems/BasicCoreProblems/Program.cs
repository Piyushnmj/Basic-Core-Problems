class EvenOrOdd
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num%2==0)
        {
            Console.WriteLine("Number is Even");
        }
        else
        {
            Console.WriteLine("Number is Odd");
        }
        Console.ReadKey();
    }
}