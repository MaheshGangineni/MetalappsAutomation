using System;
using System.Configuration;
using System.Data.SqlClient;

namespace MetalappsAutomation  //DO NOT change the namespace name
{
    public class DBHandler  //DO NOT change the class name
    {
        //Implement the methods as per the description
        public SqlConnection GetConnection()
        {
            SqlConnection con;
            con = new  SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
            return con;
        }
    }
}
