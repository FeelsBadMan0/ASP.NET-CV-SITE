using System;
using System.Web.UI;

namespace CVWebSite
{
    public partial class EgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);

            TxtID.Text = x.ToString();
            TxtID.Enabled = false;
            if (Page.IsPostBack == false)
            {


                DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
                TxtBaslik.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].BASLIK;
                TxtAltBaslik.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                TxtAciklama.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                TxtGenelNot.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].GNOT;
                TxtTarih.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].TARIH;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            dt.EgitimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtGenelNot.Text, TxtTarih.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("Egitim.aspx");
        }
    }
}