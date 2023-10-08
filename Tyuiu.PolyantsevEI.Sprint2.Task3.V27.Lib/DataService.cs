using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PolyantsevEI.Sprint2.Task3.V27.Lib
{
    public class DataService : ISprint2Task3V27
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 0) y = Math.Round(x * Math.Pow(((x + 1) / (Math.Sin(x * x) + x - 0.5)), x), 3);
            else if (x == 0) y = Math.Round((x * x - Math.Cos(x * x) + 4) / (x * x - Math.Sin(x * x) + 12), 3);
            else if (x < 0 && x > -31) y = Math.Round(Math.Pow(1 + (1 / (x * x)), 2), 3);
            else if (x < -31) y = Math.Round(x + Math.Sin(Math.Pow(x, 5)) + (Math.Pow(x, 3)) - (2 / x), 3);
            
            return y;
        }
    }
}
