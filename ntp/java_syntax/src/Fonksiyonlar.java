public class Fonksiyonlar {
    public static void main(String[] args) {
        toplam(12, 12);
        System.out.println("----------------------");

        int a = 11, b = 6;
        int c = minSayi(a, b);
        System.out.println("Küçük değer: " + c);

    }

    // void fontsiyon geriye bişey döndürmez
    public static void toplam(int x, int y) {
        System.out.println("iki sayının toplamı: " + (x + y));
    }

    // return ile geriye değer döndürme
    public static int minSayi(int x, int y) {
        int min;
        if (x > y)
            min = y;
        else
            min = x;
        return min;
    }
}