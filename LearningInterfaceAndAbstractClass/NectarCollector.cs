using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClass
{
    public class NectarCollector : Worker
    {

        public int Nectar { get; set; }
        public void FindFlowers() { }
        public void GatherNectar() { }
        public void ReturnToHive() { }

        public interface INectarCollector //That's how interface look like
        {
            void FindFlowers();
            void GatherNectar();
            void ReturnToHive();
        }

    }
}
