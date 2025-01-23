public enum Whois {
    Morteza("www.morteza.com"), ISTE("www.iste.edu.tr"), Google("www.google.com");

    public String url = "";

    // whois enum string bir parametre alacak
    Whois(String a) {
        this.url = a;
    }

    // public String Morteza(String url) {
    // this.url = url;
    // return url;
    // }

    // public String ISTE(String url) {
    // this.url = url;
    // return url;
    // }

    // public String Google(String url) {
    // this.url = url;
    // return url;
    // }

    public String urlGoster() {
        return this.url;
    }
}
