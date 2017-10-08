using System.Collections.Generic;

namespace Kpo4311_hnv.Lib
{
    public interface ICompanyListLoader
    {
        List<Company> companyList { get; }

        void Execute();
    }
}