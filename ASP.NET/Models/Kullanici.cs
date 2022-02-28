using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ASP.NET.Models
{
    public class Kullanici
    {
        //Prop.:
        public int id { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        //Actions:
        public DataTable Get()
        {
            DataTable dtResult = new DataTable();

            Execute _execute = new Execute();
            string _hataMesaji = "";
            dtResult = _execute.executeDT("select * from Kullanıcı", null, false, ref _hataMesaji);

            return dtResult;
        }

        public DataTable GetProfile()
        {
            DataTable dtResult = new DataTable();

            Execute _execute = new Execute();
            string _hataMesaji = "";
            dtResult = _execute.executeDT("select count(*) as sayi from Kullanıcı where kullaniciAdi='" + kullaniciAdi + "' and sifre='" + sifre + "'", null, false, ref _hataMesaji);

            return dtResult;
        }
    }
}