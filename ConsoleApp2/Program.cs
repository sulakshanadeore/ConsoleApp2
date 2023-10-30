using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void shellSortArray(int[] arr, int n)
        {
            //56,12,99,32,95,78,11,67
            int j, pos, temp;
            pos = 3;
            while (pos>0)
            {
                for (int i = 0; i < n; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= pos) && (arr[j-pos]>temp))
                    {
                        arr[j] = arr[j - pos];
                        j = j - pos;
                    }
                    arr[j] = temp;
                }
                if (pos / 2 != 0)
                {
                    pos = pos / 2;
                }
                else if (pos == 1)
                {
                    pos = 0;
                }
                else
                {
                  pos=1;
                }

                }
            }


        


        static void Main(string[] args)
        {

            int[] arr = new int[] {56,12,99,32,95,78,11,67,345,678,2344,23  };
            int arrLen=arr.Length;
            foreach(int i in arr)
            {
                Console.WriteLine(i);

            }
            shellSortArray(arr,arrLen);

            Console.WriteLine("Sorted Array......");
            foreach (int i in arr)
            {
                Console.WriteLine(i);

            }
            Console.Read();
        }
    }
}

