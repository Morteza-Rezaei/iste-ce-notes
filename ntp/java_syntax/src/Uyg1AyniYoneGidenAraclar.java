import java.util.Scanner;

public class Uyg1AyniYoneGidenAraclar {
    /*
     * Ayni yöne giden iki araç için t süre sonra araçların arasındaki mesafeyi
     * bulduran program?
     * 
     * formül x = (v1 - v2) . t
     */

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Birinci aracın hızı (km/h): ");
        double v1 = scanner.nextDouble();

        System.out.print("İkinci aracın hızı (km/h): ");
        double v2 = scanner.nextDouble();

        System.out.print("Geçen süre (saat): ");
        double t = scanner.nextDouble();

        double mesafe = Math.abs((v1 - v2) * t);
        System.out.printf("Araçlar arasındaki mesafe: %.2f km", mesafe);

        scanner.close();
    }

}
