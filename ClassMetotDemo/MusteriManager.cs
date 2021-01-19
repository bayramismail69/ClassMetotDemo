using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
  public  class MusteriManager
    {
        public List<Musteri> musteriler = new List<Musteri>();
        Musteri musteri1 = new Musteri();
        public void Ekle(Musteri musteri)
        {
            musteri = new Musteri { Id=musteri.Id,Adi=musteri.Adi,Soyadi=musteri.Soyadi,Eposta=musteri.Eposta,Telefon=musteri.Telefon};
            musteriler.Add(musteri);
           
        }
        public bool Sil(int MusteriId)
        {
            try
            {
                musteri1 = musteriler.FirstOrDefault(p => p.Id == MusteriId);
                if (musteri1.Id!=0)
                {
                    musteriler.Remove(musteri1);
                    return true;
                }
                else
                {
                   return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<Musteri> Listele()
        {
            foreach (var item in musteriler)
            {
                int s = item.Id;
            }
            return musteriler;
        }
       
    }
}
