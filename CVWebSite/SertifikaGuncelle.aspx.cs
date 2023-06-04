using System;
using System.Web.UI;

namespace CVWebSite
{
    public partial class SertifikaGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            TxtID.Text = id.ToString();
            TxtID.Enabled = false;

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
                TxtSertifika.Text = dt.SertifikaGetir(Convert.ToInt16(TxtID.Text))[0].SERTIFIKA;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
            dt.SertifikaGuncelle(TxtSertifika.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("Sertifikalar.aspx");
        }
    }
}