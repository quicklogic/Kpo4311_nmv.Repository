using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4311_hnv.Lib
{
    public class CompanyListTestSaver : ICompanyListSaver
    {
     
        public CompanyListTestSaver()
        {
            this._companyList = new List<Company>();
        }

        private List<Company> _companyList;

        public List<Company> companyList
        {
            get { return _companyList;   }
            set {  _companyList = value; }
        }
        public void Execute(List<Company> companyList)
        {
            int counter;
            foreach (var data in companyList)
            {
                counter = 1;
                Company companyNew = new Company();
                this.companyList.Add(companyNew);
                foreach (Company company in this.companyList)
                {
                    if (counter < this.companyList.Count)
                    {
                        counter++;
                        continue;
                    }
                    company.name = data.name;
                    company.category = data.category;
                    company.loss = data.loss;
                    company.downtime = data.downtime;
                    break;
                }
            }

        }
    }
}
