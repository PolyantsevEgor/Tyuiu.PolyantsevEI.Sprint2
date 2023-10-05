using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PolyantsevEI.Sprint2.Task2.V8.Lib
{
    public class DataService : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((y == 2 && x > 8 && x < 12) || (y == 5 && x > 2 && x < 10) || (y == 6 && x > 2 && x < 14) || (y == 10 && x > 5 && x < 10) || (y == 11 && x > 2 && x < 10) || (y == 12 && x > 6 && x < 10) || (y == 3 && ((x > 2 && x < 6) || (x > 8 && x < 13))) || (y == 4 && ((x > 2 && x < 6) || (x > 8 && x < 12))) || (y == 7 && ((x > 2 && x < 7) || (x > 8 && x < 15))) || (y == 9 && ((x > 5 && x < 10) || (x > 11 && x < 14))) || (y == 8 && (x == 6 || x == 9 || x == 12 || x == 13)))
                return true;
            else
                return false;
        }
    }
}
