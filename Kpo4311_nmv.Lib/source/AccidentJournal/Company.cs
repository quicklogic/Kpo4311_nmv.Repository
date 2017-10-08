namespace Kpo4311_hnv.Lib
{
    public class Company
    {
        public Company()
        {
            name = "";
            category = 0;
            loss = 0;
            downtime = 0;
        }

        public string name { get; set; }
        public int category { get; set; }
        public double loss { get; set; }
        public int downtime { get; set; }


    }

}
