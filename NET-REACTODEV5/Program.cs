/*
  Döngüler (for, while) Ne İşe Yarar? Hangisi Hangi Durumda Kullanılır?

Döngüler, belirli bir işlemi birden fazla kez tekrarlamak için kullanılır. Programlamada en çok kullanılan döngüler for ve while döngüleridir.

For Döngüsü: Belirli bir sayıda tekrarı önceden belirlemek için kullanılır. Genellikle, döngünün kaç kere çalışacağı biliniyorsa kullanılır. İndeksli döngülerde sıklıkla tercih edilir.


While Döngüsü: Belirli bir koşul sağlandığı sürece çalışmaya devam eder. Döngü başlatıldıktan sonra, koşul doğru olduğu sürece döngü devam eder. Koşul başta ya da sonunda kontrol edilebilir.

Kullanım Durumu: Döngüde kaç kez çalışacağı önceden bilinmediğinde ve koşul doğru olduğu sürece devam etmesi gereken durumlarda kullanılır.
 */

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}



Console.Write("Bir sayı girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());

int toplam = 0;



for (int i = 1; i <= sayi; i++)
{
    toplam += i;  
}


Console.WriteLine("1'den {0}'a kadar olan sayıların toplamı: {1}", sayi, toplam);


/*
 Koşullu İfadeler (if-else) Ne İşe Yarar? Gerçek Hayattan Bir Örnek Verin.

Koşullu ifadeler, belirli bir koşulun doğru ya da yanlış olmasına göre farklı kod parçalarının çalışmasını sağlar. Yani, bir koşulun sonucuna göre programın akışı değiştirilir.

If (Eğer): Eğer verilen koşul doğruysa, belirli bir işlem yapılır.
Else (Değilse): Eğer koşul doğru değilse, alternatif bir işlem yapılır.
Gerçek Hayattan Bir Örnek: Bir restoranda, eğer müşteri bir içecek sipariş ederse, o içeceğin sıcak mı soğuk mu olduğunu kontrol etmek gerekebilir. Eğer içecek sıcaksa, "Bu içecek dikkatli içilmeli" denir; eğer soğuksa, "Afiyet olsun" denir.



 */

// Sayının tek mi çift mi olduğu kontrol etme
Console.Write("Bir sayı girin: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());


if (sayi1 % 2 == 0)
{
    Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tektir.");
}


//  Girilen Bir Sayının Pozitif, Negatif veya Sıfır Olup Olmadığını Belirleme

Console.Write("Bir sayı girin: ");
int sayi3 = Convert.ToInt32(Console.ReadLine());


if (sayi > 0)
{
    Console.WriteLine("Girdiğiniz sayı pozitif.");
}
else if (sayi < 0)
{
    Console.WriteLine("Girdiğiniz sayı negatif.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı sıfır.");
}


/*
  C#’ta Kullanılan Temel Veri Tipleri Nelerdir?

C# dilinde, farklı türdeki verileri saklamak için çeşitli temel veri tipleri bulunur. İşte en yaygın kullanılan temel veri tipleri:

int: Tam sayıları saklamak için kullanılır. Örneğin, -1, 0, 100 gibi.
double: Ondalıklı sayıları saklamak için kullanılır. Örneğin, 3.14, -5.5, 10.0 gibi.
float: double türüne benzer ancak daha küçük hassasiyetle çalışır. Örneğin, 5.5f.
char: Tek bir karakteri saklamak için kullanılır. Örneğin, 'a', 'B', '9' gibi.
bool: Mantıksal değerleri saklar (doğru ya da yanlış). Örneğin, true, false.
string: Karakter dizilerini (metinleri) saklamak için kullanılır. Örneğin, "Merhaba", "C#" gibi.
decimal: Yüksek hassasiyet gerektiren sayıları saklamak için kullanılır (finansal hesaplamalar için tercih edilir). Örneğin, 10.5m.
long: Çok büyük tam sayıları saklar. Örneğin, 1234567890.
short: Küçük boyutlu tam sayıları saklar. Örneğin, -32768, 32767 gibi.
byte: 0 ile 255 arasındaki sayıları saklar. Örneğin, 0, 255 gibi.



 Aşağıdaki Değişkenlerin Bellek Kullanımını Karşılaştırın:

int x = 5;: int veri tipi 4 bayt (32 bit) bellek kullanır. Bu, -2,147,483,648 ile 2,147,483,647 arasında tam sayılar için geçerlidir.

double y = 5.2;: double veri tipi 8 bayt (64 bit) bellek kullanır. Bu, daha geniş bir hassasiyetle ondalıklı sayıları saklamak için kullanılır.

string name = "Mehmet";: string veri tipi, bir referans türüdür ve bellek kullanımını doğrudan değiştiren birçok faktör vardır. İçerdiği karakter sayısına bağlı olarak değişir. Her bir karakter 2 bayt (UTF-16) ile saklanır. Bu nedenle, "Mehmet" ismi 7 karakterden oluşur ve yaklaşık 14 bayt (7 x 2 bayt) bellek kullanır. Ancak, string değişkeni aslında referans tipidir, bu yüzden bellek kullanımı sadece string içeriği değil, aynı zamanda bu içeriği saklayan belleği de kapsar.

Özet:
 */

// Kullanıcıdan İki Sayı Alıp Toplamını Ekrana Yazdıran Bir Program:
Console.Write("Birinci sayıyı girin: ");
int sayi4 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı girin: ");
int sayi5 = Convert.ToInt32(Console.ReadLine());

// Sayıların toplamı hesaplanır
int toplam2 = sayi4 + sayi5;

// Sonuç ekrana yazdırılır
Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam);



/*
 C# Programlama Dili Nedir? Hangi Alanlarda Kullanılır?

C#, Microsoft tarafından geliştirilmiş, modern ve güçlü bir programlama dilidir. .NET Framework ve .NET Core üzerinde çalışan, nesne yönelimli (OOP) bir dildir. C#, tip güvenliğini sağlayarak, kolayca büyük ve bakımı yapılabilir yazılımlar geliştirilmesini sağlar. Hem masaüstü hem de web uygulamaları geliştirmek için yaygın olarak kullanılır.

C# Kullanım Alanları:

Masaüstü Uygulamaları: C# ile Windows Forms veya WPF (Windows Presentation Foundation) gibi araçlar kullanarak masaüstü uygulamaları geliştirilebilir.
Web Uygulamaları: ASP.NET ve ASP.NET Core kullanarak web uygulamaları ve API'ler geliştirilebilir.
Mobil Uygulamalar: Xamarin ile C# kullanarak Android ve iOS için mobil uygulamalar yapılabilir.
Oyun Geliştirme: Unity oyun motoru, C# dilini kullanarak oyun geliştirmeye olanak sağlar.
Veritabanı Uygulamaları: ADO.NET ve Entity Framework gibi teknolojilerle veritabanı ile etkileşimli uygulamalar yazılabilir.
Gömülü Sistemler: C# dilinin, gömülü sistemlerde ve IoT projelerinde kullanımı yaygınlaşmaktadır.
2️⃣ Bir Programın Çalışması İçin Temel Bileşenler Nelerdir?

Bir programın çalışabilmesi için çeşitli bileşenler gereklidir:

Derleyici (Compiler): Kaynak kodunu makine diline çeviren bir yazılımdır. C# gibi yüksek seviyeli diller, derleyici yardımıyla çalıştırılabilir hale gelir. C# için kullanılan derleyici genellikle Visual Studio veya .NET SDK'dır.

RAM (Random Access Memory): Programın çalışırken geçici verilerini saklamak için kullanılan bellek türüdür. RAM, işlemcinin (CPU) veriye hızlı erişmesini sağlar.

CPU (Central Processing Unit): Bilgisayarın beyin kısmıdır. Programın çalıştırılması ve hesaplamalar yapılması gibi işlemler CPU tarafından gerçekleştirilir.

Depolama Birimi (Hard Disk veya SSD): Programın sabit verilerini saklamak için kullanılan bir bileşendir. Kaydedilen dosyalar, veritabanları ve program dosyaları depolama biriminde yer alır.

İşletim Sistemi (OS): Programın çalışabilmesi için bir ortam sağlar. İşletim sistemi, kaynakların yönetimi, kullanıcı arayüzü, dosya yönetimi gibi temel işlemleri gerçekleştirir.

Giriş/Çıkış Birimleri: Kullanıcıdan veri almak ve sonuçları görüntülemek için kullanılan donanımlar (klavye, ekran, fare, vb.).


 */


//  Kullanıcıdan Adını Alıp Ekrana Yazdıran Basit Bir C# Programı:
Console.Write("Adınızı girin: ");
string ad = Console.ReadLine();


Console.WriteLine("Merhaba, " + ad + "!");