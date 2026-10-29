using Bai5._3.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bai5._3.BLL
{
    public class MonAnBLL
    {
        private MonAnDAL dal = new MonAnDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }
    }
}
