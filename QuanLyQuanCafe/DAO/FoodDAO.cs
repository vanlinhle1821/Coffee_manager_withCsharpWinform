using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food where idCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "select * from dbo.Food";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public DataTable GetListFood1()
        {
            return DataProvider.Instance.ExecuteQuery("select ID as [Mã], Name as [Tên], IdCategory as [Loại danh mục], Price as [Giá], Status as [Trạng thái] from dbo.Food");
        }
        public List<Food> SearchFoodByName(string name)//tìm món ăn
        {
            List<Food> list = new List<Food>();
            string query = string.Format("SELECT * FROM dbo.Food " +
                "WHERE dbo.fuConvertToUnsign1(name) " +
                "LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {          Food food = new Food(item);
                  list.Add(food);}
            return list;
        }
        public DataTable SearchFoodByName1(string name)//tìm món ăn
        {
           
            string query = string.Format("SELECT ID as [Mã], Name as [Tên], IdCategory as [Loại danh mục], Price as [Giá], Status as [Trạng thái] FROM dbo.Food " +
                "WHERE dbo.fuConvertToUnsign1(name) " +
                "LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            return DataProvider.Instance.ExecuteQuery(query);
        
        }
        public bool InsertFood(string name, int id, float price)//thêm món ăn
        {
            string query = string.Format("INSERT dbo.Food ( name, idCategory, price, status )VALUES  ( N'{0}', {1}, {2},N'Chưa lưu hành')", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateFood(int idFood, string name, int id, float price)// sửa món ăn
        {
            string query = string.Format("UPDATE dbo.Food SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, id, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteFood(int idFood)//xóa món ăn
        {   BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);
            string query = string.Format("Delete Food where id = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void DeleteFoodByCategoryID(int id)// xóa món ăn trong danh muc
        {
            DataProvider.Instance.ExecuteQuery("Delete FROM dbo.Food where idCategory=" + id);
        }
    }
}
