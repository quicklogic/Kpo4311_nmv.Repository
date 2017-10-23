using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4311_hnv.Lib
{
    public class CompanyListSplitFileFactory : ICompanyAbstractFactory
    {
        public ICompanyListLoader CompanyListSplitFileLoader(string dataFileName)
        {
            return new CompanyListSplitFileLoader(dataFileName);
        }

        public ICompanyListSaver CompanyListSplitFileSaver(string dataFileName)
        {
            return new CompanyListSplitFileSaver(dataFileName);
        }
    }
}
