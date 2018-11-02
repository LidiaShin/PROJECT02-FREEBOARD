using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRACTICES
{
    public partial class PART20 : System.Web.UI.Page
    {

        

        protected void Page_Load(object sender, EventArgs e)
        { 
            string connectionString = "Server=tcp:dodamdbserver.database.windows.net,1433;Initial Catalog=DODAMDB;  Persist Security Info=False;User ID=lidiadshin;Password=1142311423!q;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection cntString = new SqlConnection(connectionString);

            Response.Write("Before → " + cntString.State + "<hr>");

            cntString.Open();

            Response.Write("Now → " + cntString.State + "<hr>");

            cntString.Close();

            Response.Write("Closed→ " + cntString.State + "<hr>");

        }
    }
}