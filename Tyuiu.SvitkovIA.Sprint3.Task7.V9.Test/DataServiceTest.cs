using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SvitkovIA.Sprint3.Task7.V9.Lib;

namespace Tyuiu.SvitkovIA.Sprint3.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction1()
        {
            DataService ds = new DataService();
            int startValue = -5, stopValue = 5;
            double[] valueWaitArray = new double[(stopValue - startValue) + 1];
            valueWaitArray[0] = -27.22;
            valueWaitArray[1] = -22.25;
            valueWaitArray[2] = -16.66;
            valueWaitArray[3] = -11.04;
            valueWaitArray[4] = -6.13;
            valueWaitArray[5] = -3.0;
            valueWaitArray[6] = 4.84;
            valueWaitArray[7] = 8.86;
            valueWaitArray[8] = 14.43;
            valueWaitArray[9] = 20.18;
            valueWaitArray[10] = 25.24;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueWaitArray, result);

        }
    }
}