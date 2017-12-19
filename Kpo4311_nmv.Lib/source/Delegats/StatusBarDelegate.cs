using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4311_hnv.Lib
{
    public class StatusBarDelegate
    {
        public delegate void OnStatusBarChangeDelegate();
        public StatusBarDelegate() : base()
        {
            LoadStatus = null;
        }
       
        private OnStatusBarChangeDelegate LoadStatus = null;

        public void SetStatusBar(OnStatusBarChangeDelegate LoadStatus)
        {
            this.LoadStatus = LoadStatus;
        }
        
        public OnStatusBarChangeDelegate StatusBar
        {
            get
            {
                return LoadStatus;
            }
        }
        public void ChangeStatusBar()
        {
            LoadStatus?.Invoke();
        }
    }
}

