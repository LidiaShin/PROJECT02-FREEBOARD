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
    public partial class PART25 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:dodamdbserver.database.windows.net,1433;Initial Catalog=DODAMDB;  Persist Security Info=False;User ID=lidiadshin;Password=1142311423!q;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection cntString = new SqlConnection(connectionString);

            //cntString.Open();


            //string aQuery = "SELECT * FROM TBLUSERS;";
            //SqlCommand cmd = new SqlCommand(aQuery, cntString);
            //SqlDataReader myData = cmd.ExecuteReader();


            //while (myData.Read())
            //{
            ////    Response.Write(String.Format("User: {0} (Name: {1}, Password: {2}) <br>" +
            ////    "RegisterDay: {3}<hr>", myData[0], myData[2], myData[1], myData[3]));

            //    ID.Text = myData[0].ToString();
            //    NAME.Text = myData[1].ToString();
            //    PWORD.Text = myData[2].ToString();
            //    RDAY.Text = myData[3].ToString();
            //}
            ////cntString.Close();


            string bQuery = "SELECT * FROM TBLUSERS;";

            cntString.Open();

            SqlDataAdapter da = new SqlDataAdapter(bQuery,cntString);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cntString.Close();

            DataTable dt = ds.Tables[0];
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Response.Write(string.Format("User:{0}, (Name: {1}, Password: {2})<br>" +
                "Register Day:{3}<hr>", dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]));
            }


            //Response.Write("1) Datatable → " + ds.Tables[0] + "<br>");
            //Response.Write("2) Datatable.Rows.Count →  " + ds.Tables[0].Rows.Count + "<br>");
            //Response.Write("3) Datatable.Rows →  " + ds.Tables[0].Rows + "<br>");
            //Response.Write("4) Datatable.Row[0] → " + ds.Tables[0].Rows[0] + "<br>");
            //Response.Write("5) Datatable.Columns.Count→  " + ds.Tables[0].Columns + "<br>");
            //Response.Write("6) Datatable.Columns → " + ds.Tables[0].Columns + "<br>");
            //Response.Write("7) Datatable[0] → " + ds.Tables[0].Columns[0] + "<br> <hr>");









        }
    }
}