using System;
using System.Collections.Generic;
using System.IO;

namespace Kpo4311_hnv.Lib
{
    public class CompanyListSplitFileLoader : ICompanyListLoader
    {
        

        public CompanyListSplitFileLoader(string dataFileName)
        {
            _dataFileName = dataFileName;
        }

        public enum LoadStatus { None = 0, Success = 1, FileNameIsEmpty = -1, FileNotExists = -2, GeneralError = -100 };
        private string _dataFileName = "";
        private List<Company> _companyList = new List<Company>();
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
                _status = LoadStatus.None;
                if (_dataFileName == "" || _dataFileName == null)
                {
                    _status = LoadStatus.FileNameIsEmpty;
                    throw new Exception("Не указано имя файла.");
                }
                if(!System.IO.File.Exists(_dataFileName))
                {
                    _status = LoadStatus.FileNotExists;
                    throw new Exception("Указанного файла не существует.");
                    
                }
                else
                {
                    
                        StreamReader sr = null;
                        using (sr = new StreamReader(_dataFileName))
                        {
                            while (!sr.EndOfStream)
                            {
                                
                               try
                               {
                                    string str = sr.ReadLine();
                                    string[] arr = str.Split('|');

                        
                                    Company company = new Company()
                                    {
                                        name = arr[0],
                                        category = int.Parse(arr[1]),
                                        loss = double.Parse(arr[2]),
                                        downtime = int.Parse(arr[3])
                                    };
                                    companyList.Add(company);
                        

                                     

                               }
                               catch(Exception e)
                               {
                                 _status = LoadStatus.GeneralError;
                                  LogUtility.ErrorLog(e);
                               }
                            }
                        }
                }

                    _status = LoadStatus.Success;
                

            }
            catch (Exception ex)
            {
                LogUtility.ErrorLog(ex);
            }
        }
    }
}
