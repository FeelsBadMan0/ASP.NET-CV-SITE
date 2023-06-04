using System;

namespace CVWebSite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHAKKIMDATableAdapter dt = new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
            Repeater1.DataSource = dt.HakkımdaListele();
            Repeater1.DataBind();

            DataSet1TableAdapters.TBLDENEYIMTableAdapter dt2 = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            Repeater2.DataSource = dt2.DeneyimListesi();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBLEGITIMTableAdapter dt3 = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            Repeater3.DataSource = dt3.EgitimListesi();
            Repeater3.DataBind();

            DataSet1TableAdapters.TBLHOBILERTableAdapter dt4 = new DataSet1TableAdapters.TBLHOBILERTableAdapter();
            Repeater4.DataSource = dt4.HobiListele();
            Repeater4.DataBind();

            DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter dt5 = new DataSet1TableAdapters.TBLSERTIFIKALARTableAdapter();
            Repeater5.DataSource = dt5.SertifikaListele();
            Repeater5.DataBind();

            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt6 = new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            Repeater6.DataSource = dt6.YetenekListele();
            Repeater6.DataBind();


        }
    }
}