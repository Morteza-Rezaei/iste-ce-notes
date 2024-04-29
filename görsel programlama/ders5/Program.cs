using System;

namespace dersBes
{
    class Program
    {
        static int x = 10; // sınıf düzeyinde global değişken
        static void Main(string[] args)
        {
            // diziler- sıralama
            int[] sayilar = { 5, 2, 8 };
            Array.Sort(sayilar); // 2 5 8
            foreach (var item in sayilar)
            {
                Console.Write(item + "  ");
            }

            string[] isimler = { "Baran", "Veli", "Ayşe" };
            Array.Sort(isimler); // Ali Ayşe Veli
            foreach (var item in isimler)
            {
                Console.Write(item + "  ");
            }

            // diziler- doğrusal arama
            int[] sayilar2 = { 5, 2, 8, 5, 8, 8, 5 };
            int bulunanSonuc = 0;
            for (int i = 0; i < sayilar2.Length; i++)
            {
                if (sayilar2[i] == 8)
                {
                    Console.Write("\n{0} ", sayilar2[i]);
                    bulunanSonuc++;
                }
            }
            Console.WriteLine("\n bulunan sonuç sayısı : {0}", bulunanSonuc);

            // diziler- ikili arama
            // ikili arama için dizinin sıralı olması gerekir
            int[] sayilar3 = { 2, 4, 7, 10, 11, 45, 50, 69, 60, 66, 69, 70, 79 };
            int idx = -1;
            int high = sayilar3.Length - 1;
            int low = 0;
            int mid;
            int aranan = 70;
            while (high > low && idx < 0)
            {
                mid = low + (high - low) / 2;

                if (sayilar3[mid] < aranan)
                {
                    low = mid + 1;
                }
                else if (sayilar3[mid] > aranan)
                {
                    high = mid - 1;
                }
                else
                {
                    idx = mid;
                }
            }

            if (idx > -1)
            {
                Console.WriteLine("{0}: {1}", aranan, idx);
            }
            else
            {
                Console.WriteLine("{0}: bulunamadı", aranan);
            }

            // diziler- 2b ve daha fazla boyutlu diziler
            int[,] sayilar4 = new int[2, 3];
            sayilar4[0, 0] = 10; sayilar4[0, 1] = 20; sayilar4[0, 2] = 30;
            sayilar4[1, 0] = 40; sayilar4[1, 1] = 50; sayilar4[1, 2] = 60;
            // veya daha sade bir şekilde
            int[,] sayilar5 = {
                { 10, 20, 30 },
                { 40, 50, 60 }
            };

            // diziler- 2b ve daha fazla boyutlu diziler- döngü ile yazdırma
            for (int i = 0; i < sayilar5.GetLength(0); i++)
            {
                // dimension 0 = satır sayısı
                // dimension 1 = sütun sayısı
                for (int j = 0; j < sayilar5.GetLength(1); j++)
                {
                    Console.Write("{0, 3}", sayilar5[i, j]);
                }
                Console.WriteLine();
            }

            // diziler- dizilerin dizisi
            int[][] sayilar6 = new int[2][];
            sayilar6[0] = new int[3] { 10, 20, 30 };
            sayilar6[1] = new int[2] { 40, 50 };
            // veya daha sade bir şekilde
            int[][] sayilar7 =
            {
                new int[] { 10, 20, 30 },
                new int[] { 40, 50 }
            };
            // dönü ile yazdırma
            for (int i = 0; i < sayilar7.Length; i++)
            {
                for (int j = 0; j < sayilar7[i].Length; j++)
                {
                    Console.Write("{0, 3}", sayilar7[i][j]);
                }
                Console.WriteLine();
            }
            foreach (int[] row in sayilar7)
            {
                foreach (var item in row)
                {
                    Console.Write("{0, 3}", item);
                }
                Console.WriteLine();
            }


            // veri yapıları- List 
            List<string> ogrenciler = new List<string>();
            ogrenciler.Add("Baran");
            ogrenciler.Add("Veli");
            ogrenciler.Add("Ayşe");

            foreach (string isim in ogrenciler)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine(ogrenciler.Contains("Baran"));  // true
            Console.WriteLine(ogrenciler.Contains("Mehmet"));  // false

            // veri yapıları- Stack 
            Stack<string> stack = new Stack<string>();
            stack.Push("A"); // first in
            stack.Push("B");
            stack.Push("C");
            stack.Push("D"); // last in

            Console.WriteLine(stack.Peek()); // çıktı D
            Console.WriteLine(stack.Pop()); // çıktı D ve D silindi

            foreach (string item in stack)
            {
                Console.WriteLine(item);  // çıktı C B A
            }
            Console.WriteLine(stack.Count); // çıktı 3


            // veri yapıları- Dictionary
            Dictionary<string, string> sozluk = new Dictionary<string, string>();
            sozluk.Add("book", "kitap");
            sozluk.Add("table", "masa");

            foreach (KeyValuePair<string, string> entry in sozluk)
            {
                Console.WriteLine("{0, 15} : {1, 10}", entry.Key, entry.Value);

            }
            Console.WriteLine(sozluk.ContainsKey("book")); // true
            Console.WriteLine(sozluk.ContainsValue("masa")); // true


            // yöntemler (fonsksiyonlar) 

            // iki sayi arasından en büyük olanı bulan fonksiyon
            static int max(int a, int b)
            {
                return a > b ? a : b;
            }

            // return olmayan fonksiyon
            static void yazdir(string metin)
            {
                Console.WriteLine(metin);
            }

            // dizi referansı dönen bir fonksiyon
            static int[] ArrayFactory(int size, int low, int high)
            {
                int[] array = new int[size];
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(low, high + 1);
                }
                return array;
            }
            int[] myArray = ArrayFactory(5, 1, 3);

            foreach (int number in myArray)
            {
                Console.WriteLine("{0, 10}", number);
            }

            // yöntemler - değişken kapsamı 


            static void deneme()
            {
                int x = 20; // fonksiyon düzeyinde yerel değişken
                x = x + 1;
                Console.WriteLine(x); // 21
                AddOne();            // 11
                Console.WriteLine(x); // 21

            }

            static void AddOne()
            {
                x = x + 1;
                Console.WriteLine(x);
            }

            deneme();

            // fonksiyonlar - referans gönderme
            static void degistir(ref int x , ref int y)
            {
                int z = x;
                x = y;
                y = z;
            }

            int a = 10;
            int b = 20;
            degistir(ref a, ref b);
            Console.WriteLine("a: {0} b: {1}", a, b); // a: 20 b: 10

            // in ve out parametreler
            static void degistir2(in int x, out int y)
            {
                // x = 20; // hata yani in parametreler değiştirilemez 
                y = x;  // out parametrelerin değeri atanmalıdır
            }

            int c = 10;
            int d;
            degistir2(in c, out d);  
            Console.WriteLine("c: {0} d: {1}", c, d); // c: 10 d: 10



        }
    }
}