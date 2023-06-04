using System;

namespace CVWebSite
{
    public partial class Hobiler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHOBILERTableAdapter dt = new DataSet1TableAdapters.TBLHOBILERTableAdapter();
            Repeater1.DataSource = dt.HobiListele();
            Repeater1.DataBind();
        }
    }
}