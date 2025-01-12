using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Bir Seçim Yapınız: ");
    Console.WriteLine("1 - İsim Yazdır");
    Console.WriteLine("2 - Toplama İşlemi Yap");
    Console.WriteLine("3 - Çıkış İşlemini Gerçekleştir");

    int secim =int.Parse(Console.ReadLine());

    switch (secim) 
    {
        case 1:
            Console.WriteLine("Merhaba, Dünya!");
        break;
        case 2:
            Console.WriteLine("5+3="+ (5+3));
        break;
        case 3:
            Console.WriteLine("Programdan Çıkılıyor...");
        break;
        default:
            Console.WriteLine("Geçersiz Bir Seçim Yaptınız.");
        break;
    }
  }
}
