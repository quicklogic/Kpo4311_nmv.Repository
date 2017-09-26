using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpo4311.nmv.Main
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException();

               //throw new Exception("Неправильные входные параметры");
            }
            catch(NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1:" + ex.Message);
                Lib.LogUtility.ErrorLog(ex.Message);                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка №2:" + ex.Message);
            }
        }
    }
}
