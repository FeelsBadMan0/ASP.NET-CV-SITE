using System;

namespace CVWebSite
{
    public partial class DeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);

            TxtID.Text = x.ToString();
            TxtID.Enabled = false;
            if (Page.IsPostBack == false)
            {


                DataSet1TableAdapters.TBLDENEYIMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
                TxtBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].BASLIK;
                TxtAltBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                TxtAciklama.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                TxtTarih.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].TARIH;
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDENEYIMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            dt.DeneyimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtTarih.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("Deneyimler.Aspx");
        }
    }
}