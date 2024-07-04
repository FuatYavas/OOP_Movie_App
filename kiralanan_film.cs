using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Movie_App
{
    // kiralanan_film sınıfı film sınıfından türetilmiştir.
    public class kiralanan_film
    {
        public kisi kiralayan { get; set; }
        public string ad { get; set; }
        public int gunlukKiraBedeli { get; set; }

        public kiralanan_film(kisi kiralayan, string ad, int gunlukKiraBedeli)
        {
            this.kiralayan = kiralayan;
            this.ad = ad;
            this.gunlukKiraBedeli = gunlukKiraBedeli;
        }
    }

}
