import java.util.Arrays;

public class Diziler {
    public static void main(String[] args) {
        // dizi tanımlama şekilleri
        int[] dizi = new int[5];
        int[] dizi2 = { 1, 2, 3, 4, 5 };
        int[] dizi3 = new int[] { 1, 2, 3, 4, 5 };

        // dizi elemanlarına erişim
        System.out.println(dizi2[0]); // 1
        System.out.println(dizi2[4]); // 5

        // dizi elemanlarına erişim ve değiştirme
        dizi2[0] = 10;
        System.out.println(dizi2[0]); // 10

        // dizinin boyutu
        System.out.println(dizi2.length); // 5

        // dizi elemanlarını döngü ile yazdırma
        for (int i = 0; i < dizi2.length; i++) {
            System.out.print(dizi2[i] + " ");
        }

        // dizi elemanlarını döngü ile toplama
        int toplam = 0;
        for (int i = 0; i < dizi2.length; i++) {
            toplam += dizi2[i];
        }
        System.out.println(toplam);

        // Arrays

        // 2 ve 3 boyutlu diziler
        // satır , sütün
        int[][] dizi4 = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[][][] dizi5 = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
        System.out.println("----------------------");
        // yazdırma işlemi
        for (int i = 0; i < dizi4.length; i++) {
            for (int j = 0; j < dizi4[i].length; j++) {
                System.out.print(dizi4[i][j] + " ");
            }
            System.out.println();
        }
        System.out.println("----------------------");
        for (int i = 0; i < dizi5.length; i++) {
            for (int j = 0; j < dizi5[i].length; j++) {
                for (int k = 0; k < dizi5[i][j].length; k++) {
                    System.out.print(dizi5[i][j][k] + " ");
                }
                System.out.println();
            }
        }
        System.out.println("----------------------");

        // Arrays sınıfı
        int[] dizi6 = { 1, 2, 3, 4, 5 };
        Arrays.sort(dizi6);
        System.out.println(Arrays.toString(dizi6)); // [1, 2, 3, 4, 5]

        // Arrays sınıfı ile dizi kopyalama
        int[] dizi7 = Arrays.copyOf(dizi6, 3);
        System.out.println(Arrays.toString(dizi7)); // [1, 2, 3]

        // Arrays sınıfı ile dizi karşılaştırma
        int[] dizi8 = { 1, 2, 3, 4, 5 };
        System.out.println(Arrays.equals(dizi6, dizi8)); // true

        // Arrays sınıfı ile dizi doldurma
        int[] dizi9 = new int[5];
        Arrays.fill(dizi9, 5);
        System.out.println(Arrays.toString(dizi9)); // [5, 5, 5, 5, 5]

        // Arrays sınıfı ile dizi sıralama
        int[] dizi10 = { 5, 3, 1, 4, 2 };
        Arrays.sort(dizi10);
        System.out.println(Arrays.toString(dizi10)); // [1, 2, 3, 4, 5]

    }
}
