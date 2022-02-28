using ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true) return;
        }

        protected void ButtonListele_Click(object sender, EventArgs e)
        {
            Kitap _kitap = new Kitap();
            GridView1.DataSource=_kitap.Listele();
            GridView1.DataBind();
        }

        protected void ButtonEkle_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonGuncelle_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonSil_Click(object sender, EventArgs e)
        {

        }
    }
}