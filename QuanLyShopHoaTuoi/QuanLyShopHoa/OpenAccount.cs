using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class OpenAccount : Command
    {
        private Account acc;
        public OpenAccount(Account acc)
        {
            this.acc = acc;
        }
        public void execute()
        {
            acc.Open();
        }
    }
}
