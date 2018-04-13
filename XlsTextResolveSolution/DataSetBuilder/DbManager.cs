using DataSetCreater.Infrstr;
using DbLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetCreater
{
    public static class DbManager
    {
        const string _dbConnectionString = "User ID=genka;password=genka;Data Source=CD_WORK";

        static OracleConnect _con;

        public static void CreateConnect()
        {
            try
            {
                _con = new OracleConnect(_dbConnectionString);
                _con.OpenConnect();
            }
            catch (Exception ex)
            {
                Logger.AddErrorToLog(ex.Message);
            }
        }

        //public static void ExecCommand(string command)
        //{
        //    try
        //    {
        //        if (_con != null)
        //        {
        //            _con.ExecCommand(command);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.AddErrorToLog(ex.Message);
        //    }
        //}



    }
}
