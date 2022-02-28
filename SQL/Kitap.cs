using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class Kitap
    {

        //anasayfa kategori dropdown
        public string RafaGoreKategoriGetir()
        {
            return "select k.kategoriAdi from Kategori as k inner join Kitap as ki on ki.kategori_id = k.id where ki.raf_id = @raf_id";
        }
        //anasayfa kategori listbox
        public string KategoriyeGoreKitaplariGetir()
        {
            return "select ki.kitapAdi from Kitap as ki inner join Kategori as k on k.id = ki.kategori_id where ki.kategori_id =@kategori_id";
        }
        //kitap crud işlemleri
        public string Listele()
        {
            return "select * from Kitap";
        }
        public string Ekle()
        {
            return "insert into Kitap(kitapAdi,yazar_id,kategori_id,raf_id) values(@kitapAdi,@yazar_id,@kategori_id,@raf_id)";
        }
        public string Guncelle()
        {
            return "update Kitap set kitapAdi=@kitapAdi,yazar_id=@yazar_id,kategori_id=@kategori_id,raf_id=@raf_id where id=@id";
        }
        public string Sil()
        {
         return "delete from Kitap where id=@id";
        }
    }
}
