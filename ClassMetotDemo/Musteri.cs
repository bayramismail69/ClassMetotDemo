using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
   public class Musteri
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }

    }
}
