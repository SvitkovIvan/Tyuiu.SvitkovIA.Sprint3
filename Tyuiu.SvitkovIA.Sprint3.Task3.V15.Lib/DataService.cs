using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SvitkovIA.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {

            string input = "lrmmse mg sermmmrt";
            int count = 0;
            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (word[i - 1] == 'm' && word[i] == 'm')
                    {
                        count++;
                    }
                }
            }

            return count;
        }

    }
}

     
