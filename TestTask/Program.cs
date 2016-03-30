using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestTask
{
    class Program
    {
        static DoAction doProgram;
        static void Main(string[] args)
        {
            Console.WriteLine("---------Please, enter dirrectory----------");
            Console.WriteLine("-------------------------------------------");
            doProgram = new DoAction();
            doProgram.Start();
            Console.WriteLine("-----------Please, enter action------------");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("--Select the action like the example below-");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("--------all,cpp,reversed1,reversed2--------");
            Console.WriteLine("-------------------------------------------");
            doProgram.CheckCurAction();
            Console.WriteLine("----Please, enter destination dirrectory---");
            Console.WriteLine("-------------------------------------------");
            doProgram.Destination();
        }

       

        static void Print(string[] array)
        {
            foreach (string i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
