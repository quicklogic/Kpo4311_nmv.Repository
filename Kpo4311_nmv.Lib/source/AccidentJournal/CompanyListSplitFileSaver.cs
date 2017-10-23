using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4311_hnv.Lib
{
    public class CompanyListSplitFileSaver : ICompanyListSaver
    {

        public enum LoadStatus { None = 0, Success = 1, FileNameIsEmpty = -1, GeneralError = -100 };

        public CompanyListSplitFileSaver(string dataFileName)
        {
            _dataFileName = dataFileName;
        }

        private string _dataFileName = "";
        private List<Company> _companyList;
        private LoadStatus _status = LoadStatus.None;

        public LoadStatus status
        {
            get { return _status; }
        }

        public List<Company> companyList
        {
            get { return _companyList; }
            set { _companyList = value; }
        }
        public void Execute(List<Company> companyList)
        {
            try
            {
                _status = LoadStatus.None;
                if (_dataFileName == "" || _dataFileName == null)
                {
                    _status = LoadStatus.FileNameIsEmpty;
                    throw new Exception("Не указано имя файла.");
                }
                else
                {
                    FileStream fileDirectory = new FileStream(_dataFileName, FileMode.Open);
                    StreamWriter saveFile = new StreamWriter(fileDirectory);

                    
                    foreach (var data in companyList)
                    {

                        try
                        {
                            saveFile.WriteLine(data.name + " | " + data.category + " | " +
                                data.loss + " | " + data.downtime + "\n");
                        }
                        catch (Exception e)
                        {
                            _status = LoadStatus.GeneralError;
                            LogUtility.ErrorLog(e);
                        }
                    }
                    _status = LoadStatus.Success;
                    saveFile.Close();
                }
            }
            catch (Exception ex)
            {
                LogUtility.ErrorLog(ex);
            }
        }

    }
}
