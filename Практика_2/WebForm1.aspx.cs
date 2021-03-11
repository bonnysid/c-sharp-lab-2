using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Практика_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Login"] = TextBox1.Text;
            Session["Password"] = TextBox2.Text;
            Response.Redirect("WebForm2.aspx");
        }
    }
}