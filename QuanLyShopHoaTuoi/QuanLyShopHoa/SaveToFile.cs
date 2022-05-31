using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    interface SaveToFile
    {
        public void WriteMessage(String message, String filename);
    }
}
