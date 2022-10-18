class LargestNum
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter a value for x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a value for y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a value for z: ");
        int z = Convert.ToInt32(Console.ReadLine());

        if (x > y && x > z)
        {
            Console.WriteLine("x is greater");
        }
        else if (y > x && y > z)
        {
            Console.WriteLine("y is greater");
        }
        else
        {
            Console.WriteLine("z is greater");
        }
        Console.ReadLine();
    }
}