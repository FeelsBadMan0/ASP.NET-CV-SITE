using System;

namespace CVWebSite
{
    public partial class HobiSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.TBLHOBILERTableAdapter dt = new DataSet1TableAdapters.TBLHOBILERTableAdapter();
            dt.HobiSil(Convert.ToInt16(x));
            Response.Redirect("Hobiler.aspx");

        }
    }
}