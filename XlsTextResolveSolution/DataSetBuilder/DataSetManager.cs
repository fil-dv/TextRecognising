using DataSetBuilder.Infrstr;
using DataSetCreater.Infrstr;
using Infrastructure.DataSetCreater;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DataSetCreater
{
    public static class DataSetManager
    {        
        
        //static int _counter = 0;

        public static bool SetSettings(string pathToFolder, TableName tableName)
        {
            bool isPathExists = Directory.Exists(pathToFolder);

            if (isPathExists)
            {
                DataSetSettings.PathToParseFolder = pathToFolder;
                DataSetSettings.Table = tableName;
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

        public static void GetSettings(ref string pathToFolder)
        {
            pathToFolder = DataSetSettings.PathToParseFolder;
        }

        public static void ParseFS(string path)
        {
            try
            {
                var dirs = Directory.EnumerateDirectories(path);
                foreach (var dir in dirs)
                {
                    List<FilesPair> FilesPairs = GetFilePairsForParse(dir);
                    foreach (var item in FilesPairs)
                    {
                        CsvParser(item);
                        //InsertData(item, ++_counter);
                    }
                    ParseFS(dir);
                }                
            }
            catch (Exception ex)
            {
                Logger.AddErrorToLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private static void CsvParser(FilesPair pair)
        {
            var lines = File.ReadAllLines(pair.PathToImp);
            int rowCount = lines.Length;
            int collCount = -1;
            if (rowCount > 0)
            {
                string[] cells = lines[0].Split(';');
                collCount = cells.Length;
            }
            else
            {
                throw new Exception("Csv file is empty.");
            }

            Record[] recArr = new Record[collCount];
            foreach (var item in recArr)
            {                
                item.CreateDate = File.GetCreationTime(pair.PathToImp);
                item.Table = DataSetSettings.Table.ToString();
                item.PathToCtrl = pair.PathToCtrl;
            }

            for (int i = 0; i < rowCount; i++)
            {
                string[] cells = lines[i].Split(';');
                for (int j = 0; j < collCount; j++)
                {
                    recArr[j].Text += (cells[j] + ";");
                }                
            }
        }

        private static string ConvertEncoding(string str)
        {
            Encoding ANSI = Encoding.GetEncoding(1252);

            byte[] ansiBytes = ANSI.GetBytes(str);
            byte[] utf8Bytes = Encoding.Convert(ANSI, Encoding.UTF8, ansiBytes);

            String utf8String = Encoding.UTF8.GetString(utf8Bytes);
            return utf8String;
        }

        private static void ControlParser(FilesPair pair)
        {

        }

        private static void InsertData(FilesPair rec, int count)
        {
            try
            {

                Logging(rec, count);                
            }
            catch (Exception ex)
            {
                Logger.AddErrorToLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private static void Logging(FilesPair rec, int count)
        {
            string str = "---------------------------" +
                            Environment.NewLine +
                            rec.PathToImp +
                            Environment.NewLine +
                            rec.PathToCtrl +
                            Environment.NewLine +
                            //rec.Table +
                            //Environment.NewLine +
                            //rec.CreateDate +
                            //Environment.NewLine +
                            //rec.Text.Substring(0, 100) +
                            //Environment.NewLine +
                            //rec.DbField +
                            //Environment.NewLine +
                            //count +
                            //Environment.NewLine +
                            "----------------------------";
            Logger.AddRecordToLog(str);
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
                        FilesPair fp = new FilesPair() { PathToCtrl = item, PathToImp = ctllArr[0]//,
                                                        //CreateDate = File.GetCreationTime(item),
                                                        //Table = DataSetSettings.Table.ToString()
                                                       };
                        fpList.Add(fp);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.AddErrorToLog(ex.Message);
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
                Logger.AddErrorToLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
            return csvName;
        }
    }

    

}
