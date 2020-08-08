using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.HomeBuilder
{
    class ConstructionWorker
    {
        //properties
        public string Name { get; set; }
        public HeadSize WorkerHeadSize { get; set; }
        public ArmSize WorkerArmSize { get; set; }
        public BodySize WorkerBodySize { get; set; }
        public LegSize WorkerLegSize { get; set; }
        public FootSize WorkerFootSize { get; set; }

        //fields
        public bool _isMale = true;
        
        //constructor
        public ConstructionWorker(string name, bool isMale, HeadSize workerHeadSize, ArmSize workerArmSize, BodySize workerBodySize, LegSize workerLegSize, FootSize workerFootSize)
        {
            Name = name;
            _isMale = isMale;
            WorkerHeadSize = workerHeadSize;
            WorkerArmSize = workerArmSize;
            WorkerBodySize = workerBodySize;
            WorkerLegSize = workerLegSize;
            WorkerFootSize = workerFootSize;
        }

        //methods
        public void Saw()
        {
            throw new NotImplementedException();
        }

        public void Climb()
        {
            throw new NotImplementedException();
        }

        public void Hammer()
        {
            throw new NotImplementedException();
        }

        public void Crawl()
        {
            throw new NotImplementedException();
        }

        public void Lift()
        {
            throw new NotImplementedException();
        }

        public void Pull()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }

    enum HeadSize
    {
        Small,
        Medium,
        Large
    }

    enum ArmSize
    {
        Skinny,
        Normal,
        Huge
    }

    enum BodySize
    {
        Skinny,
        Normal,
        Fat,
        Muscular
    }

    enum LegSize
    {
        Short,
        Medium,
        Long
    }

    enum FootSize
    {
        Tiny,
        Normal,
        Long,
        Wide
    }
}
