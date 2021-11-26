using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByndyusoftTestingTask
{
    public class ArrayAnalysis
    {
        public static bool IsNumber(object item)
        {
            bool isNum;
            if ((item is string) || (item is char) || (item is bool) || (item is null))
                isNum = false;
            else
                isNum = true;
            return isNum;
        }

        public static double SumOfTwoMins(ArrayList array)
        {
            if (array is null)
                throw new ArgumentNullException("Array is null");
            if (array.Count == 0)
                throw new ArgumentException("Array is empty");
            if (array.Count < 2)
                throw new ArgumentException("Array is too short");

            if (!IsNumber(array[0]) || !IsNumber(array[1]))
                throw new ArgumentException("Not all elements in an array are numbers");
            double min1 = Math.Min(Convert.ToDouble(array[0]), Convert.ToDouble(array[1]));
            double min2 = Math.Max(Convert.ToDouble(array[0]), Convert.ToDouble(array[1]));

            for (int i = 2; i < array.Count; i++)
            {
                if (!IsNumber(array[i]))
                    throw new ArgumentException("Not all elements in an array are numbers");
                double item = Convert.ToDouble(array[i]);
                if (item < min1)
                {
                    min2 = min1;
                    min1 = item;
                }
                else if (item < min2)
                {
                    min2 = item;
                }
            }
            return min1 + min2;
        }
    }
}
