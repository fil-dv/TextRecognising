using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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
            
    }

    

}
