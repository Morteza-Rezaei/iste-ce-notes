public class Kurucular {
    public int a;
    public String ad;

    public static void main(String[] args) {
        Kurucular nesne = new Kurucular();
        System.out.println("Defualt kurucu için a: " + nesne.a);
        System.out.println("Defualt kurucu için ad: " + nesne.ad);

        System.out.println("-------------------------------");

        Kurucular nesne2 = new Kurucular(100);
        System.out.println("Defualt kurucu için a: " + nesne2.a);
        System.out.println("Defualt kurucu için ad: " + nesne2.ad);

        System.out.println("-------------------------------");

        Kurucular nesne3 = new Kurucular("Morteza");
        System.out.println("Defualt kurucu için a: " + nesne3.a);
        System.out.println("Defualt kurucu için ad: " + nesne3.ad);

        System.out.println("-------------------------------");

        Kurucular nesne4 = new Kurucular(23, "Morteza R");
        System.out.println("Defualt kurucu için a: " + nesne4.a);
        System.out.println("Defualt kurucu için ad: " + nesne4.ad);
    }

    // defualt nesne oluştuğu zaman bu fonksiyon çalışır
    // this => Kurucular
    Kurucular() {
        this.a = 0;
        this.ad = "Varsayılan";
    }

    Kurucular(int a) {
        this.a = a;
        this.ad = "-Varsayılan-";
    }

    Kurucular(String ad) {
        this.a = -2;
        this.ad = ad;
    }

    Kurucular(int a, String ad) {
        this.a = a;
        this.ad = ad;
    }

    // Yıkıcı fonksiyon : Deconstructer
    public void finalize() {
        System.out.println("dümenden deconstructer tetiklendi");
    }

}
