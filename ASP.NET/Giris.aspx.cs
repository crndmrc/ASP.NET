using ASP.NET.Models;
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
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true) return;
        }

        protected void BtnGiris_Click(object sender, EventArgs e)
        {
            Kullanici _kullanici = new Kullanici();
            _kullanici.kullaniciAdi = TxtKullaniciAdi.Text;
            _kullanici.sifre = TxtSifre.Text;
            DataTable dtProfile = _kullanici.GetProfile();

            if (dtProfile != null && dtProfile.Rows[0]["sayi"].ToString() != "0") //giris basarili
            {
                FormsAuthentication.RedirectFromLoginPage(_kullanici.kullaniciAdi, false);
                Response.Redirect(FormsAuthentication.DefaultUrl);
            }
            else //giris basarisiz
            {
                lblBilgi.Text = "Başarısız giriş denemesi!";
            }
        }
    }
}