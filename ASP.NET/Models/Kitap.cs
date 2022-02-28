using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP.NET.Models
{
    public class Kitap
    {
        //globals
        Execute _execute = new Execute();
        SQL.Kitap _sql = new SQL.Kitap();
        List<SqlParameter> _params = new List<SqlParameter>();
        string _hataMesaji = "";
        // properties
        public int id { get; set; } 
        public string kitapAdi { get; set; }    
        public int yazar_id { get; set; }   
        public int kategori_id { get; set; }
        public int raf_id { get; set; }

        //actions
        public DataTable KategoriyeGoreListele()
        {
            _params.Add(new SqlParameter("@kategori_id",kategori_id));
            DataTable dt = _execute.executeDT(_sql.KategoriyeGoreKitaplariGetir(),_params.ToArray(),false,ref _hataMesaji);
            return dt;
        }
        public DataTable RafaGoreListele()
        {
            _params.Add(new SqlParameter("@raf_id", raf_id));
            DataTable dt = _execute.executeDT(_sql.RafaGoreKategoriGetir(), _params.ToArray(), false, ref _hataMesaji);
            return dt;
        }
        public DataTable Listele()
        {
            DataTable dt = new DataTable();
            dt = _execute.executeDT(_sql.Listele(), null, false, ref _hataMesaji);
            return dt;
        }
        public bool Ekle()
        {
            bool sonuc = true; //?
            _params.Add(new SqlParameter("@kitapAdi",kitapAdi));
            _params.Add(new SqlParameter("@yazar_id", yazar_id));
            _params.Add(new SqlParameter("@kategori_id", kategori_id));
            _params.Add(new SqlParameter("@raf_id", raf_id));
            sonuc = _execute.execute(_sql.Ekle(), _params.ToArray(), false, ref _hataMesaji);
            return sonuc;
        }
        public bool Guncelle() 
        {
            bool sonuc = true; //?
            _params.Add(new SqlParameter("@id", id));
            _params.Add(new SqlParameter("@kitapAdi", kitapAdi));
            _params.Add(new SqlParameter("@yazar_id", yazar_id));
            _params.Add(new SqlParameter("@kategori_id", kategori_id));
            _params.Add(new SqlParameter("@raf_id", raf_id));
            sonuc = _execute.execute(_sql.Guncelle(), _params.ToArray(), false, ref _hataMesaji);
            return sonuc;
        }
        public bool Sil()
        {
            bool sonuc = true; //?
            _params.Add(new SqlParameter("@id", id));
            sonuc = _execute.execute(_sql.Sil(), _params.ToArray(), false, ref _hataMesaji);
            return sonuc;
        }
    }
}