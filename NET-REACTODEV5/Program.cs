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