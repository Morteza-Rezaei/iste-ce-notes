// Stringler

string s1 = "Hello";
string s2 = "World";
s1 += s2; // bu işlem s1'in değerini değiştirmez, yeni bir string oluşturur ve s1'e atar
Console.WriteLine(s1); // HelloWorld

string str1 = "Hello";
string str2 = str1;
str1 += " World";
Console.WriteLine(str2); // Hello

// \t: tab kadar boşluk bırakır
// \n: alt satıra geçer
// \r: satır başına döner

string str = "Hello\tWorld\rHello\r\nworld";
Console.WriteLine(str); // Hello   World
                        // Hello
                        // world

// @ ile ne yazarsak yazalım, stringin içeriğini olduğu gibi alır
string str3 = @"Hello\tWorld\rHello\r\nworld";
Console.WriteLine(str3); // Hello\tWorld\rHello\r\nworld

// ham string literaller
string str4 = """
Hello "Merhaba dünya" World
""";
Console.WriteLine(str4); // "Hello "hello" World"




