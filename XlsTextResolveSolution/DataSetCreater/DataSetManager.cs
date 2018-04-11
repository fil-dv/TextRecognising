using DataSetCreater.Infrstr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataSetCreater
{
    public static class DataSetManager
    {
        public static bool SetSettings(string pathToFolder, decimal rowsDepth, decimal maxSetCount)
        {
            bool isPathExists = Directory.Exists(pathToFolder);
            bool isRowsDepthOk = rowsDepth > 0 ? true : false;
            bool ismaxSetCount = maxSetCount > 0 ? true : false;

            if (isPathExists && isRowsDepthOk && ismaxSetCount)
            {
                DataSetSettings.PathToParseFolder = pathToFolder;
                DataSetSettings.XlsRowsDepth = rowsDepth;
                DataSetSettings.MaxEntityCount = maxSetCount;
                DataSetSettings.IsInitialise = true;
            }
            else
            {
                DataSetSettings.IsInitialise = false;
            }
            return DataSetSettings.IsInitialise;
        }

        public static bool IsSettingInit()
        {
            return DataSetSettings.IsInitialise;
        }

        public static void GetSettings(ref string pathToFolder, ref decimal rowsDepth, ref decimal maxSetCount)
        {
            pathToFolder = DataSetSettings.PathToParseFolder;
            rowsDepth = DataSetSettings.XlsRowsDepth;
            maxSetCount = DataSetSettings.MaxEntityCount;
        }

        public static void ParseFS(string path)
        {
            try
            {
                var dirs = Directory.EnumerateDirectories(path);
                foreach (var dir in dirs)
                {
                    List<FilesPair> filesForParse = GetFilePairsForParse(dir);
                    foreach (var item in filesForParse)
                    {
                        InsertDataToXml(item.PathToImp, item.PathToCtrl);
                    }
                    ParseFS(dir);
                }                
            }
            catch (Exception ex)
            {
                Logger.AddRecordToLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private static void InsertDataToXml(string pathToImp, string pathToCtrl)
        {
            try
            {
                string str = "----------------------------" + 
                            Environment.NewLine + 
                            pathToImp + 
                            Environment.NewLine +
                            pathToCtrl + 
                            Environment.NewLine + 
                            "----------------------------";
                Logger.AddRecordToLog(str);
            }
            catch (Exception ex)
            {
                Logger.AddRecordToLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private static List<FilesPair> GetFilePairsForParse(string dirName)
        {
            List<FilesPair> fpList = new List<FilesPair>();
            try
            {                
                var ctrlArr = Directory.GetFiles(dirName, "*.ctl"); // ищем все контролы
                foreach (var item in ctrlArr)
                {
                    string csvName = GetCsvName(item);
                    var ctllArr = Directory.GetFiles(dirName, csvName);
                    if (ctllArr.Length > 0)
                    {
                        FilesPair fp = new FilesPair() { PathToImp = item, PathToCtrl = ctllArr[0] };
                        fpList.Add(fp);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.AddRecordToLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
            return fpList;
        }

        private static string GetCsvName(string path)
        {
            string csvName = "";
            try
            {
                var lines = File.ReadAllLines(path);
                string str = lines[1];
                csvName = str.Substring(8, str.LastIndexOf('\'') - 8);
            }
            catch (Exception ex)
            {
                Logger.AddRecordToLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
            return csvName;
        }
    }

    

}
