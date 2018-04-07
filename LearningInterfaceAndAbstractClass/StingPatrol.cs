using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClass
{
    public class StingPatrol : Worker
    {
        public int AlertLevel { get; private set; }
        public int StingerLength { get; set; }
        public bool SharpenStinger(int Length)
        {
            return true;
        }
        public bool LookForEnemies() { return true; }


        public interface IStingPatrol //That's how interface look like
        {
            int AlertLevel { get; }
            int StingerLenght { get; set; }
            bool LookForEnemies();
            int SharpenStinger(int Length);
        }
    }
}
