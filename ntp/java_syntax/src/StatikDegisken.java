public class StatikDegisken {
    public static int x = 0;
    public int y = 0;

    public static void main(String[] args) {
        StatikDegisken sd1 = new StatikDegisken();
        StatikDegisken sd2 = new StatikDegisken();

        x = 10;
        sd1.y = 55;
        System.out.println(" x değeri:" + x);
        System.out.println("sd1 y değeri:" + sd1.y);
        System.out.println("sd2 y değeri:" + sd2.y);
        System.out.println("sd1 x değeri:" + sd1.x);
        System.out.println("sd2 x değeri:" + sd2.x);

        System.out.println("----------------");

        sd1.x = 33;
        System.out.println(" x değeri:" + x);
        System.out.println("sd1 y değeri:" + sd1.y);
        System.out.println("sd2 y değeri:" + sd2.y);
        System.out.println("sd1 x değeri:" + sd1.x);
        System.out.println("sd2 x değeri:" + sd2.x);

        System.out.println("----------------");

        StatikDegisken sd3 = new StatikDegisken();
        System.out.println(" x değeri:" + x);
        System.out.println("sd1 x değeri:" + sd1.x);
        System.out.println("sd2 x değeri:" + sd2.x);
        System.out.println("sd3 x değeri:" + sd3.x);

        System.out.println("----------------\n----------------");
        StatikFonksiyon nesne1 = new StatikFonksiyon();
        StatikFonksiyon nesne2 = new StatikFonksiyon();

        nesne1.StatikFonk(5);
        System.out.println("Nesne 1 ad: " + nesne1.ad);
        System.out.println("Nesne 2 ad: " + nesne2.ad);

        nesne1.StatikFonk(5);
        System.out.println("Nesne 1 ad: " + nesne1.ad);
        System.out.println("Nesne 2 ad: " + nesne2.ad);

        // herhangi bir nesne oluşturmadan da erişebiliriz
        StatikFonksiyon.StatikFonk(6);
        System.out.println("Nesne 1 ad: " + nesne1.ad);
        System.out.println("Nesne 2 ad: " + nesne2.ad);
    }

}
