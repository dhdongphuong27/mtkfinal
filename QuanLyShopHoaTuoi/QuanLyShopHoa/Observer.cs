using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    internal abstract class Observer
    {
        protected DetailPaymentChange detail;
        public Observer(DetailPaymentChange dpc) { }
        public DetailPaymentChange Getdpc()
        {
            return detail;
        }
        public abstract void Update();
    }
}
