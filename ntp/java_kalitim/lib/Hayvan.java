public class Hayvan {
    public static double kilo = 0, boy = 0;
    public static String yasananYer = "";

    // parametresiz kururcu
    Hayvan() {
        System.out.println("Hayvan parametresiz kurucu tetiklendi");
    }

    // parametreli kururcu
    Hayvan(double kilo) {
        this.kilo = kilo;
        System.out.println("Hayvan kurucusu tetiklendi kilo: " + kilo);
    }

    // Kurucu fonksiyon değildir her ne kadar kurucu ile ayni ismi olsa da
    // bu normal bir fonksiyondur
    public void Hayvan() {
        System.out.println("Hayvan isminde fonksiyon çalıştırıldı (kurucu fonksiyon değil)");
    }

    public void Beslenme() {
        System.out.println("Beslenme isminde fonksiyon çalıştırıldı");
    }

    public void YasadigiYer() {
        System.out.println("YasadigiYer isminde fonksiyon çalıştırıldı");
    }

    public void Solunum() {
        System.out.println("Solunum isminde fonksiyon çalıştırıldı");
    }

    public void CeneYapisi() {
        System.out.println("CeneYapisi isminde fonksiyon çalıştırıldı");
    }

    public void Goster() {
        System.out.println("Kilosu: " + this.kilo + "   Boyu: " + this.boy);
    }

}

class Etcil extends Hayvan {
    public Etcil() {
        System.out.println("Etcil sinifinin kurucusu tetiklendi");
    }

    // not: static fonksiyonlar override olmazlar

    // katılıtdığı sınıfta var olan fonksiyonun üzerine bindirmek yani:
    // Yeni Özellikler eklemek.
    @Override
    public void Beslenme() {
        System.out.println("Etçil -- Beslenme isminde fonksiyon çalıştırıldı");
    }

    @Override
    public void CeneYapisi() {
        System.out.println("Etçil -- CeneYapisi isminde fonksiyon çalıştırıldı");
    }

    public void EtcilGoster() {
        // super:
        // En üst sınıfın isminin yerini tutan özel tanımlamadır
        super.Goster();
    }
}

class Otcul extends Hayvan {
    public Otcul() {
        System.out.println("Otcul sinifinin kurucusu tetiklendi");
    }

    // not: static fonksiyonlar override olmazlar

    // katılıtdığı sınıfta var olan fonksiyonun üzerine bindirmek yani:
    // Yeni Özellikler eklemek.
    @Override
    public void Beslenme() {
        System.out.println("Otçul -- Beslenme isminde fonksiyon çalıştırıldı");
    }

    @Override
    public void CeneYapisi() {
        System.out.println("Otçul -- CeneYapisi isminde fonksiyon çalıştırıldı");
    }

    public void OtculGoster() {
        // super:
        // En üst sınıfın isminin yerini tutan özel tanımlamadır
        super.Goster();
    }
}

class Kuslar extends Etcil {
    public Kuslar() {
        System.out.println("kuslar sinifinin kurucusu tetiklendi");
    }

    public Kuslar(double boy, double kilo) {
        this.boy = boy;
        this.kilo = kilo;
        System.out.println("kuslar sinifinin parametreli kurucusu tetiklendi");
        System.out.println("-->> Kilosu: " + this.kilo + "   Boyu: " + this.boy);
    }

    // not: static fonksiyonlar override olmazlar

    // katılıtdığı sınıfta var olan fonksiyonun üzerine bindirmek yani:
    // Yeni Özellikler eklemek.
    @Override
    public void Beslenme() {
        System.out.println("Kuşlar -- Beslenme isminde fonksiyon çalıştırıldı");
    }

    @Override
    public void CeneYapisi() {
        System.out.println("Kuşlar -- CeneYapisi isminde fonksiyon çalıştırıldı");
    }

    public void yumurta() {
        System.out.println("Kuşlar -- Yumurtlarlar");
    }

    public void KuslarGoster() {
        // super:
        // En üst sınıfın isminin yerini tutan özel tanımlamadır
        super.Goster();
    }
}
