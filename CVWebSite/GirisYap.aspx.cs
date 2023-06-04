using System;
using System.Data.SqlClient;

namespace CVWebSite
{
    public partial class GirisYap : System.Web.UI.Page
    {
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-PNOIT9G\SQLEXPRESS;Initial Catalog=BlogWebDb;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLADMIN WHERE KULLANICI=@p1 and SIFRE=@p2", bgl);
            komut.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("Hakkimda.aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Adı veya Şifre!");
            }
            bgl.Close();
        }
    }
}