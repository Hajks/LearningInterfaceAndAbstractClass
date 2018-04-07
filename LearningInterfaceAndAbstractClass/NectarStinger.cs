using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClass
{
    public class NectarStinger: Worker, INectarCollector, IStingPatrol //That's how we de declare interface
    {
        public int AlertLevel { get; private set; }
        public int StingerLength { get; set; }
        public int Nectar { get; set; }
 
        public bool LookForEnemies() { return true; }
        public bool SharpenStinger(int Length)
        {
            return true;
        }
        public void FindFlowers() { }
        public void GatherNectar() { }
        public void ReturnToHive() { }
    }
}
