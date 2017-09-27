using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4311.nmv.Lib
{
    public class MockCompanyListCommand
    {
        public MockCompanyListCommand()
        {

        }

        private readonly string _dataFileName = "";
        private List<Company> _companyList = null;

        public List<Company> companyList
        {
            get { return _companyList; }
        }

        public void Execute()
        {
            try
            {
                //throw new NotImplementedException();
                {
                    Company company = new Company()
                    {
                        category = 1,
                        loss = 12.7,
                        downtime = 4
                    };
                }
                {
                    Company company = new Company()
                    {
                        category = 1,
                        loss = 0.711,
                        downtime = 1
                    };
                }
                {
                    Company company = new Company()
                    {
                        category = 2,
                        loss = 1770.15,
                        downtime = 38
                    };
                }
            }
            catch (Exception ex)
            {
                Lib.LogUtility.ErrorLog(ex);
            }
        }
    }
}
