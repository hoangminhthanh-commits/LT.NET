using Bai5._5.DAL;
using System.Data;

namespace Bai5._5.BUS
{
    public class NhaCungCapBUS
    {
        private NhaCungCapDAL dal =
            new NhaCungCapDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }
    }
}