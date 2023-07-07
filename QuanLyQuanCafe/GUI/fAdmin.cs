using Lê_Văn_Linh_QuanLyCafeCrambon.DAO;
using Lê_Văn_Linh_QuanLyCafeCrambon.DTO;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();

        BindingSource accountList = new BindingSource();

        BindingSource categoryList = new BindingSource();

        BindingSource tableList = new BindingSource();

        BindingSource departmentList = new BindingSource();

        BindingSource staffList = new BindingSource();

        public Account loginAccount;

        public fAdmin()
        {
            InitializeComponent();
            Load();
        }

        #region methods

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }
        List<Staff> SearchStaffByName(string name)
        {
            List<Staff> listStaff = StaffDAO.Instance.SearchStaffByName(name);

            return listStaff;
        }
        void Load()
        {
            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;
            dtgvCategory.DataSource = categoryList;
            dtgvTable.DataSource = tableList;
            dtgvDepartment.DataSource = departmentList;
            dtgvStaff.DataSource = staffList;

            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListFood();
            LoadListCategory();
            LoadListTable();
            LoadAccount();
            LoadCategoryIntoCombobox(cbFoodCategory);
            LoadDepartmentIntoCombobox(cbDepartment);
            LoadListDepartment();
            LoadListStaff();

            AddFoodBinding();
            AddAccountBinding();
            AddCategoryBinding();
            AddTableBinding();
            AddDepartmentBinding();
            AddStaffBinding();
        }
        void LoadListTable()
        {
            tableList.DataSource = TableDAO.Instance.GetListTable1();
        }
        void LoadListDepartment()
        {
            departmentList.DataSource = DepartmentDAO.Instance.GetListDepartment1();
        }
        void LoadListStaff()
        {
            staffList.DataSource = StaffDAO.Instance.GetListStaff();
        }
        void AddStaffBinding()
        {
            txbStaffID.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbStaffName.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "Name", true, DataSourceUpdateMode.Never));
            dtpkStaffDateBirth.DataBindings.Add(new Binding("Value", dtgvStaff.DataSource, "DateBirth", true, DataSourceUpdateMode.Never));
            dtpkStaffDateWorkIn.DataBindings.Add(new Binding("Value", dtgvStaff.DataSource, "DateWorkIn", true, DataSourceUpdateMode.Never));
            nmStaffSalary.DataBindings.Add(new Binding("Value", dtgvStaff.DataSource, "Salary", true, DataSourceUpdateMode.Never));
            txbStaffAddress.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txbStaffPhone.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "Phonenumber", true, DataSourceUpdateMode.Never));

        }

        void AddDepartmentBinding()
        {
            txbDepartmentID.DataBindings.Add(new Binding("Text", dtgvDepartment.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbDepartmentName.DataBindings.Add(new Binding("Text", dtgvDepartment.DataSource, "name", true, DataSourceUpdateMode.Never));
            txbDepartmentCount.DataBindings.Add(new Binding("Text", dtgvDepartment.DataSource, "countStaff", true, DataSourceUpdateMode.Never));
        }

        void AddCategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Mã", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Tên danh mục", true, DataSourceUpdateMode.Never));
            txbCategoryStatus.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Trạng thái", true, DataSourceUpdateMode.Never));
        }
        void LoadListCategory()
        {
            categoryList.DataSource = FoodCategoryDAO.Instance.GetListCategory1();
        }
        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Tên đăng nhập", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Tên hiển thị", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Loại tài khoản", true, DataSourceUpdateMode.Never));
        }
        void AddTableBinding()
        {
            txbTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Mã", true, DataSourceUpdateMode.Never));
            txbTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Tên bàn", true, DataSourceUpdateMode.Never));
            txbTableStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Trạng thái", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        void AddFoodBinding()
        {
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
            txbFoodStatus.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = FoodCategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void LoadDepartmentIntoCombobox(ComboBox cb)
        {
            cb.DataSource = DepartmentDAO.Instance.GetListDepartment();
            cb.DisplayMember = "Name";
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void AddCategory(string name)
        {
            if (FoodCategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công");
                if (insertCategory != null)
                    insertCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại");
            }
            LoadListCategory();
        }
        void EditCategory(int id, string name)
        {
            if (FoodCategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Cập nhập danh mục thành công");
                if (updateCategory != null)
                    updateCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập danh mục thất bại");
            }
            LoadListCategory();
        }
        void DeleteCategory(int id)
        {
            if (FoodCategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa danh mục thành công");
                if (delCategory != null)
                    delCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Xóa danh mục thất bại");
            }
            LoadListCategory();
        }

        void AddDepartment(string name)
        {
            if (DepartmentDAO.Instance.InsertDepartment(name))
            {
                MessageBox.Show("Thêm bộ phận thành công");

            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại");
            }
            LoadListDepartment();
        }
        void EditDepartment(int id, string name)
        {
            if (DepartmentDAO.Instance.UpdateDepartment(id, name))
            {
                MessageBox.Show("Cập nhập danh mục thành công");
            }
            else
            {
                MessageBox.Show("Cập danh mục thất bại");
            }
            LoadListDepartment();
        }
        void DeleteDepartment(int id)
        {
            if (DepartmentDAO.Instance.DeleteDepartment(id))
            {
                MessageBox.Show("Xóa danh mục thành công");
            }
            else
            {
                MessageBox.Show("Xóa danh mục thất bại");
            }
            LoadListDepartment();
        }

        void AddTableFood(string name)
        {
            if (TableDAO.Instance.InsertTableFood(name))
            {
                MessageBox.Show("Thêm bàn ăn thành công");
                if (insertTable != null)
                    insertTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm bàn ăn thất bại");
            }
            LoadListTable();
        }
        void EditTableFood(int id, string name)
        {
            if (TableDAO.Instance.UpdateTableFood(id, name))
            {
                MessageBox.Show("Cập nhập tên bàn ăn thành công");
                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhập tên bàn ăn thất bại");
            }
            LoadListTable();
        }
        void DeleteTableFood(int id, string status)
        {
            if (status == "Có người")
            {
                MessageBox.Show("Không thể xóa bàn đang có người!");
                return;
            }

            if (TableDAO.Instance.DeleteTableFood(id))
            {
                MessageBox.Show("Xóa bàn ăn thành công");
                if (delTable != null)
                    delTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Xóa bàn ăn thất bại");
            }
            LoadListTable();
        }
        void AddAccount(string userName, string displayName, int type)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Tên tài khoản đã có, yêu cầu nhập lại tên tài khoản!");
                return;
            }

            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (loginAccount.UserName.Equals(userName) && type == 0)
            {
                MessageBox.Show("Không cập nhập được loại tài khoản của chính bạn");
                return;

            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại");
                }
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }
        #endregion

        #region events
        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["IdCategory"].Value;

                    FoodCategory category = FoodCategoryDAO.Instance.GetCategoryByFoodID(id);

                    cbFoodCategory.SelectedItem = category;

                    int index = -1;
                    int i = 0;
                    foreach (FoodCategory item in cbFoodCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbFoodCategory.SelectedIndex = index;
                }
            }
            catch { }
        }



        private void btnSearchFood_Click(object sender, EventArgs e)

        {
            foodList.DataSource = SearchFoodByName(txbSearchFoodName.Text);
        }



        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as FoodCategory).ID;
            float price = (float)nmFoodPrice.Value;
            string status = txbFoodStatus.Text;
            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                { insertFood(this, new EventArgs()); }

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as FoodCategory).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txbFoodID.Text);
            string status = txbFoodStatus.Text;
            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {

                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);
            string status = txbFoodStatus.Text;
            if (status == "Đã lưu hành")
            {
                MessageBox.Show("Không xóa được món đã lưu hành!");
                return;
            }

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        private event EventHandler delCategory;
        public event EventHandler DelCategory
        {
            add { delCategory += value; }
            remove { delCategory -= value; }
        }

        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }

        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler delTable;
        public event EventHandler DelTable
        {
            add { delTable += value; }
            remove { delTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }




        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmAccountType.Value;

            AddAccount(userName, displayName, type);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmAccountType.Value;

            EditAccount(userName, displayName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            DeleteAccount(userName);
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            ResetPass(userName);
        }

        private void btnFirstBillPage_Click(object sender, EventArgs e)
        {
            txbPageBill.Text = "1";
        }

        private void btnLastBillPage_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetNumBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            int lastPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
                lastPage++;

            txbPageBill.Text = lastPage.ToString();
        }

        private void txbPageBill_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txbPageBill.Text));
        }

        private void btnPrevioursBillPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPageBill.Text);
            if (page > 1)
                page--;
            else if (page == 1)
                page = 1;
            txbPageBill.Text = page.ToString();
        }

        private void btnNextBillPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPageBill.Text);
            int sumRecord = BillDAO.Instance.GetNumBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            int lastPage = sumRecord / 10;
            if (sumRecord % 10 != 0)
                lastPage++;
            if (page < lastPage) page++;

            txbPageBill.Text = page.ToString();
        }
        #endregion

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            AddCategory(name);
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);
            string name = txbCategoryName.Text;
            EditCategory(id, name);
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);
            string status = txbCategoryStatus.Text;
            if (status == "Đã lưu hành")
            {
                {
                    MessageBox.Show("Không xóa được danh mục đã lưu hành!");
                    return;
                }
            }

            DeleteCategory(id);
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;
            AddTableFood(name);
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTableID.Text);
            string name = txbTableName.Text;
            EditTableFood(id, name);
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTableID.Text);
            string status = txbTableStatus.Text;
            DeleteTableFood(id, status);
        }

        private void btnShowDepartment_Click(object sender, EventArgs e)
        {
            LoadListDepartment();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {

            string name = txbDepartmentName.Text;
            AddDepartment(name);

        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            string name = txbDepartmentName.Text;
            int id = Convert.ToInt32(txbDepartmentID.Text);
            EditDepartment(id, name);
        }

        private void btnDeleteDeparrtment_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbDepartmentID.Text);
            DeleteDepartment(id);
        }

        private void txbStaffID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvStaff.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvStaff.SelectedCells[0].OwningRow.Cells["IdDepartment"].Value;

                    Department department = DepartmentDAO.Instance.GetDepartmentByID(id);

                    cbDepartment.SelectedItem = department;

                    int index = -1;
                    int i = 0;
                    foreach (Department item in cbDepartment.Items)
                    {
                        if (item.ID == department.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbDepartment.SelectedIndex = index;
                }
            }
            catch { }



        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string name = txbStaffName.Text;
            int idDepartment = (cbDepartment.SelectedItem as Department).ID;
            string db = dtpkStaffDateBirth.Value.ToString("yyyy-MM-dd");
            float salary = (float)nmStaffSalary.Value;
            string address = txbStaffAddress.Text;
            string phonenumber = txbStaffPhone.Text;
            if (StaffDAO.Instance.InsertStaff(name, db, idDepartment, salary, address, phonenumber))
            {
                MessageBox.Show("Thêm nhân  viên thành công");
                LoadListStaff();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhân viên");
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbStaffID.Text);

            if (StaffDAO.Instance.DeleteStaff(id))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                LoadListStaff();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa nhân viên");
            }
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            staffList.DataSource = SearchStaffByName(txbSearchStaffName.Text);
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            LoadListStaff();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            string name = txbStaffName.Text;
            int idDepartment = (cbDepartment.SelectedItem as Department).ID;
            string db = dtpkStaffDateBirth.Value.ToString("yyyy-MM-dd");
            string dw = dtpkStaffDateWorkIn.Value.ToString("yyyy-MM-dd");
            float salary = (float)nmStaffSalary.Value;
            string address = txbStaffAddress.Text;
            string phonenumber = txbStaffPhone.Text;
            int id = Convert.ToInt32(txbStaffID.Text);
            if (StaffDAO.Instance.UpdateStaff(name, db, dw, idDepartment, salary, address, phonenumber, id))
            {
                MessageBox.Show("Thêm nhân  viên thành công");
                LoadListStaff();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhân viên");
            }
        }
    }

}

