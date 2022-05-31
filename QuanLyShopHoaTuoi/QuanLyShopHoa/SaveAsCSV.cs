using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    class SaveAsCSV : SaveToFile
    {
        private readonly SaveAsTXT sat;
        public SaveAsCSV(SaveAsTXT sat)
        {
            this.sat = sat;
        }
        public void WriteMessage(string message, string filename)
        {
            filename = filename.Replace("txt", "csv");
            message = message.Replace("\n", ", ");
            sat.WriteMessage(message, filename);
        
        }

    }
}
