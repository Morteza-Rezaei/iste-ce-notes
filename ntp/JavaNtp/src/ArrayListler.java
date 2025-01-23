import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;

public class ArrayListler {
    public static void main(String[] args) {
        // Generic type: <String>
        int n = 5;
        ArrayList<String> listem = new ArrayList<>();
        ArrayList<String> listem2 = new ArrayList<String>(5);

        ArrayList<Integer> listem3 = new ArrayList<Integer>();

        for (int i = 0; i < 10; i++) {
            // add sona ekleme işlemi yapar
            listem2.add(i + ". eleman");
            // Liste boyutu önceden verilmiş olsa dahi yeni gelecek eklemeler için
            // dinamik olarak yer açar
        }
        System.out.println(listem2);

        // 2. indise değer ekleme
        // silme yapmaz kaydırır
        listem2.add(2, "araya ekleme");
        System.out.println(listem2);
        // sona ekleme
        listem2.add("araya ekleme");
        System.out.println(listem2);

        System.out.println(listem2.indexOf("araya ekleme"));
        // "araya ekleme" değerinin ilk hangi indis oluduğunu getirir
        System.out.println(listem2.lastIndexOf("araya ekleme"));
        // "araya ekleme" değerinin en son hangi indis oluduğunu getirir
        System.out.println(listem2.contains("araya ekleme"));
        // "araya ekleme" değerinin olup olmadığını dönderir

        listem2.remove("araya ekleme");
        // "araya ekleme" ilk karşılaştığını siler
        System.out.println(listem2);

        listem2.remove(10);
        // 10'uncu indisi siler
        System.out.println(listem2);

        for (String deger : listem2) {
            System.out.println(deger);
            // teker teker yazdır for each ile
        }

        System.out.println(listem2.size());
        // listenin boyutunu öğrenmek için

        System.out.println(listem2.get(2));
        // belirli bir indisteki değeri getirme

        listem2.set(2, "2. eleman güncellenmiş");
        // belirli bir indisteki değeri güncelleme
        System.out.println(listem2);

        // listem2.clear();
        // tüm elemanları siler
        System.out.println(listem2);

        System.out.println(listem2.isEmpty());
        // listede değer var mı diye bakıyor

        // Sıralamalar
        Collections.sort(listem2);
        // A-->Z
        System.out.println(listem2);

        Collections.sort(listem2, Collections.reverseOrder());
        // Z-->A
        System.out.println(listem2);

    }
}
