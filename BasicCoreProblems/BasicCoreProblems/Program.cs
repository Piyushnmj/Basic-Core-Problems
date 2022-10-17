class FlipCoin
{
    static void Main(String[] args)
    {
        double heads = 0;
        int coinFlipLoop = 1;
        
        while (coinFlipLoop <= 10000)
        {
            Random random = new Random();
            int coinFlip = random.Next(0, 2);

            if (coinFlip <= .5)
                heads++;

            coinFlipLoop = coinFlipLoop + 1;
        }
        double percentHeads = (heads / 10000) * 100;
        double percentTails = ((10000 - heads) / 10000) * 100;

        Console.WriteLine("The percentage of heads is: " + percentHeads);
        Console.WriteLine("The percentage of tails is: " + percentTails);
        Console.ReadLine();
    }
}