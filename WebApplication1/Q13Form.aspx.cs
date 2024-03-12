using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Q13Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Submit_OnClick(object sender, EventArgs e)
        {
            Session["BookTitle"] = BookTitle.Text;
            Session["Author"] = Author.Text;
            Session["Price"] = Price.Text;
            Session["ISBN"] = ISBN.Text;
            Response.Redirect("Q13Table.aspx");
        }
    }
}