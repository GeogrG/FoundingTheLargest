using System;
using System.Collections.Generic;

namespace FoundingTheLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 1, 2, 3, 1, 2, 3, 4, 5677, 0, 11, 35, 64 ,246, 3};
            if (arry.Length != 0)
            {
                List<int> currentMaxSubArray = new List<int>();
                int curLenght = 1;
                int curMaxLength = 1;
                currentMaxSubArray.Add(arry[0]);
                for (int i = 1; i < arry.Length; i++)
                {
                    if (arry[i - 1] < arry[i])
                    {
                        curLenght++;
                    }
                    else
                    {
                        if (curLenght > curMaxLength)
                        {
                            curMaxLength = curLenght;
                            currentMaxSubArray.Clear();
                            for (int j = i - curMaxLength; j < i; j++)
                            {
                                currentMaxSubArray.Add(arry[j]);
                            }
                        }
                        curLenght = 1;
                    }
                }
                if (curLenght > curMaxLength)
                {
                    curMaxLength = curLenght;
                    currentMaxSubArray.Clear();
                    for (int j = arry.Length - curMaxLength; j < arry.Length; j++)
                    {
                        currentMaxSubArray.Add(arry[j]);
                    }
                }
                Console.WriteLine(curMaxLength);
                foreach(int element in currentMaxSubArray)
                {
                    Console.Write(element + ", ");
                }
            }
            else
            {
                Console.Write(0);
            }
        }
    }
}
