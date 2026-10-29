using Bai5._3.DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace Bai5._3.BLL
{
    public class BanAnBLL
    {
        private BanAnDAL dal = new BanAnDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public void CapNhatTrangThai(int maBan, string trangThai)
        {
            dal.CapNhatTrangThai(maBan, trangThai);
        }
    }
}
