using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4311_hnv.Lib
{
    public interface ICompanyAbstractFactory
    {
         ICompanyListLoader CompanyListSplitFileLoader(string dataFileName);
         ICompanyListSaver CompanyListSplitFileSaver(string dataFileName);
    }
}
