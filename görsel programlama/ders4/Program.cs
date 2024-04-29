using System;

namespace dersDort
{
    class Program
    {
        static void Main(string[] args)
        {
            // -50 ile 50 arasında rastgele üç sayı üretin daha sonra sıralayın.
            Random rng = new Random();
            int x = rng.Next(-50, 51);
            int y = rng.Next(-50, 51);
            int z = rng.Next(-50, 51);
            Console.WriteLine("üretilen sayılar => {0} , {1} , {2}", x, y, z);
            if (x > y)
            {
                int tmp = x; x = y; y = tmp;  // swap (exchange)
            }
            if (y > z)
            {
                int tmp = y; y = z; z = tmp;
            }
            if (x > y)
            {
                int tmp = x; x = y; y = tmp;
            }
            Console.WriteLine("sıralanmış şekli => {0} , {1} , {2}", x, y, z);

            // break döngüyü sonlandırır.
            // continue döngüyü sonlandırmaz ama o adımda işlem yapmaz.

            // bir yatırım işleminde yatırılan paranın 2 katına çıkması için gereken yıl sayısını bulunuz.
            // ana para = anapara * (1+ faiz oranı)
            double balance = 100;
            double goal = 200;
            double r = 0.18;
            int years = 0;
            while (balance < goal)
            {
                balance *= (1 + r);
                years++;
            }
            Console.WriteLine("yıl sayısı = {0}    bakiye = {1}", years, balance);

            // çarpım tablosu
            for (int i = 1; i <= 5; i++)
            {
                // row i , column j
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0, 3}", i * j);
                }
                Console.WriteLine();
            }

            // rastgele üretilen noktalardan pi sayısını bulmak
            int n = 1000000;  // toplam nokta sayısı
            int m = 0;        // daire içindeki nokta sayısı
            for (int i = 1; i <= n; i++)
            {
                double x1 = rng.NextDouble();
                double y1 = rng.NextDouble();
                if (x1 * x1 + y1 * y1 < 1) m++;
            }
            Console.WriteLine("pi = {0}", 4.0 * m / n);

            // diziler

            // 5 elemanlı bir dizi tanımlayın ve elemanları rastgele sayılarla doldurun.
            int[] dizi = new int[5];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rng.Next(10);  // 0 ile 10 arasında bir sayı üretir
            }

            // for döngüsü ile dizinin elemanlarını yazdırmak
            Console.WriteLine("for ile yazdırmak");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0, 3}", dizi[i]);
            }

            // foreach döngüsü ile dizinin elemanlarını
            Console.WriteLine("\nforeach ile yazdırmak");
            foreach (var elemanlar in dizi)
            {
                Console.Write("{0, 3}", elemanlar);
            }

            // min ve max değerleri bulunuz
            int min = dizi[0];
            int max = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] < min) min = dizi[i];
                if (dizi[i] > max) max = dizi[i];
            }
            Console.WriteLine("\nmin = {0}   max = {1}", min, max);

            // dizideki elemanların toplamını bulunuz
            int sum = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                sum += dizi[i];
            }
            Console.WriteLine("toplam = {0}", sum);

            // sığ kopyalama
            int[] dizi2 = dizi;
            dizi[0] = 999;
            Console.WriteLine("sığ kopyalama => dizi[0] = {0}   dizi2[0] = {1}", dizi[0], dizi2[0]);

            // derin kopyalama 1 yöntem
            int[] dizi3 = new int[dizi.Length];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi3[i] = dizi[i];
            }
            dizi[0] = 888;
            Console.WriteLine("derin kopyalama 1 yöntem=> dizi[0] = {0}   dizi3[0] = {1}", dizi[0], dizi3[0]);

            // derin kopyalama 2 yöntem
            int[] dizi4 = new int[dizi.Length];
            Array.Copy(dizi, dizi4, dizi.Length); // dizi.length Kopyalanacak eleman sayısını belirtir
            dizi[0] = 777;
            Console.WriteLine("derin kopyalama 2 yöntem=> dizi[0] = {0}   dizi4[0] = {1}", dizi[0], dizi4[0]);

            // dizi karıştırma
            for (int i = 0; i < dizi.Length; i++)
            {
                int j = rng.Next(dizi.Length - i) + i;  // 0 ile dizi.length arasında bir sayı üretir
                // swap dizi[i] ve dizi[j] elemanlarını değiştirir
                int tmp = dizi[i];
                dizi[i] = dizi[j];
                dizi[j] = tmp;
            }
            Console.WriteLine("dizi karıştırma");
            foreach (var elemanlar in dizi)
            {
                Console.Write("{0, 6}", elemanlar);
            }


            // 52 kağıdını karıştırarak ilk 5 kartı yazdırınız
            string[] suits = { "club", "daimond", "heart", "spade" };
            string[] ranks = {"2", "3", "4", "5", "6", "7", "8", "9", "10",
                                         "jack", "queen", "king", "ace"};

            int[] deck = new int[52];
            for (int i = 0; i < deck.Length; i++) deck[i] = i;

            for (int i = 0; i < deck.Length - 1; i++)
            {
                int j = rng.Next(deck.Length - i) + i;
                int tmp = deck[i]; deck[i] = deck[j]; deck[j] = tmp;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n[{0, 20} {1, -20}]",ranks[deck[i] % 13], suits[deck[i] / 13]);
            }

        }
    }
}