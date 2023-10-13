using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PolyantsevEI.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            int mp=m;
            int np;
            if (n == 1)
            {
                mp = m - 1;
                switch (mp)
                {
                    case 1: np = 31; break;
                    case 2: np = 28; break;
                    case 3: np = 31; break;
                    case 4: np = 30; break;
                    case 5: np = 31; break;
                    case 6: np = 30; break;
                    case 7: np = 31; break;
                    case 8: np = 31; break;
                    case 9: np = 30; break;
                    case 10: np = 31; break;
                    case 11: np = 30; break;
                    case 12: np = 31; break;
                    default: np = 0; break;
                }
            }
            else np = n - 1;

            string date = ($"{np}.{mp}");
            return date;
        }
    }
}
