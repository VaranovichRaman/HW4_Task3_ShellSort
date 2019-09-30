using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Task3_Shell
{
    class Sort
    {
        public static int Distance { get; set; }
        public static void ShellSort(int[] array)
        {
            Distance = array.Length / 2;
            while (Distance >= 1)
            {
                for (var i = Distance; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= Distance) && (array[j - Distance] > array[j]))
                    {
                        var temp = array[j];
                        array[j] = array[j - Distance];
                        array[j - Distance] = temp;
                        j = j - Distance;
                    }
                }

                Distance = Distance / 2;
            }

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
