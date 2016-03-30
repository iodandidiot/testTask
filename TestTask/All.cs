using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestTask
{
    class All : IHandler
    {
        private string[] allFoundFiles;

        public string[] Change(string path)
        {
            allFoundFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            for (int i = 0; i < allFoundFiles.Length; i++)
            {
                allFoundFiles[i] = allFoundFiles[i].Remove(0, path.Length);
            }
            return allFoundFiles;

        }

    }
}
