using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PolyantsevEI.Sprint2.Task1.V7.Lib
{
    public class DataService : ISprint2Task1V7
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (c == d);
            res[1] = (a == d) & (b > c);
            res[2] = (c >= d) || (a == b+20);
            res[3] = (a <= c) && ( b !=d);
            res[4] = !(a < c);
            res[5] = (b-2 == c) ^ (a != d);

            return res;
        }
    }
}
