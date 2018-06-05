using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityBussinessObjectLayer
{
    public class ProbabilityCommon
    {
        public double MiniMumProbability { get; set; }

        public double MaximumProbability { get; set; }

        public double AverageProbability { get; set; }

        public string Word { get; set; }

        public int Frequency { get; set; }

        public double ProbabilityOfEachWord { get; set; }
    }
}
