using System;
using System.Collections.Generic;
using static Kpo4311_hnv.Lib.CompanyListSplitFileLoader;
using static Kpo4311_hnv.Lib.source.Utility.LoadStatuses;

namespace Kpo4311_hnv.Lib
{
    public class CompanyListTestLoader: ICompanyListLoader
    {
       
        public CompanyListTestLoader() : base()
        {
            this._companyList = new List<Company>() ;
            _LoadStatus = null;
        }

        public void SetStatusBar(CompanyListSplitFileLoader.OnStatusBarChangeDelegate LoadStatus)
        {
            this._LoadStatus = LoadStatus;
        }

        private List<Company> _companyList;

        private LoadStatus _status = LoadStatus.None;

        public List<Company> companyList
        {
            get { return _companyList; }
        }

        public delegate void OnStatusBarChangeDelegate1();
       


         OnStatusBarChangeDelegate _LoadStatus = null;



        public LoadStatus status
        {
            get { return _status; }
        }

        public void Execute()
        {
            try
            {
                //throw new NotImplementedException();
                {
                    Company company = new Company()
                    {
                        name = "Птицефабрика",
                        category = 1,
                        loss = 12.7,
                        downtime = 4
                    };

                    companyList.Add(company);
                    _LoadStatus?.Invoke();
                }
                {
                    Company company = new Company()
                    {
                        name = "Теплоцентраль",
                        category = 1,
                        loss = 0.711,
                        downtime = 1
                    };

                    companyList.Add(company);
                    _LoadStatus?.Invoke();
                }
                {
                    Company company = new Company()
                    {
                        name ="Автосервис",
                        category = 2,
                        loss = 1770.15,
                        downtime = 38
                    };

                    companyList.Add(company);
                    _LoadStatus?.Invoke();
                }
            }
            catch (Exception ex)
            {
                LogUtility.ErrorLog(ex);
            }
        }
    }
}
