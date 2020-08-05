using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DinamikCV_ASP.Net_
{
    public partial class Default : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TblHakkimda.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.TblHakkimda.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.TblHakkimda.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.TblYetenekler.ToList();
            Repeater4.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TblIletisim t = new TblIletisim();
            t.adsoyad = TextBox1.Text;
            t.mail = TextBox2.Text;
            t.konu = TextBox3.Text;
            t.mesaj = TextBox4.Text;
            db.TblIletisim.Add(t);
            db.SaveChanges();
        }
    }
}