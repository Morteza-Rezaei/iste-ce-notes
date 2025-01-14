import java.util.Scanner;

public class Uyg3Kosinus {
    /*
     * Bir üçgen için verilen iki kenar uzunluğu ve aralarındaki
     * açıdeğeri için kosinüs teoremini kullanarak 3.uzunluğu belirleyen prg.
     */

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Kullanıcıdan girişleri al
        System.out.print("Birinci kenar uzunluğunu girin (a): ");
        double a = scanner.nextDouble();

        System.out.print("İkinci kenar uzunluğunu girin (b): ");
        double b = scanner.nextDouble();

        System.out.print("İki kenar arasındaki açıyı girin (derece): ");
        double aci = scanner.nextDouble();

        // Açı değerini derece yerine radyan olarak hesaplamak için çevir
        double aciRadyan = Math.toRadians(aci);

        // Kosinüs teoremini uygula
        double cKare = Math.pow(a, 2) + Math.pow(b, 2) - 2 * a * b * Math.cos(aciRadyan);
        double c = Math.sqrt(cKare);

        // Sonucu ekrana yazdır
        System.out.printf("Üçüncü kenarın uzunluğu: %.2f birim", c);

        scanner.close();
    }
}
