using System;

namespace CVWebSite
{
    public partial class Sertifikalar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
            Repeater1.DataSource = dt.SertifikaListele();
            Repeater1.DataBind();
        }
    }
}