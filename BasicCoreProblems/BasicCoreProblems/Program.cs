class Swap2Num
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int temp;

        Console.WriteLine("Before Swapping: Value of a={0}, b={1}", a, b);

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After Swapping: Value of a={0}, b={1}", a, b);
        Console.ReadLine();
    }
}