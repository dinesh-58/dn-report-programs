using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Tut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            TestingLabel.Text = r.Next().ToString();
        }
        protected void SayHello(object sender, EventArgs e)
        {
            Label.Text = "Hello, " + TextBox.Text;

        }
        protected void GreetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label.Text = "Hello, " + GreetList.SelectedValue;
        }
    }
}