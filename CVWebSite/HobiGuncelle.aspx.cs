using System;

namespace CVWebSite
{
    public partial class HobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            TxtID.Text = id.ToString();
            TxtID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLHOBILERTableAdapter dt = new DataSet1TableAdapters.TBLHOBILERTableAdapter();
                TxtHobi.Text = dt.HobiGetir(Convert.ToInt16(TxtID.Text))[0].HOBI;

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHOBILERTableAdapter dt = new DataSet1TableAdapters.TBLHOBILERTableAdapter();
            dt.HobiGuncelle(TxtHobi.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("Hobiler.aspx");
        }
    }
}