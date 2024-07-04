using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Movie_App
{
    public class dukkan
    {
        // Film ve kiralanan film listeleri oluşturuldu
       
        public List<film> filmler = new List<film>();
        public List<kiralanan_film> kiralanan_filmler = new List<kiralanan_film>();

        public const int baslangicKira = 3;
        // Dosyadan filmleri yükledik
               public void filmleriYukle(string path, ListBox lb) // path: dosya yolu, lb: listbox
        {
            try
            {
                // Dosyadan okuma işlemi

                StreamReader sr = new StreamReader(path);
                string eklenecek = sr.ReadLine();
                while(eklenecek != null)
                {
                    // Listbox'a ekleme işlemi
                    
                    lb.Items.Add(eklenecek);
                    eklenecek = sr.ReadLine();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Film yüklemede bir hata oluştu! " + ex.Message);
            }
        }
        // Film ekleme işlemi
        public void filmEkle(string path, kiralanan_film film)
        {
            try
            {
                // Dosyaya ekleme işlemi
                using (StreamWriter streamWriter = new StreamWriter(path, true)) // true parametresi ekleme modunda açar
                {
                    streamWriter.WriteLine($"{film.kiralayan.ad} {film.kiralayan.soyad} {film.ad} {film.gunlukKiraBedeli}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Film eklemede bir hata oluştu! {ex.Message}");
            }
        }

        public void filmCikar(string path, kiralanan_film film)
        {
            try
            {
                var lines = File.ReadAllLines(path).ToList();
                string filmStr = $"{film.kiralayan.ad} {film.kiralayan.soyad} {film.ad} {film.gunlukKiraBedeli}";
                lines.RemoveAll(line => line.Trim() == filmStr.Trim());
                File.WriteAllLines(path, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Film çıkarmada bir hata oluştu! {ex.Message}");
            }
        }
    }

}
