using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Kpo4311_hnv.Lib;
using static Kpo4311_hnv.Lib.source.Utility.LoadStatuses;

namespace Kpo4311_hnv.Main
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            abstractFactory = AppGlobalSettings.GetCompanyAbstractFactory();

            LoadStatusProgressBar.Step = 30;
            LoadStatusProgressBar.Minimum = 0;
            LoadStatusProgressBar.Maximum = 90;
            LoadStatusToolStrip.Text = Convert.ToString(LoadStatus.None);
        }



        private List<Company> companyList = new List<Company>();


        private BindingSource bsCompanies = new BindingSource();
        private ICompanyAbstractFactory abstractFactory;
        private ICompanyListLoader companyListLoader;
        private ICompanyListSaver companyListSaver;


        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void OnStatusBarChangeDelegate()
        {
            if (LoadStatusProgressBar.Value != LoadStatusProgressBar.Maximum)
            {
                LoadStatusProgressBar.PerformStep();
            }
            LoadStatusToolStrip.Text = companyListLoader.status.ToString();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {

            try
            {
               
               
                companyListLoader = abstractFactory.CompanyListSplitFileLoader(AppGlobalSettings.dataFileName);
                companyListLoader.SetStatusBar(OnStatusBarChangeDelegate);
                companyListLoader.Execute();
                companyList = companyListLoader.companyList;
                bsCompanies.DataSource = companyList;
                dgvCompanies.DataSource = bsCompanies;
            }
            catch (Exception ex)
            {
                LogUtility.ErrorLog(ex);
            }

        }


        private void mnOpenCompanies_Click(object sender, EventArgs e)
        {
            try
            {
                //throw new NotImplementedException();
                FrmCompany frmCompany = new FrmCompany();

                Company company = (bsCompanies.Current as Company);
                frmCompany.SetCompany(company);

                frmCompany.ShowDialog();
            }
            catch(Exception ex)
            {
                LogUtility.ErrorLog(ex);
            }
        }

        private void mnSave_Click(object sender, EventArgs e)
        {
            
            //ICompanyListSaver saver = new CompanyListTestSaver();
            //saver.Execute(companyList);
            try
            {
                ICompanyAbstractFactory factory = new CompanyListSplitFileFactory();
                companyListSaver = factory.CompanyListSplitFileSaver(AppGlobalSettings.dataFileName);
                companyListSaver.Execute(companyList);
            }
            catch (Exception ex)
            {
                LogUtility.ErrorLog(ex);
            }
            //ICompanyListSaver saver = new CompanyListSplitFileSaver(AppGlobalSettings.dataFileName);
            //saver.Execute(companyList);
        }

       
    }
}
