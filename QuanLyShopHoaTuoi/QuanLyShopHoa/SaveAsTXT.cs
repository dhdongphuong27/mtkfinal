using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    class SaveAsTXT
    {
        public SaveAsTXT()
        {

        }
        public void WriteMessage(string message, string filename)
        {
            string exeFile = (new System.Uri(System.Reflection.Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            string path = exeDir + "\\Logs\\" + filename;
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
