using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DinamikCV_ASP.Net_
{
    public partial class YetenekGuncel : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var deger = db.TblYetenekler.Find(x);
                TextBox1.Text = deger.yetenek;
                TextBox2.Text = deger.derece.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var deger = db.TblYetenekler.Find(x);
            deger.yetenek = TextBox1.Text;
            deger.derece = Convert.ToByte(TextBox2.Text);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}