using System;

namespace CVWebSite
{
    public partial class Yetenekler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt = new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            Repeater1.DataSource = dt.YetenekListele();
            Repeater1.DataBind();

        }
    }
}