using System;

namespace dersUc
{
    class Program
    {
        static void Main(string[] args)
        {
            // karakterler ve 
            char c = 'a';
            Console.WriteLine(c + 1 + "  çünkü ascii tablosunda c = 97 sayısına denk geliyor");

            string s = "C#";
            Console.WriteLine(s + 999 + "  string ifadelerde + operatörü ile birleştirme yapılır");

            // birleşik atama operatörleri
            int a = 5;
            Console.WriteLine(a++); // önce yazdır 5 sonra arttır 6
            Console.WriteLine(++a); // önce arttır 7 sonra yazdır 7

            Console.WriteLine("3 artar {0} -- 3 azalır {1} -- 3 e çarpımı {2} -- 3 e bölümü {3} -- 3 e bölümünden kalan {4}", a += 3, a -= 3, a *= 3, a /= 3, a %= 3);

            // console ile kullanıcıdan veri alma
            Console.Write("Adınızı giriniz: ");
            string? ad = Console.ReadLine();
            Console.WriteLine("Merhaba " + ad);

            Console.Write("Dairenin Yarıçapını Giriniz: ");
            int r = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Dairenin Alanı: " + (Math.PI * r * r));

            // Vücut Kitle İndeksi
            Console.WriteLine("Lütfen Boyunuzu Giriniz (cm): ");
            double boy = double.Parse(Console.ReadLine()!) / 100;
            Console.WriteLine(boy);

            Console.WriteLine("Lütfen Kilonuzu Giriniz (kgw): ");
            double kilo = double.Parse(Console.ReadLine()!);

            double bmi = kilo / (boy * boy); // wieght / height^2

            Console.WriteLine(ad + "Vücut Kitle İndeksiniz: " + bmi);

            // string biçimlendirme
            Console.WriteLine("Merhaba {0} {1} ({2})", "C#", "Ders", 3); // Merhaba C# Ders (3)
            Console.WriteLine("Merhaba {0, 5} {1, 10} ({2, 5:F2})", "C#", "Ders", 333333.333333); // Merhaba    C#       Ders (333333,33)
            Console.WriteLine("{0, 12}", "Microsoft"); //    Microsoft

            // rastgele sayı üretme
            Random rng = new Random();
            int x = rng.Next(10); // 0 ile 10 arasında bir sayı üretir
            int y = rng.Next(10);
            Console.WriteLine("{0} + {1} = ?", x, y);
            int g = int.Parse(Console.ReadLine());
            if (g == x + y)
            {
                Console.WriteLine("Tebrikler Bildiniz");
            }
            else
            {
                Console.WriteLine("Üzgünüm Bilemediniz");
            }



        }
    }
}