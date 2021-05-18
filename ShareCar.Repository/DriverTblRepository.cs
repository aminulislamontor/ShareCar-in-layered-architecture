using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareCar.Data;
using System.Data;
using ShareCar.Entity;
using ShareCar.Repository;

namespace ShareCar.Repository
{
    public class DriverTblRepository
    {
        private DataAccess Da { get; set; }

        public DriverTblRepository()
        {
            this.Da = new DataAccess();
        }

        public List<DriverTbl> GetAll(string key)
        {
            List<DriverTbl> driverList = new List<DriverTbl>();
            string sql;

            try
            {
                if (key == null)
                {
                    sql = "select * from DriverTbl";
                }
                else
                {
                    sql = "select * from DriverTbl where Name like '%" + key + "%' or DriverId like '%" + key + "%';";
                }
                var dt = this.Da.ExecuteQueryTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    DriverTbl p = ConvertToEntity(dt.Rows[ax]);
                    driverList.Add(p);
                }

                return driverList;
            }
            catch (Exception exc)
            {
                return null;
            }
        }



        public bool Save(DriverTbl d)
        {
            try
            {
                var sql = "insert into Product values('" + d.DriverId + "', '" + d.DriverName + "', '" + d.DriverContactNumber + "')";
                int count = this.Da.ExecuteDML(sql);
                if (count == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception exc)
            {
                return false;
            }
        }



        private DriverTbl ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }

            var driver = new DriverTbl();
            driver.DriverId = row["DriverId"].ToString();
            driver.DriverName = row["DriverName"].ToString();
            driver.DriverContactNumber = row["DriverName"].ToString();
            return driver;
        }
    }
}
