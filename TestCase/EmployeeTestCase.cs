using NUnit.Framework;
using PrjEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase
{
    internal class EmployeeTestCase
    {
        List<EmployeeDetails> li;
        Logic logic=new Logic();
        [Test]
        public void CheckDetails()
        {
            li=logic.AllUsers();
            foreach(var item in li)
            {
                Assert.IsNotNull(item.id);
                Assert.IsNotNull(item.Name);
                Assert.IsNotNull(item.Gender);
                Assert.IsNotNull(item.salary);
            }
        }

        [Test]
        public void TestLogin()
        {
            string a = logic.Login("Kani", "123");
            string b = logic.Login("", "");
            string c = logic.Login("Admin", "admin");

            Assert.AreEqual("Incorrect username or password", a);
            Assert.AreEqual("userid or password cant be null", b);
            Assert.AreEqual("Welcome Admin", c);
        }

    }
}
