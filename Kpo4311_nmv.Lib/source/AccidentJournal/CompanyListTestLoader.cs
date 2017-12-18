using System;
using System.Collections.Generic;
using static Kpo4311_hnv.Lib.source.Utility.LoadStatuses;

namespace Kpo4311_hnv.Lib
{
    public class CompanyListTestLoader: ICompanyListLoader
    {
       
        public CompanyListTestLoader()
        {
            this._companyList = new List<Company>() ;
        }

        private List<Company> _companyList;

        private LoadStatus _status = LoadStatus.None;

        public List<Company> companyList
        {
            get { return _companyList; }
        }

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
                }
            }
            catch (Exception ex)
            {
                LogUtility.ErrorLog(ex);
            }
        }
    }
}
