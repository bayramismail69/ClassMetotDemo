using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
         
            MusteriManager musteriManager = new MusteriManager();
            bool Durum = false;
            while (Durum != true)
            {
                Console.WriteLine("Lütfen İşlem Şeçiniz");
                Console.WriteLine("0 Müsteri Ekle");
                Console.WriteLine("1 Musteri Sil");
                Console.WriteLine("2 Musteri Listele");
                string SecilenIslem = Convert.ToString(Console.ReadLine());

                if (SecilenIslem == "0")
                {
                    Console.WriteLine("Musteri Id (Lütfen Sayısal değer giriniz)");//Normalde burası veri tabanı tarafından yada uniq key tarafından oluşturulur
                    int Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Musteri Adı");
                    string musteriAdi = Console.ReadLine();
                    Console.WriteLine("Musteri Soyadı");
                   string musteriSoyadi = Console.ReadLine();
                    Console.WriteLine("Musteri Telefon");
                   string musteriTelefon = Console.ReadLine();
                    Console.WriteLine("Musteri Eposta");
                  string  musteriEposta = Console.ReadLine();
                    Console.WriteLine("Müsteri Eklensinmi? Evet / Hayır");
                    string Cevab = Console.ReadLine();
                    if (Cevab.ToUpper() == "EVET")
                    {
                        musteri.Id = Id;
                        musteri.Adi = musteriAdi;
                        musteri.Soyadi = musteriSoyadi;
                        musteri.Telefon = musteriTelefon;
                        musteri.Eposta = musteriEposta;
                        musteriManager.Ekle(musteri);
                       
                        Console.Clear(); 
                        Console.WriteLine("**************** Musteri Eklendi *****************");
                    
                    }
                    else
                    {
                        Durum = false;
                        Console.Clear();
                    }


                }
                else if (SecilenIslem == "1")
                {
                    Console.Clear();
                    Console.WriteLine("********* Silinecek müsteriyi Seçiniz *********");
                    Console.WriteLine("(;)Müsteri Id   (=) Müsteri Adı   (+)  Müsteri Soyadı ");
                    foreach (var item in musteriManager.Listele())
                    {
                        Console.WriteLine("(;)" + item.Id + " " + " (=)" + item.Adi + " (+)" + item.Soyadi);
                    }
                    Console.WriteLine("Musteri Id ");
                    int silinecekMusteriId =int.Parse(Console.ReadLine());
                  bool silinmeDurumu=  musteriManager.Sil(silinecekMusteriId);
                    if (silinmeDurumu!=false)
                    {
                        Console.Clear();
                        Console.WriteLine("******** Basarıyla Silindi ********");

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("******** Silme İşlemi Başarısız ********");
                    }
                  
                }
                else if (SecilenIslem == "2")
                {
                    Console.Clear(); 
                    Console.WriteLine("********* Kayıtlı Müsteriler *********");
                    Console.WriteLine("(;)Müsteri Id   (=) Müsteri Adı   (+)  Müsteri Soyadı    (-) Müsteri Telefon      (*)  Müsteri Eposta");
                    foreach (var item in musteriManager.Listele())
                    {                                      
                        Console.WriteLine("(;)"+item.Id+" "+" (=)"+item.Adi+" (+)"+item.Soyadi+" (-)"+item.Telefon+" (*)"+musteri.Eposta);
                    }  
                }
                else
                {
                    Console.WriteLine("Hatalı Parametre");
                    Console.Clear();
                }
            }
        }
    }
}
