using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClass
{
    public class Worker: Bee
    {
        public Worker (string[] jobsICanDo, double weightMg): base(weightMg) 
        {
            this.jobsICanDo = jobsICanDo;
        }
        const double honeyConsumptionPerShift = .65; 
        private int shiftsToWork; 
        private int shiftsWorked;
        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
            
        }
        

        private string[] jobsICanDo;
        public bool DoThisJob(string job, int shiftsToWork) 
        {
            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (job == jobsICanDo[i] && String.IsNullOrEmpty(CurrentJob))
                {
                    currentJob = job;
                    this.shiftsToWork = shiftsToWork;
                    return true;
                }               
            }
            return false;
        }
        public bool DidYouFinish() 
        {
            if (ShiftsLeft == 0)
            {
                currentJob = "";
                shiftsToWork = 0;
                shiftsWorked = 0;
                return true;
            }
            else
                shiftsWorked++;
                return false;
        }
        public override double HoneyConsumptionRate()
        {
            double consumption = base.HoneyConsumptionRate();
            consumption += shiftsWorked * honeyConsumptionPerShift;
            return consumption;
        }



    }
}
