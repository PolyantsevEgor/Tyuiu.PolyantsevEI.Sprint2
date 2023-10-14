﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PolyantsevEI.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return ((Math.Pow(x, 2) + Math.Pow(y-1, 2))<1 && y < (1 - Math.Pow(x,2)));
        }
    }
}
