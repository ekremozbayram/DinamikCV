using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DinamikCV_ASP.Net_
{
    public partial class Login : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TblAdmin where x.kullaniciAd == TextBox1.Text && x.sifre == TextBox2.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("Istatistik.aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Adı veya Şifre Girdiniz");
            }
        }
    }
}