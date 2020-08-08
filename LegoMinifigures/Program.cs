using LegoMinifigures.HomeBuilder;
using LegoMinifigures.SuperMarket;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            //SuperMarket

            var superMarketEmployee1 = new SuperMarketWorker("Bill Agote", "Stocker", 29, true);
            var superMarketEmployee2 = new SuperMarketWorker("Sarah Goe", "Register", 20, false);
            var superMarketEmployee3 = new SuperMarketWorker("Adrian Yo", "Register", 33, false);
            var superMarketEmployee4 = new SuperMarketWorker("Joe Page", "Butcher", 44, true);
            var superMarketEmployee5 = new SuperMarketWorker("Alan Lovell", "Bagger", 17, true);


            superMarketEmployee1.StocksFood();
            superMarketEmployee2.RingsUpFood();
            superMarketEmployee3.RingsUpFood();
            superMarketEmployee4.CutsMeat();
            superMarketEmployee5.BagsFood();

            //Construction

            var constructionWorker1 = new ConstructionWorker("Dale", true, HeadSize.Large, ArmSize.Huge, BodySize.Muscular, LegSize.Long, FootSize.Normal);
            var construtionWorker2 = new ConstructionWorker("Denise", false, HeadSize.Small, ArmSize.Normal, BodySize.Normal, LegSize.Short, FootSize.Tiny);
            var constructionWorker3 = new ConstructionWorker("PeeWee", true, HeadSize.Small, ArmSize.Skinny, BodySize.Skinny, LegSize.Short, FootSize.Normal);

            constructionWorker1.Hammer();
            construtionWorker2.Climb();
            constructionWorker3.Lift();
        }
    }
}
