using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lê_Văn_Linh_QuanLyCafeCrambon.DTO
{
    public class Staff
    {
        public Staff(int id, string name, string gender, DateTime dateBirth, DateTime? dateWorkIn,int idDepartment, float salary, string address)
        {
            this.ID = id;
            this.Name = name;
            this.DateBirth = dateBirth;

            // kiểm tra null
            this.DateWorkIn = dateWorkIn;
            this.IdDepartment = idDepartment;
            this.Salary = salary;
            this.Address = address;
            this.Phonenumber = phonenumber;

        }

        public Staff(DataRow row)
        {
            {
                this.ID = (int)row["id"];
                this.Name = row["name"].ToString();

                this.DateBirth = (DateTime)row["dateBirth"];

                // kiểm tra null
                    this.DateWorkIn = (DateTime?)row["dateWorkIn"];
                this.IdDepartment = (int)row["idDepartment"];
                this.Salary = (float)Convert.ToDouble(row["salary"].ToString());
                this.Address = row["address"].ToString();
                this.Phonenumber = row["phonenumber"].ToString();
            }

        }

        private string phonenumber;
        public string Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }


        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        private float salary;
        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private int idDepartment;

        public int IdDepartment
        {
            get { return idDepartment; }
            set { idDepartment = value; }
        }

        private DateTime? dateWorkIn;
        public DateTime? DateWorkIn
        {
            get { return dateWorkIn; }
            set { dateWorkIn = value; }
        }

        private DateTime dateBirth;
        public DateTime DateBirth
        {
            get { return dateBirth; }
            set { dateBirth = value; }
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
