using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.SuperMarket
{
    class SuperMarketWorker
    {
        //properties
        public string Name { get; set; }
        public string Job { get; set; }
        public int Age { get; set; }

        //fields
        public bool _isMale = true;

        //constructor
        public SuperMarketWorker(string name, string job, int age, bool isMale)
        {
            Name = name;
            Job = job;
            Age = age;
            _isMale = isMale;
        }

        //methods
        public void CutsMeat()
        {
            throw new NotImplementedException();
        }

        public void StocksFood()
        {
            throw new NotImplementedException();
        }

        public void BagsFood()
        {
            throw new NotImplementedException();
        }

        public void RingsUpFood()
        {
            throw new NotImplementedException();
        }
    }
}
