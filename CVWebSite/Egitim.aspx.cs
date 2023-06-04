using System;

namespace CVWebSite
{
    public partial class Egitim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            Repeater1.DataSource = dt.EgitimListesi();
            Repeater1.DataBind();
        }
    }
}