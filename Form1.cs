using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Movie_App
{

    public partial class Form1 : Form
    {
        public dynamic dataGrid;
        dukkan dukkan = new dukkan();
        private string ad;
        private string soyad;
        public Form1()
        {
            InitializeComponent();
            dataGrid = dataGridView1;
            // Dosyadan filmleri yükle
            //kendi lokalinize çektiğiniz klasör yolunu vermelisiniz.
            dukkan.filmleriYukle("dukkandaki_filmler.txt", mevcut_filmler);
            
            // Form kapanırken dosya içeriğini temizle
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Program kapanırken dosya içeriğini temizle bu metot kodun en altında tanımlanmıştır.
            //kendi lokalinize çektiğiniz klasör yolunu vermelisiniz.
            DosyaIceriginiSil("alinan_filmler.txt");
        } 
        private void kirala_btn_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan ad, soyad ve gün sayısını al
            try
            {
                ad = ad_tb.Text;
                soyad = soyad_tb.Text;
                int gun = Convert.ToInt32(gun_tb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz! " + ex.Message);
                return;
            }

            // Satır oluştur 
            DataGridViewRow row = new DataGridViewRow();

            // Kullanıcıyı oluştur
            kisi user = new kisi(ad, soyad);

            // Seçilen filmi al   
            var selectedMovie = mevcut_filmler.SelectedItem;
            if (selectedMovie == null)
            {
                MessageBox.Show("Lütfen bir film seçin!");
                return;
            }

            // Seçilen filmi ayır 
            var arrayFormOfMovie = selectedMovie.ToString().Split(' ');
            string fiyat = arrayFormOfMovie[arrayFormOfMovie.Length - 1];
            string movieName = string.Join(" ", arrayFormOfMovie.Take(arrayFormOfMovie.Length - 1));

            // Gün sayısını al
            int day;
            if (!int.TryParse(gun_tb.Text, out day))
            {
                MessageBox.Show("Lütfen geçerli bir gün sayısı giriniz!");
                return;
            }

            // Kiralanan filmi oluştur
            kiralanan_film kiralananFilm = new kiralanan_film(user, movieName, Convert.ToInt32(fiyat));

            
            // Dosyaya film ekleme
            //kendi lokalinize çektiğiniz klasör yolunu vermelisiniz.
            dukkan.filmEkle("alinan_filmler.txt", kiralananFilm);

            // Satırı oluştur ve ekle 
            row.CreateCells(dataGrid);

            // Satırın hücrelerine değerleri ata 
            row.Cells[0].Value = movieName;
            row.Cells[1].Value = user.ad + " " + user.soyad;
            row.Cells[2].Value = day * Convert.ToInt32(fiyat);

            // Satırları ekle
            dataGrid.Rows.Add(row);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mevcut_filmler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ad_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedMovie = mevcut_filmler.SelectedItem;


            if (selectedMovie == null)
            {
                MessageBox.Show("Lütfen bir film seçin!");
                return;
            }

            var arrayFormOfMovie = selectedMovie.ToString().Split(' ');
            dynamic movieName = "";

            for (int i = 0; i < arrayFormOfMovie.Length - 1; i++)
            {
                movieName += arrayFormOfMovie[i] + " ";
            }
            movieName = movieName.Trim();//sağında ve solundaki boşlukları sildik

            var kiralananFilm = dukkan.kiralanan_filmler.FirstOrDefault(kf => kf.ad == movieName);


            if (kiralananFilm == null)
            {
                MessageBox.Show("Bu film zaten kiralık değil!");
                return;
            }

            dukkan.kiralanan_filmler.Remove(kiralananFilm); dukkan.filmCikar("alinan_filmler.txt", kiralananFilm);

            MessageBox.Show($"{movieName} adlı film kiralananlar listesinden çıkarıldı.");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gun_tb_TextChanged(object sender, EventArgs e)
        {

        }
        private void DosyaIceriginiSil(string path)
        {
            try
            {
                // Dosyanın içeriğini temizle
                File.WriteAllText(path, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dosya içeriği silinemedi! {ex.Message}");
            }
        }
    }
}
