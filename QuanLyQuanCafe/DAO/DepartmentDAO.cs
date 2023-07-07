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
    public class DepartmentDAO
    {
        private static DepartmentDAO instance;

        public static DepartmentDAO Instance
        {
            get { if (instance == null) instance = new DepartmentDAO(); return DepartmentDAO.instance; }
            private set { DepartmentDAO.instance = value; }
        }

        private DepartmentDAO() { }
        public DataTable GetListDepartment1()
        {
            return DataProvider.Instance.ExecuteQuery("select * from dbo.Department");
        }
        public List<Department> GetListDepartment()//danh sách danh mục thức ăn
        {
            List<Department> list = new List<Department>();

            string query = "select * from Department";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Department Department = new Department(item);
                list.Add(Department);
            }

            return list;
        }
       public Department GetDepartmentByID(int id)// sắp xếp thức ăn theo id
        {
            Department department = null;

            string query = "select * from Department where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                department = new Department(item);
                return department;
            }

            return department;
        }
      
        public bool InsertDepartment(string name)
        {
            string query = string.Format("INSERT dbo.Department ( name)VALUES  ( N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateDepartment(int id, string name)
        {
            string query = string.Format("UPDATE dbo.Department SET name = N'{1}' WHERE id = {0}", id, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteDepartment(int id)
        {
            string query = string.Format("Delete Department where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
