using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalappsAutomation     //DO NOT change the namespace name
{
    public class Driver          //DO NOT change the class name
    {
        static void Main(string[] args)         //DO NOT change the 'Main' method signature
        {
            //Implement the code here
            SalesDetails obj=new SalesDetails();
            Console.WriteLine("Enter sales id:");
            obj.Salesid=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter customername");
            obj.CustomerName=Console.ReadLine();
            Console.WriteLine("Enter the number of units sold");
            obj.NoOfUnits=int.Parse(Console.ReadLine());
            Metalapps app= new Metalapps();
            app.CalculateNetAmount(obj);
            app.AddSalesDetails(obj);
            Console.WriteLine("Sales Bill");
            Console.WriteLine("***********");
            Console.WriteLine("Sales Id :" +obj.Salesld);
            Console.WriteLine("Customer Name:"+obj.CustomerName);
            Console.WriteLine("Number of Units Sold:"+obj.NoOfUnits);
            Console.WriteLine("Net Amount:"+obj.NetAmount);
        }
    }
}