using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ThongTinGVBMbll
    {
        ThongTinGVBMAccess TTGVBM = new ThongTinGVBMAccess();
        public List<GiaoVien> DisplayTTGVBM(string magv, string nam)
        {
            return TTGVBM.DisplayTTGVBM(magv, nam);
        }
    }
}
