﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SvitkovIA.Sprint3.Task7.V11.Lib;

namespace Tyuiu.SvitkovIA.Sprint3.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction1()
        {
            DataService ds = new DataService();
            int startValue = 5, stopValue = 5;
            double[] valueWaitArray = new double[(stopValue - startValue) + 1];
            valueWaitArray[0] = 20.36;
            valueWaitArray[1] = 15.42;
            valueWaitArray[2] = 10.99;
            valueWaitArray[3] = 7.43;
            valueWaitArray[4] = 4.33;
            valueWaitArray[5] = 1.0;
            valueWaitArray[6] = 0.0;
            valueWaitArray[7] = -8.87;
            valueWaitArray[8] = -13.03;
            valueWaitArray[9] = -16.53;
            valueWaitArray[10] = -19.6 ;

            double[] result = ds.GetMassFunction(startValue, stopValue);
        }
    }
}
