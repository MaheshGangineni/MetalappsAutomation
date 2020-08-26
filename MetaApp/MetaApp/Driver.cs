using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalappsAutomation     //DO NOT change the namespace name
{
    public class Program          //DO NOT change the class name
    {
        static void Main(string[] args)         //DO NOT change the 'Main' method signature
        {
            //Implement the code here
            int salesId, NoOfUnits;
            string customerName;
            Console.WriteLine("Enter sales id");
            salesId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter customer name");
            customerName = Console.ReadLine();
            Console.WriteLine("Enter the number of units sold");
            NoOfUnits = int.Parse(Console.ReadLine());
            try
            {
                SalesDetails sd = new SalesDetails(salesId, customerName, NoOfUnits, 0);
                Metalapps mp = new Metalapps();
                mp.CalculateNetAmount(sd);
                mp.AddSalesDetails(sd);
                Console.WriteLine("Sales Bill\n***********\n");
                Console.WriteLine("Sales Id:" + sd.SalesId);
                Console.WriteLine("Customer Name :" + sd.CustomerName);
                Console.WriteLine("Number of Units Sold :" + sd.NoOfUnits);
                Console.WriteLine("Net Amount :" + sd.NetAmount);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();

        }
    }

}

