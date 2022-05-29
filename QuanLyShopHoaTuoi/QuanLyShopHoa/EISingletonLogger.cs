using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace QuanLyShopHoa
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
        public void WriteMessage(string message, string date)
        {
            date = date.Replace("/", "-");
            string exeFile = (new System.Uri(System.Reflection.Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            string path = exeDir + "\\Logs\\" + date + ".txt";
            StreamWriter sw;
            System.IO.Directory.CreateDirectory(exeDir + "\\Logs");

            if (!File.Exists(path))
                sw = File.CreateText(path);
            else
                sw = new StreamWriter(path, true);
            sw.WriteLine(message + "\n");
            sw.Close();
        }
    }
}
