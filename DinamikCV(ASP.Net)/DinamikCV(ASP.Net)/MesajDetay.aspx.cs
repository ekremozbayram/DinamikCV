using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DinamikCV_ASP.Net_
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var mesaj = db.TblIletisim.Find(x);
            TextBox1.Text = mesaj.adsoyad;
            TextBox2.Text = mesaj.mail;
            TextBox3.Text = mesaj.konu;
            TextBox4.Text = mesaj.mesaj;
        }
    }
}