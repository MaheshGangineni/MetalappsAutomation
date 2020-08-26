using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalappsAutomation    //DO NOT change the namespace name
{
    public class SalesDetails   //DO NOT change the class name
    {
        //Implement the fields and properties as per description
        private int salesId;
        private string customerName;
        private int noOfUnits;
        private double netAmount;
        private string msg = "No Sales for units below 5";

        public SalesDetails()
        {
        }

        public SalesDetails(int salesId, string customerName, int noOfUnits, double netAmount)
        {
            SalesId = salesId;
            CustomerName = customerName;
            NoOfUnits = noOfUnits;
            NetAmount = netAmount;
            SalesId = salesId;
            CustomerName = customerName;
            NoOfUnits = noOfUnits;
            NetAmount = netAmount;
        }

        public int SalesId { get => salesId; set => salesId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public int NoOfUnits
        {
            get
            {
                return noOfUnits;
            }

            set
            {
                if (value > 5)
                {
                    noOfUnits = value;
                }
                else
                    throw new ArgumentOutOfRangeException(msg);
            }
        }
        public double NetAmount { get => netAmount; set => netAmount = value; }
    }
}
