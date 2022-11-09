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
        private int salesid;
        private string customerName;
        private int noOfUnits;
        private double netAmount;
        public int SalesId
        {
            get
            {
                return salesid;
            }
            set
            {
                salesid=value;
            }
        }
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName=value;
            }
        }
        public int NoOfUnits
        {
            get
            {
                return noofUnits;
            }
            set
            {
                noOfUnits=value;
                if(noOfUnits<=5)
                throw new ArgumentOutOfRangeException("No Sales for units below 5");
            }
        }
        public double NetAmount
        {
            get
            {
                return netAmount;
            }
            set
            {
                netAmount=value;
            }
        }
    }
}