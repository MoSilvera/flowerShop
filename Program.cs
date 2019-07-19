using System;

namespace flower_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Flowershop BetterThanGoldenrodFlower = new Flowershop();

            BetterThanGoldenrodFlower.MakeMothersDayBouqet()
            .ForEach(flower => Console.WriteLine(flower));

            BetterThanGoldenrodFlower.MakeBirthdayBouqet()
            .ForEach(flower => Console.WriteLine(flower));
    }
    }
}
