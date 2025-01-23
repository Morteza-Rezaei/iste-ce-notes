public class AbstractSiniflar {
    public static void main(String[] args) throws Exception {
        Generaller a = new Generaller();
        a.EnUstKomuta("Savaş");

        // Abstract class'tan nesne oluşturulmak istenirse
        // Sınıf içerisinde override edilecek fonksiyon getirilir
        Asker deneme = new Asker() {
            @Override
            public void Yetki() {
                // TODO Auto-generated method stub
                throw new UnsupportedOperationException("Unimplemented method 'Yetki'");
            }
        };
    }
}

abstract class Asker {
    int yas = 18;

    // getter fonksiyonu
    public int getYas() {
        return yas;
    }

    // setter fonksiyonu
    public void setYas(int yas) {
        this.yas = yas;
    }

    // normal class yapılarında abstract tanımlama yapılmaz
    // asbtract tanımlama :
    // kod bloğu içermeyecek şekilde fonksiyon adı, dönüş tipi ve erişim değeri olan
    // fonksiyondur
    public abstract void Yetki();

    // finalize: deconstructure yıkıcı

    // final: değiştirilemeyen fonksiyonlardır
    // kalıtım sonrası türetilecek olan yeni classlarda override edilemez
    public final void EnUstKomuta(String durum) {
        if (durum == "Savaş") {
            System.out.println("Askeriyeyi Cumhurbaşkanı yönetir");
        } else {
            System.out.println("Askeriyeyi genel kurmay başkanı yönetir");
        }
    }

}

class Generaller extends Asker {
    @Override
    // abstract tanımlanmış olan fonksiyonlar kesinlikle override edilmelidir
    public void Yetki() {
        System.out.println("Komuta zincirinin en üstündedir");
    }

    // final olduğu için override edilemedi
    // public final void EnUstKomuta(String durum) {
    // /* */
    // }
}

class Er extends Asker {
    @Override
    // abstract tanımlanmış olan fonksiyonlar kesinlikle override edilmelidir
    public void Yetki() {
        System.out.println("Komuta zincirinin en alt kademesidir");
    }
}