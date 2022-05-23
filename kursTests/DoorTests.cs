using Microsoft.VisualStudio.TestTools.UnitTesting;
using kurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// cs0012c.cs  
// compile with: /reference:cs0012b.dll  

namespace kurs.Tests
{
    [TestClass()]
    public class DoorTests
    {
        [TestMethod()]
        public void  LoginingTest()
        {
            string Password = "12345678";
            string Email = "Ivandurak@mail.ru";
            bool expected = true;
            //act
            bool actual = Door.Logining(Email, Password) ; 

            Assert.AreEqual(expected , actual);
        }
    }
}