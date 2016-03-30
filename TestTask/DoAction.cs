using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestTask
{
    class DoAction
    {
        public string curDir;
        public IHandler actionHandler;
        public string destDir = @"c:/Users/user/Documents/results.txt";

        public void Start()
        {
            string temp = Console.ReadLine();
            if (Directory.Exists(temp))
            {
                curDir = temp;
            }
            else
            {
                Console.WriteLine("---------------Please try again------------");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Select the directory like the example below");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-------------------C:/dir/-----------------");
                Console.WriteLine("-------------------------------------------");
                Start();
            }
        }
        public void CheckCurAction(bool first = true)
        {
            if (!first)
            {
                Console.WriteLine("-------------Please try again--------------");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("--Select the action like the example below-");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("--------all,cpp,reversed1,reversed2--------");
                Console.WriteLine("-------------------------------------------");
            }
            string curAct = Console.ReadLine();
            switch (curAct)
            {
                case "all":
                    actionHandler = new All();
                    break;
                case "cpp":
                    actionHandler = new Cpp();
                    break;
                case "reversed1":
                    actionHandler = new Reversed1();
                    break;
                case "reversed2":
                    actionHandler = new Reversed2();
                    break;
                default:
                    CheckCurAction(false);
                    break;
            }

        }
        public void Destination()
        {
            string temp = Console.ReadLine();
            if (temp != "")
            {
                destDir = temp;
            }
            ChangeAndRead();
        }

        public void ChangeAndRead()
        {

            string[] allFoundFiles = actionHandler.Change(curDir);
            StringBuilder sb = new StringBuilder();
            foreach (string txtName in allFoundFiles)
            {
                sb.AppendLine(txtName);
                sb.AppendLine("= = = = = =");
                sb.AppendLine();

            }
            try
            {
                using (StreamWriter outfile =
                new StreamWriter(destDir))
                {
                    outfile.Write(sb.ToString());
                }
            }
            catch 
            {
                Console.WriteLine("--------------Please try again--------------");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Select the dirrectory like the example below");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("-------------C:/dir/results.txt-------------");
                Console.WriteLine("--------------------------------------------");
                Destination();
            }
            
        }
    }
}
