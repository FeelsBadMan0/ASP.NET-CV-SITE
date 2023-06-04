using System;

namespace CVWebSite
{
    public partial class Deneyimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDENEYIMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            Repeater1.DataSource = dt.DeneyimListesi();
            Repeater1.DataBind();

        }
    }
}