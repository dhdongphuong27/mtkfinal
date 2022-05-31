using QuanLyShopHoa.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    internal class ObserverHangHoa : Observer
    {
        
        String query;
        public ObserverHangHoa(DetailPaymentChange dpc) : base(dpc)
        {
            detail = dpc;
        }

        public override void Update()
        {
            query = "UPDATE hanghoa SET SL = SL -" + detail.getSl() + " WHERE MaHH = '" + detail.getId() + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
