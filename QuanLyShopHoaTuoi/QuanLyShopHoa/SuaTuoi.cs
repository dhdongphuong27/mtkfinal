﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    class SuaTuoi : ThucUong
    {
        public override int GetCost()
        {
            return 400;
        }

        public override string GetDescription()
        {
            return "Sua Tuoi";
        }
    }
}
