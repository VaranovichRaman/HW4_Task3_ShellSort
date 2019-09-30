using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Task3_Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort.ShellSort(Create.CreateArray());
            Console.ReadLine();
        }
    }
}
