using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DinamikCV_ASP.Net_
{
    public partial class Istatistik : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TblYetenekler.Count().ToString();
            Label2.Text = db.TblIletisim.Count().ToString();
            Label3.Text = db.TblYetenekler.Average(x => x.derece).ToString();
            Label4.Text = db.TblYetenekler.Max(x => x.derece).ToString();
        }
    }
}