using System;

namespace CVWebSite
{
    public partial class EgitimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            dt.EgitimSil(Convert.ToInt16(id));
            Response.Redirect("Egitim.Aspx");
        }
    }
}
