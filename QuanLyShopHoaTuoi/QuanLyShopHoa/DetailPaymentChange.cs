using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    internal class DetailPaymentChange
    {
        private String id;
        private int sl;
        public DetailPaymentChange(String id, int sl)
        {
            this.id = id;
            this.sl = sl;
        }
        public String getId()
        {
            return id;
        }
        public int getSl()
        {
            return sl;
        }
    }
}
