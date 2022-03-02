using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEmployee
{
    public class EmployeeDetails
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double salary { get; set; }
        public string Gender { get; set; }
    }

    public class Logic
    {
        #region Login
        public string Login(string userid, string password)
        {
            if (string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(password))
            {
                return "userid or password cant be null";
            }
            else
            {
                if (userid == "Admin" && password == "admin")
                {
                    return "Welcome Admin";
                }
                else
                {
                    return "Incorrect username or password";
                }
            }
            #endregion

        }
        #region allusers
        public List<EmployeeDetails> AllUsers()
        {
            List<EmployeeDetails> li = new List<EmployeeDetails>();
            li.Add(new EmployeeDetails { id = 101, Name = "Nisha", Gender = "Female", salary = 30000 });
            li.Add(new EmployeeDetails { id = 102, Name = "Nishant", Gender = "male", salary = 36000 });
            li.Add(new EmployeeDetails { id = 101, Name = "minal", Gender = "Female", salary = 35000 });
            li.Add(new EmployeeDetails { id = 101, Name = "Adi", Gender = "male", salary = 40000 });
            return li;
        }
        #endregion

        public List<EmployeeDetails> GetDetails(int id)
        {
            List<EmployeeDetails> li1 = new List<EmployeeDetails>();
            Logic logic = new Logic();
            var liuser = logic.AllUsers();
            foreach (var x in liuser)
            {
                if (x.id == id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }

        class EmployeeProject
        {

        }

    }
}
