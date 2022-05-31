using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    class Remote
    {
        private Command openAcc;
        private Command closeAcc;
        public Remote(Command opAcc, Command clAcc)
        {
            openAcc = opAcc;
            closeAcc = clAcc;
        }
        public void clickOpenAccount()
        {
            openAcc.execute();
        }
        public void clickCloseAcc()
        {
            closeAcc.execute();
        }
    }
}
