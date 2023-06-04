using System;

namespace CVWebSite
{
    public partial class SertifikaSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
            dt.SertifikaSil(Convert.ToInt16(id));
            Response.Redirect("Sertifikalar.aspx");

        }
    }
}