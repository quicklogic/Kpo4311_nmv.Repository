using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kpo4311_hnv.Lib
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private List<Company> companyList = new List<Company>();

        private BindingSource bsCompanies = new BindingSource();

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void mnOpen_Click(object sender, EventArgs e)
        {
            //LoadCompanyListCommand loader = new LoadCompanyListCommand(AppGlobalSettings.dataFileName);
            //ICompanyListLoader loader = new CompanyListSplitFileLoader(AppGlobalSettings.dataFileName);

            ICompanyListLoader loader = new CompanyListTestLoader();
            loader.Execute();
            companyList = loader.companyList;
            bsCompanies.DataSource =  companyList;
            dgvCompanies.DataSource = bsCompanies;

        }

        private void mnOpenCompanies_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            FrmCompany frmCompany = new FrmCompany();

            Company company = (bsCompanies.Current as Company);
            frmCompany.SetCompany(company);

            frmCompany.ShowDialog();
        }
    }
}
