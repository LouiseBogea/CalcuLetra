using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityBussinessObjectLayer
{
   public class clsSaveToFinalDB
    {
        public string Word { get; set; }
        public double Frequency { get; set; } 
        public double Probability { get; set; }
        public double KnowingProbability { get; set; }
        public double NotKnowingProbability { get; set; }
        public double InformationQuantity { get; set; }
        //public double CommunicationEntropy { get; set; }//
        public int Id { get; set; }
        public double FinalEntropia { get; set; }
        
    }
}
