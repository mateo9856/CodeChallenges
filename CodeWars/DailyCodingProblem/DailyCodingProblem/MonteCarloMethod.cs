using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    public class MonteCarloMethod
    {
        public string GetByMonteCarlo()
        {
            int cPoints = 0, sPoints = 0, interval = 1000;
            var rand = new Random();
            double x = 0, y = 0, pi = 0;
            for(int i = 0; i < (interval * interval); i++)
            {
                x = (double)(rand.Next() % (interval + 1)) / interval;
                y = (double)(rand.Next() % (interval + 1)) / interval;
                
                var d = (x*x) + (y*y);

                if (d <= 1) cPoints++;
                sPoints++;
                pi = ((4.0 * cPoints) / sPoints);
            }

            return pi.ToString("#.000");
        }
    }
}
