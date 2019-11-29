using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanLucBMBLL
    {
        NhanLucBMAccess NLBMA = new NhanLucBMAccess();
        public List<ThongTinNhanLuc> HienThiNhanLucBM(string nam, string mabm)
        {
            return NLBMA.HienThiNhanLucBM(nam, mabm);
        }
    }
}
