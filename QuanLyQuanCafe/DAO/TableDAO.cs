using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        // tao design patern singleton 
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        // khai báo biên cho button đại diện cho bàn ăn
        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private TableDAO() { }

        public DataTable GetListTable1()
        {
            return DataProvider.Instance.ExecuteQuery("select id as [Mã] , name as [Tên bàn] , status as [Trạng thái] from dbo.TableFood");
        }
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }

        public void MergeTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_MergeTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
           

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public List<Table> LoadTableListHas()
        {
            List<Table> tableList = new List<Table>();


            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.TableFood where status =N'Có người'");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public bool InsertTableFood(string name)
        {
            string query = string.Format("INSERT dbo.TableFood ( name, status )VALUES  ( N'{0}',N'Trống')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTableFood(int id, string name)
        {
            string query = string.Format("UPDATE dbo.TableFood SET name = N'{1}' WHERE id = {0}", id, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteTableFood(int id)
        {
            string query = string.Format("Delete TableFood where id = {0}", id );
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
