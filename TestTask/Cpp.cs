using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TestTask
{
    class Cpp : IHandler
    {
        private string[] allFoundFiles;

        public string[] Change(string path)
        {
            allFoundFiles = Directory.GetFiles(path, "*.cpp", SearchOption.AllDirectories);
            for (int i = 0; i < allFoundFiles.Length; i++)
            {
                allFoundFiles[i] = allFoundFiles[i].Remove(0, path.Length);
            }
            return allFoundFiles;

        }
    }
}
