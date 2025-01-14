public class Overloading {
    public static void main(String[] args) {
        Overloading s = new Overloading();
        System.out.println(s.topla(2, 3));
        System.out.println(s.topla(2, 3, 4));
        System.out.println(s.topla(2.0, 3.0));

    }

    public int topla(int x, int y) {
        return (x + y);
    }

    public int topla(int x, int y, int z) {
        return (x + y + z);
    }

    public double topla(double x, double y) {
        return (x + y);
    }

}
