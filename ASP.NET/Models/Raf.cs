using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP.NET.Models
{
    public class Raf
    {
        
        //globals
        Execute _execute = new Execute();
        SQL.Kitap _sqlKitap = new SQL.Kitap();
        SQL.Raf _sqlRaf = new SQL.Raf();
        SQL.Kategori _sqlKategori = new SQL.Kategori();
        List<SqlParameter> _params = new List<SqlParameter>();
        string _hataMesaji = "";
        //properties
        public int id { get; set; }
        public int rafBilgisi { get; set; }
        // actions
        public DataTable RaflariListele()
        {
            DataTable dt = _execute.executeDT(_sqlRaf.RaflariListele(),null,false,ref _hataMesaji);
            return dt;
        }

    }
}