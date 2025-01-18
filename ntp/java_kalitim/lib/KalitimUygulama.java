public class KalitimUygulama {
    public static void main(String[] args) {
        Hayvan hayvan = new Hayvan();
        hayvan.Goster();

        System.out.println("-----------------");

        Etcil etcilHayvan = new Etcil();
        etcilHayvan.CeneYapisi();
        etcilHayvan.Beslenme();
        etcilHayvan.Goster();

        System.out.println("-----------------");

        Otcul otculHayvan = new Otcul();
        otculHayvan.Beslenme();
        otculHayvan.CeneYapisi();
        otculHayvan.Goster();

        System.out.println("-----------------");

        Kuslar kuslarHayvan = new Kuslar(13, 35);
        kuslarHayvan.yumurta();
        kuslarHayvan.Goster();

        System.out.println("-----------------");

        Hayvan hayvan2 = new Hayvan(45);
        hayvan2.Goster();

    }
}
