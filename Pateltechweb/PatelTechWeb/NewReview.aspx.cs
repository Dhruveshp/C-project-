using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewReview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string itemid = Request.QueryString["itemid"];

        TextBox item = (TextBox)FormView1.FindControl("itemidTextBox");

        item.Text = itemid;

        TextBox username = (TextBox)FormView1.FindControl("usernameTextBox");
        username.Text = Context.User.Identity.Name;
    }

    protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
    {
        Response.Redirect("ProductDetails.aspx?itemid=" + Request.QueryString["itemid"]);
    }
}