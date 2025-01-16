public class GarbageCollector {
    public static void main(String[] args) {
        for (int i = 0; i < 10; i++) {
            Uret a = new Uret(i);
        }
        System.out.println("---------------------");

        // Garbage collector çalıştırma

        System.gc();
        for (int i = 0; i < 10; i++) {
            Uret a = new Uret(i);
        }
        System.out.println("---------------------");

    }
}

class Uret {
    int i = 0;

    // Kurucu fonksiyon
    Uret(int i) {
        this.i = i;
        System.out.println((i + 1) + ". Object oluşturuldu");
    }

    // Yıkıcı fonksiyon
    public void finalize() {
        System.out.println((i + 1) + ". Object silindi");
    }
}
