using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class CloseAccount : Command
    {
        private Account acc;
        public CloseAccount(Account acc)
        {
            this.acc = acc;
        }
        public void execute()
        {
            acc.Close();
        }
    }
}
