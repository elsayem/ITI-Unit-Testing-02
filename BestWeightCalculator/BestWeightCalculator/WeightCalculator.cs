using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace BestWeightCalculator
{
    public class WeightCalculator
    {
        public double Height { get; set; }
        public char Gender { get; set; }


        public double GetBestWeight()
        {
            switch (Gender)
            {
                case 'm':

                    return (Height - 100) - ((Height - 150) / 4);

                case 'w':
                    return (Height - 100) - ((Height - 150) / 2);


                default:
                    return 0;
            }


        }
    }
}
