using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestTask
{
    public class Reversed2 : IHandler
    {
        private string[] allFoundFiles;

        public string[] Change(string path)
        {
            allFoundFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);            
            Revers(path);
            return allFoundFiles;
        }

        public void Revers(string path)
        {
            for (int i = 0; i < allFoundFiles.Length; i++)
            {
                allFoundFiles[i] = allFoundFiles[i].Remove(0, path.Length);
                allFoundFiles[i] = ReversPathString(allFoundFiles[i]);

            }
        }

        public string ReversPathString(string str)
        {
            char[] temp = str.ToArray();
            Array.Reverse(temp);
            str = new String(temp);
            return str;
        }
    }
}
