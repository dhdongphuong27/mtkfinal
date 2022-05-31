using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace QuanLyCuaHangTienLoi
{
    sealed class EISingletonLogger
    {
        private static readonly EISingletonLogger _logger = new EISingletonLogger();
        private EISingletonLogger()
        {
        }
        public static EISingletonLogger GetLogger()
        {
            return _logger;
        }
        public void WriteMessage(string message, string date, string type)
        {
            date = date.Replace("/", "-");
            SaveAsTXT sat = new SaveAsTXT();
            if (type == "txt")
            {  
                sat.WriteMessage(message, date + ".txt");
            }else if (type == "csv")
            {
                SaveToFile saveCSV = new SaveAsCSV(sat);
                saveCSV.WriteMessage(message, date + ".txt");
            }
            
            


        }
    }
}
