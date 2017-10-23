using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4311_hnv.Lib
{
    public class CompanyTestFactory:ICompanyAbstractFactory
    {
        public ICompanyListLoader CompanyListSplitFileLoader(string dataFileName)
        {
            return new CompanyListTestLoader();
        }

        public ICompanyListSaver CompanyListSplitFileSaver(string dataFileName)
        {
            return new CompanyListTestSaver();
        }
    }
}
