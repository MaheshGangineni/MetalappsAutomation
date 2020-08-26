using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MetalappsAutomation //DO NOT change the namespace name
{
	public class Metalapps            //DO NOT change the class name
	{
		//Implement the property as per the description
		public SqlConnection SqlCon { get; set; }
		//Implement the methods as per the description
		public DBHandler db = new DBHandler();
		public void AddSalesDetails(SalesDetails sd)
        {
			string insertSales = "insert into SalesDetails values(@SalesId,@Customer_name,@Noof_units,@Net_amount)";
			try
			{
				using (SqlCon = db.GetConnection())
				{
					using (SqlCommand cmdinsertSales = new SqlCommand(insertSales, SqlCon))
					{
						SqlCon.Open();
						cmdinsertSales.Parameters.AddWithValue("@SalesId", sd.SalesId);
						cmdinsertSales.Parameters.AddWithValue("@Customer_name", sd.CustomerName);
						cmdinsertSales.Parameters.AddWithValue("@Noof_units", sd.NoOfUnits);
						cmdinsertSales.Parameters.AddWithValue("@Net_amount", sd.NetAmount);
						cmdinsertSales.ExecuteNonQuery();
						SqlCon.Close();
					}
				}
			}
			catch(Exception e)
            {
                Console.WriteLine(e);
            }
		}
		public void CalculateNetAmount(SalesDetails details)
        {

			//((75, 350 * 8) - (75, 350 * 8) * 2 %)
			double dis = 0;
			int units = details.NoOfUnits;
			if (units > 20)
				dis = 0.1;
			else if (units > 15 && units <= 20)
				dis = 0.08;
			else if (units > 10 && units <= 15)
				dis = 0.05;
			else if (units > 5 && units <= 10)
				dis = 0.02;
			else
				dis = 0;
			details.NetAmount = ((75350 * units) - (75350 * units) * dis);
		}
	}
}
