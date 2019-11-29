using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class SachCKbll
    {
        SachCKAccess SCKA = new SachCKAccess();
        public List<Sach> DisplaySachCK(string magv, string nam)
        {
            return SCKA.DisplaySachCK(magv, nam);
        }
    }
}
