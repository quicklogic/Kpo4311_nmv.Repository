using Kpo4311_hnv.Lib.source.Utility;
using System.Collections.Generic;
using static Kpo4311_hnv.Lib.CompanyListSplitFileLoader;
using static Kpo4311_hnv.Lib.CompanyListTestLoader;
using static Kpo4311_hnv.Lib.source.Utility.LoadStatuses;

namespace Kpo4311_hnv.Lib
{
    public interface ICompanyListLoader
    {
        List<Company> companyList { get; }
        LoadStatuses.LoadStatus status { get; }

        void Execute();
        void SetStatusBar(OnStatusBarChangeDelegate LoadStatus);

    }
}