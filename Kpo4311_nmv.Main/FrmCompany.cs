using System;
using System.Windows.Forms;
using Kpo4311_hnv.Lib;

namespace Kpo4311_hnv.Main
{
    public partial class FrmCompany : Form
    {
        public FrmCompany()
        {
            InitializeComponent();

            _company = null;
        }

        private bool flag = false;
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

        private void btnCompanyDataEdit_Click(object sender, EventArgs e)
        {
            if(!flag)
            {
                txtBoxName.ReadOnly = false;
                txtBoxCategory.ReadOnly = false;
                txtBoxLoss.ReadOnly = false;
                txtBoxDowntime.ReadOnly = false;
                btnCompanyDataEdit.Text = "Save";
                flag = true;
                Refresh();
                btnCompanyDataEdit.BackColor = System.Drawing.Color.Green;
                btnExit.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                company.name = this.txtBoxName.Text;
                company.category= Convert.ToInt32(this.txtBoxCategory.Text);
                company.loss = Convert.ToDouble(this.txtBoxLoss.Text);
                company.downtime = Convert.ToInt32(this.txtBoxDowntime.Text);
                txtBoxName.ReadOnly = true;
                txtBoxCategory.ReadOnly = true;
                txtBoxLoss.ReadOnly = true;
                txtBoxDowntime.ReadOnly = true;
                btnCompanyDataEdit.Text = "Edit";
                flag = false;
                btnCompanyDataEdit.BackColor = System.Drawing.Color.White;
                btnExit.BackColor = System.Drawing.Color.White;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
