class Swap2Num
{
    static void Main(String[] args)
    {
        int a = 10;
        int b = 30;
        int temp;
        
        Console.WriteLine("Before Swapping: Value of a={0}, b={1}", a, b);

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After Swapping: Value of a={0}, b={1}", a, b);
        Console.ReadLine();
    }
}