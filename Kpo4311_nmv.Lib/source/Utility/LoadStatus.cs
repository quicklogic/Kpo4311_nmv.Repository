using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4311_hnv.Lib.source.Utility
{
    public class LoadStatuses
    {
        public enum LoadStatus
        {
            None = 0,
            Success = 1,
            FileNameIsEmpty = -1,
            GeneralError = -100,
            FileNotExists = -99
        };

        LoadStatus status { get; set; }
    }
}
