<<<<<<< HEAD
﻿class Swap2Num
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter a value: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int i = 0;

        for (i = 1; i <= N; i++)
        {
            if ( N % i == 0)
            {
                Console.WriteLine(i + " is a Factor of " + N);
            }
            else
            {
                Console.WriteLine(i + " is not a Factor of " + N);
            }
=======
﻿class Powerof2
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter the power value: ");
        long N = Convert.ToInt32(Console.ReadLine());
        int num = 2;
        for (var i = 0; i < N; i++)
        {
            Console.WriteLine(num);
            num = num * 2;
>>>>>>> PowerOf2
        }
        Console.ReadLine();
    }
}