public interface BasitInterface {
    final int a = 10;

    // Abstract fonksiyon
    void Goruntule();

    int DegerGetir(int a, double b);

    double Degerler();

    // Interface de final tanımlama yapılamaz
    // final double Deneme();
    // Interface de static tanımlı fonksiyon kullanılamaz
    // static double Deneme2();
    // Interface de abstract tanımlama dışında fonksiyon tanımı yapılmaz
    /*
     * public String Deneme3(){
     * System.out.println("Deneme");,
     * return "";
     * }
     */

}

interface BasitInterface2 {
    int Durum1();

    double Durum2(double a);
}

// Interface ten doğrudan nesne üretilemez
// dolayısıyla class turetilerek nesne üretiriz
class TestInterface1 implements BasitInterface {

    @Override
    public void Goruntule() {
        System.out.println("Goruntule fonksiyonu çalıştı");
    }

    @Override
    public int DegerGetir(int a, double b) {
        return a;
    }

    @Override
    public double Degerler() {
        return 0;
    }

    // yeni fonksiyon eklemeleri de yapılır
    public void DenemeFonk1() {
    }
}

class TestInterface2 implements BasitInterface, BasitInterface2 {

    @Override
    public void Goruntule() {
        System.out.println("Goruntule fonksiyonu çalıştı");
    }

    @Override
    public int DegerGetir(int a, double b) {
        return a;
    }

    @Override
    public double Degerler() {
        return 0;
    }

    @Override
    public int Durum1() {
        return 0;
    }

    @Override
    public double Durum2(double a) {
        return 0;
    }

}
