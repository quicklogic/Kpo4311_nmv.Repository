using System.Collections.Generic;

namespace Kpo4311_hnv.Lib
{
    public interface ICompanyListSaver
    {
        List<Company> companyList { set; }

        void Execute(List<Company> list);
    }
}