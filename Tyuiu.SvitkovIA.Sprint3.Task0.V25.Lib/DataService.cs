using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SvitkovIA.Sprint3.Task0.V25.Lib
{
    public class DataService : ISprint3Task0V25
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for ( i = startValue; i <= stopValue; i ++)
            {
                sumSeries = sumSeries + (4 / (1 + Math.Pow(value, i))) * Math.Pow(i, i);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
