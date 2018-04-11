using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetCreater.Infrstr
{
    public static class Logger
    {
        public static void AddRecordToLog(string message)
        {
            string path = "log.txt";
            if (!File.Exists(path))
            {
                File.Create(path);  //.Close();
                //System.IO.FileStream f = System.IO.File.Create(path);
                //f.Close();
            }
            string text = DateTime.Now + " " + Environment.NewLine + message + Environment.NewLine;
            File.AppendAllText(path, text);
        }
    }
}
