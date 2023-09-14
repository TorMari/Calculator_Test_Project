using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalaizerClassLibrary;
using System;
using System.Data;

namespace AnalizerClassLibraryTests
{
    [TestClass]
    public class AnalizerClassTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("System.Data.SqlClient",
            "Data Source=WIN-8SNIO6IEEFI;Initial Catalog=CalculatorTests;Integrated Security=True",
            "tests",
            DataAccessMethod.Sequential)]
        public void AnalaizerClass_Estimate_FormDB()
        {
            string expression = TestContext.DataRow["expression"].ToString();
            string expected = TestContext.DataRow["result"].ToString();
            string res = "";
            try
            {
                AnalaizerClass.expression = expression;
                res = AnalaizerClass.Estimate();
                Assert.AreEqual(expected, res);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(res.StartsWith("&Error"));
            }
        }
    }
}

