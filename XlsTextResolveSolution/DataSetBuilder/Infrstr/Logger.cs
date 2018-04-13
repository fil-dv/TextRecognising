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
        static string _path = "log.txt";
        static string _pathErr = "log_Err.txt";

        public static void AddRecordToLog(string message)
        {
            
            if (!File.Exists(_path))
            {
                File.Create(_path);  
            }
            string text = DateTime.Now + " " + Environment.NewLine + message + Environment.NewLine;
            File.AppendAllText(_path, text);
        }

        public static void AddErrorToLog(string message)
        {

            if (!File.Exists(_pathErr))
            {
                File.Create(_pathErr);
            }
            string text = DateTime.Now + " " + Environment.NewLine + message + Environment.NewLine;
            File.AppendAllText(_pathErr, text);
        }

        public static void ClearLog()
        {
            File.WriteAllText(_path, String.Empty);
        }
    }
}
