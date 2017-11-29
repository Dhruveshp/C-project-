<%@ Application Language="C#" %>
<%@ Import Namespace="Pateltechweb" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
    }
        void Session_Start (object sender, EventArgs e)
    {
        Session["cartprod"] = new ArrayList();
        Session["cartqty"] = new ArrayList();
    }

    void Session_End (object sender, EventArgs e)
    {
        Session.Remove("cartprod");
        Session.Remove("cartqty");
    }

</script>
