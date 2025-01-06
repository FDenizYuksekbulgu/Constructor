//PARAMETRESİZ CONSTRUCTOR
using System;

class Bebek
{
    //Fields (Alanlar) belirleyelim.

    private DateTime dogumTarihi;
    private string ad;
    private string soyad;

    //Property: Doğum Tarihi belirleyelim.
    public DateTime DogumTarihi
    {
        get { return dogumTarihi; }
        private set { dogumTarihi = value; }  // Doğum tarihini get ile dışarıdan ulaşılmasına izin verdik.
       
        //Ancak private set yapmamızın nedeni değer atanması yalnızca sınıfın içinden gerçekleşsin diyedir.
    }

    //Property: Ad belirleyelim.
    public string Ad
    {
        get { return ad; }
        set { ad = value; }
    }

    //Property: Soyad belirleyelim.
    public string Soyad
    {
        get { return soyad; }
        set { soyad = value; }
    }

    public Bebek()
    {
        DogumTarihi = DateTime.Now;//Doğum tarihini şu an olarak atıyoruz.
        Ad = "Bilinmiyor";         //Default ad
        Soyad = "Bilinmiyor";      //Default soyad
        Console.WriteLine("Ingaaaaaaaa.."); // Bebek sesi
    }

    //Bebek bilgilerini yazdıran metot
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi}");
    }
}

class Program
{
    static void Main()
    {
   
        Bebek bebek1 = new Bebek();
        bebek1.BilgileriYazdir(); //Bilgiler ekrana yazdıralım.
    }
}
Console.WriteLine("------------------------------------------------------------------------------------");

//PARAMETRELİ CONSTRUCTOR

using System;

class Bebek
{
    // Fields (Alanlar) belirleyelim.
    private DateTime dogumTarihi;
    private string ad;
    private string soyad;

    // Property: Doğum Tarihi belirleyelim.
    public DateTime DogumTarihi
    {
        get { return dogumTarihi; }
        private set { dogumTarihi = value; }
    }

    // Property: Ad belirleyelim.
    public string Ad
    {
        get { return ad; }
        set { ad = value; }
    }

    // Property: Soyad belirleyelim.
    public string Soyad
    {
        get { return soyad; }
        set { soyad = value; }
    }

    
    public Bebek(string ad, string soyad)
    {
        DogumTarihi = DateTime.Now; // Doğum tarihini şu an olarak atıyoruz.
        Ad = ad;
        Soyad = soyad;
        Console.WriteLine("Ingaaaaaaa..."); //çıktısı bu olacak
    }

    // Bebek bilgilerini BilgileriYazdir metoduyla yazdıralım.
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi}");
    }
}

class Program
{
    static void Main()
    {
        Bebek bebek1 = new Bebek("Ahmet", "Yılmaz");
        bebek1.BilgileriYazdir(); 
    }
}

