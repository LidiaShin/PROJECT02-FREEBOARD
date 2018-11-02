using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRACTICES
{
    public partial class TEST : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("IsPostBack:" + IsPostBack + "<br>");
            Response.Write("Page_Load() Done");

           
            if (!IsPostBack)
            {
                TextBox1.Text = "Dodam Shin";
                TextBox2.Text = "34";
            }
        }

        protected void Btn_Send_Click(object sender, EventArgs e)
        {
            
                Response.Write("<br> Clk_Send() Done");

            Response.Write("Name: " + TextBox1.Text + "<br>");
            Response.Write("Age: " + TextBox2.Text + "<br>");
            
        }
    }
}