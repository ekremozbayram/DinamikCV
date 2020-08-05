using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DinamikCV_ASP.Net_
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TblYetenekler.ToList();
            Repeater1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TblYetenekler t = new TblYetenekler();
            t.yetenek = TextBox1.Text;
            t.derece = Convert.ToByte(TextBox2.Text);
            db.TblYetenekler.Add(t);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}