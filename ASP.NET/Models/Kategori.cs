using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP.NET.Models
{
    public class Kategori
    {
        //globals
        Execute _execute = new Execute();
        SQL.Kitap _sqlKitap = new SQL.Kitap();
        SQL.Kategori _kategori = new SQL.Kategori();
        List<SqlParameter> _params = new List<SqlParameter>();
        string _hataMesaji = "";
        // properties
        public int id { get; set; }
        public string kategoriAdi { get; set; }
    }
}