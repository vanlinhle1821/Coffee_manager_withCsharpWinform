using Lê_Văn_Linh_QuanLyCafeCrambon.DTO;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lê_Văn_Linh_QuanLyCafeCrambon.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; }
            private set { StaffDAO.instance = value; }
        }

        private StaffDAO() { }
        public DataTable GetListStaff1()
        {
            return DataProvider.Instance.ExecuteQuery("select * from dbo.Staff");
        }
        public List<Staff> GetListStaff()
        {
            List<Staff> list = new List<Staff>();

            string query = "select * from dbo.Staff";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                list.Add(staff);
            }

            return list;
        }
        public bool InsertStaff(string name, string datebirth, int idDepartment, float salary, string address,string phonenumber )//thêm món ăn
        {
            string query = string.Format("INSERT dbo.Staff ( name, dateBirth, idDepartment, salary, address, phonenumber )VALUES  ( N'{0}', '{1}', {2}, {3}, N'{4}', {5})", name, datebirth, idDepartment, salary, address, phonenumber);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateStaff(string name, string datebirth, string dateworkin, int idDepartment, float salary, string address, string phonenumber, int id)// sửa món ăn
        {
            string query = string.Format("UPDATE dbo.Staff SET name = N'{0}', dateBirth = '{1}', dateWorkIn = '{2}', idDepartment = {3}, salary = {4}, address= N'{5}', phonenumber = {6} WHERE id = {7}", name, datebirth, dateworkin , idDepartment, salary, address, phonenumber, id) ;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteStaff(int idStaff)//xóa món ăn
        {
            
            string query = string.Format("Delete Staff where id = {0}", idStaff);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Staff> SearchStaffByName(string name)//tìm món ăn
        {
            List<Staff> list = new List<Staff>();
            string query = string.Format("SELECT * FROM dbo.Staff " +
                "WHERE dbo.fuConvertToUnsign1(name) " +
                "LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                list.Add(staff);
            }
            return list;
        }

    }
}
