using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRACTICES
{
    public partial class PART24 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:dodamdbserver.database.windows.net,1433;Initial Catalog=DODAMDB;  Persist Security Info=False;User ID=lidiadshin;Password=1142311423!q;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection cntString = new SqlConnection(connectionString);


            //string Query = "SELECT * FROM TBLUSERS;";
            

            string bQuery = "SELECT user_password FROM TBLUSERS WHERE user_id='SSHIN';";
            SqlCommand cmd = new SqlCommand(bQuery, cntString);

            cntString.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);
            ds.Tables.Add(dt);

            pword.Text = dt.Rows[0]["user_password"].ToString();


            cntString.Close();
        }
    }
}