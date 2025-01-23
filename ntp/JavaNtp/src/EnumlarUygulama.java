public class EnumlarUygulama {
    public static void main(String[] args) {
        System.out.println(Islemler.Carp.Hesapla(15, 5));

    }

}

enum Islemler {
    Topla, Cikar, Carp, Bol;

    public double Hesapla(double sayi1, double sayi2) {
        double sonuc = 0;
        switch (this) {
            case Topla:
                sonuc = sayi1 + sayi2;
                break;
            case Cikar:
                sonuc = sayi1 - sayi2;
                break;
            case Carp:
                sonuc = sayi1 * sayi2;
                break;
            case Bol:
                sonuc = sayi1 / sayi2;
                break;

            default:
                sonuc = -1;
                break;
        }
        return sonuc;
    }
}
