﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SvitkovIA.Sprint3.Task6.V3.Lib
{
    public class DataService : ISprint3Task6V3
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int result = 0;

            for (int i = 13; i <= 19; i++)
            {
                int sum = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }

                if (sum > 8)
                {
                    result += sum;
                }
            }

            return result;


        }
    }
}
