using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Q13Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(1);
            System.Diagnostics.Debug.WriteLine("\n Session variables are:");
            foreach (var i in Session) {
                System.Diagnostics.Debug.Print($"{i} : {Session[i.ToString()]}");
            }
            TableISBN.Text = Session["ISBN"] as string;
            TableAuthor.Text = Session["Author"] as String;
            TableTitle.Text = Session["BookTitle"] as String;
            TablePrice.Text = Session["Price"] as String;

        }
    }
}