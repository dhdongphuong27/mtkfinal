using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    internal abstract class AbstractFactory
    {
        public abstract Discount Discount();
        public abstract Bonus Bonus();
    }
}
