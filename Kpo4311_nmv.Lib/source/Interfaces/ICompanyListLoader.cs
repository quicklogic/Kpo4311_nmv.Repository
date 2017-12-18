using System.Collections.Generic;
using static Kpo4311_hnv.Lib.source.Utility.LoadStatuses;

namespace Kpo4311_hnv.Lib
{
    public interface ICompanyListLoader
    {
        List<Company> companyList { get; }
        LoadStatus status { get; }
        void Execute();
  
    }
}