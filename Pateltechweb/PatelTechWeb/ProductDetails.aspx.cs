using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    
    }

    protected void DetailsView1_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
        if (e.CommandName == "AddToCart")
        {

            string url = "cart.aspx?";

            DetailsViewRow row = DetailsView1.Rows[0];

            ArrayList prods = new ArrayList();
            ArrayList qtys = new ArrayList();

            prods = (ArrayList)Session["cartprod"];
            qtys = (ArrayList)Session["cartqty"];

            prods.Add(row.Cells[1].Text);
            qtys.Add(txt_qty.Text);

            Session["cartprod"] = prods;
            Session["cartqty"] = qtys;


            Response.Redirect(url);
        }

        else if (e.CommandName == "SubmitReview")

        {

            string url = "newreview.aspx?";

            DetailsViewRow row = DetailsView1.Rows[0];
            string itemid = row.Cells[1].Text;

            url += "itemid=" + itemid;
            Response.Redirect(url);
        }
    }
}