using System;

namespace CVWebSite
{
    public partial class DeneyimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            DataSet1TableAdapters.TBLDENEYIMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            dt.DeneyimSil(Convert.ToInt16(id));
            Response.Redirect("Deneyimler.Aspx");
        }
    }
}