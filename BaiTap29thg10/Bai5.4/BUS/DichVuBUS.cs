using System.Data;
using Bai5._4.DAL;

namespace Bai5._4.BUS
{
    public class DichVuBUS
    {
        private DichVuDAL dal =
            new DichVuDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }
    }
}