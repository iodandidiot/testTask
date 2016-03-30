using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestTask
{
    public class Reversed1 : IHandler,IHandlerReversed
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
                //string[] separator = new string[] {@"\"};
                //string[] temp = allFoundFiles[i].Split(separator,StringSplitOptions.None);
                //Array.Reverse(temp);
                //allFoundFiles[i] = ConcatString(temp);
                allFoundFiles[i] = ReversPathString(allFoundFiles[i]);
            }
        }

        public string ReversPathString(string str)
        {
            string[] separator = new string[] { @"\" };
            string[] temp = str.Split(separator, StringSplitOptions.None);
            Array.Reverse(temp);
            str = ConcatString(temp);
            return str;
        }

        private string ConcatString(string[] strArray)
        {
            string strReturn="";

            for (int i = 0; i < strArray.Length;i++ )
            {
                if (i != strArray.Length - 1)
                {
                    strReturn += strArray[i] + @"\";
                }
                else
                {
                    strReturn += strArray[i];
                }
            }
            return strReturn;
        }
    }
}
