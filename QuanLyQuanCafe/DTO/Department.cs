using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lê_Văn_Linh_QuanLyCafeCrambon.DTO
{
    public class Department
    {
        public Department(int id, string name, int countStaff)
        {
            this.ID = id;
            this.Name = name;
            this.CountStaff = countStaff;
        }

        public Department(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CountStaff = (int)row["countStaff"];
        }

        private int countStaff;

        public int CountStaff
        {
            get { return countStaff; }
            set { countStaff = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
