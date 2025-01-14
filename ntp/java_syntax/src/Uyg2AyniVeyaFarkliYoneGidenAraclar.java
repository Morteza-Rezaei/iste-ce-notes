import java.util.Scanner;

public class Uyg2AyniVeyaFarkliYoneGidenAraclar {
    /*
     * İki aracın aynı ya da farklı yöne gittiği durumda t süre sonra
     * aralarındaki mesafeyi hesaplayan program.
     */

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Birinci aracın hızı (km/h): ");
        double v1 = scanner.nextDouble();

        System.out.print("İkinci aracın hızı (km/h): ");
        double v2 = scanner.nextDouble();

        System.out.print("Geçen süre (saat): ");
        double t = scanner.nextDouble();

        System.out.print("Araçlar aynı yöne mi gidiyor? (evet/hayır): ");
        String yon = scanner.next();

        double mesafe;
        if (yon.equalsIgnoreCase("evet")) {
            mesafe = Math.abs((v1 - v2) * t);
        } else {
            mesafe = Math.abs((v1 + v2) * t);
        }

        System.out.printf("Araçlar arasındaki mesafe: %.2f km", mesafe);

        scanner.close();
    }
}
