﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozyrevRA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numbOne, int[] numTwo)
        {
            int[] resultArray = new int[5];
            for (var i=0;i<resultArray.Length; i++)
            {
                resultArray[i] = numbOne[i]+numTwo[i];
            }
            return resultArray;
        }
    }
}
