using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FREEBOARD
{
    public class ConnectionClass
    {
        private static SqlConnection cntString;
        private static SqlCommand cmdString;

        static ConnectionClass()
        {
            cntString = new SqlConnection(ConfigurationManager.ConnectionStrings["dodamdb"].ConnectionString);



        }

    }
}