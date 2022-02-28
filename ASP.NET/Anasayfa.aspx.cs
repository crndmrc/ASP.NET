using ASP.NET.Models;
using SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true) return;
            DataTable dtRaf = (new Models.Raf().RaflariListele());
            //listboxa raf bilgileriyukleme
            DropDownListRaf.DataValueField = "id";
            DropDownListRaf.DataTextField = "rafBilgisi";
            DropDownListRaf.DataSource = dtRaf;
            DropDownListRaf.DataBind();
            DropDownListRaf.Items.Insert(0, new ListItem("Seçiniz", "0"));
            DropDownListRaf.SelectedIndex = 0;
        }

        protected void DropDownListRaf_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.Kitap _kitap = new Models.Kitap();
            _kitap.raf_id = int.Parse(DropDownListRaf.SelectedValue);
            //dropdown kategori bilgileri yukleme

            ListBoxKategori.DataSource = _kitap.RafaGoreListele();
            //ListBoxKategori.DataValueField = "id";
            ListBoxKategori.DataTextField = "kategoriAdi";
            ListBoxKategori.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect(FormsAuthentication.LoginUrl);
        }

        protected void ListBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}