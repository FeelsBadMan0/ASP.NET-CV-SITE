using System;

namespace CVWebSite
{
    public partial class SertifikaEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
            dt.SertifikaEkle(TxtSertifika.Text);
            Response.Redirect("Sertifikalar.aspx");
        }
    }
}