using System;
using System.Windows.Forms;

namespace Kpo4311_hnv.Lib
{
    public partial class FrmCompany : Form
    {
        public FrmCompany()
        {
            InitializeComponent();

            _company = null;
        }

        private Company _company = null;

        public Company company
        {
            get { return _company; }
        }

        public void SetCompany(Company company)
        {
            this._company = company;

            this.txtBoxName.Text= company.name;
            this.txtBoxCategory.Text = Convert.ToString(company.category);
            this.txtBoxLoss.Text = Convert.ToString(company.loss);
            this.txtBoxDowntime.Text = Convert.ToString(company.downtime);
        }


    }
}
