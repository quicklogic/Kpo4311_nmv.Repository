using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kpo4311_hnv.Lib;
using static Kpo4311_hnv.Lib.source.Utility.LoadStatuses;

namespace Kpo4311_hnv.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private static string DATAFILENAME = @"Company.txt";
        [TestMethod]
        public void TestMethod1()
        {
            ICompanyListLoader loader = AppGlobalSettings.GetCompanyAbstractFactory().CompanyListSplitFileLoader(DATAFILENAME);
            Assert.AreEqual(LoadStatus.None, loader.status);

            loader.Execute();

            Assert.AreEqual(LoadStatus.Success, loader.status);
            Assert.IsNotNull(loader.companyList);

            foreach (Company p in loader.companyList)
            {
                Assert.IsTrue(p.initialize <= DateTime.Now);
            }
        }
    }
}
