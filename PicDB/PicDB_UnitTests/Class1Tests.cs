using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicDB.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void methodTest()
        {
            Class1 class1 = new Class1();

            Assert.AreEqual(class1.method(), 4);
        }
    }
}