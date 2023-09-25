// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Text;

string filepath = "D:/demo stream/docs/doc.txt";

int SIZEBUFFER = 256;
using (var stream = new FileStream (filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.Read)) {
    Encoding encoding = Encoding.UTF8;
    Console.WriteLine(encoding.ToString());
    byte[] buffer = new byte[SIZEBUFFER];
    bool endread = false; 
    do { 
        int numberRead = stream.Read(buffer, 0, SIZEBUFFER);
        if (numberRead == 0) endread = true;
        if (numberRead < SIZEBUFFER) {
            Array.Clear(buffer, numberRead, SIZEBUFFER - numberRead);
        }

        string s = encoding.GetString(buffer, 0, numberRead);
        Console.WriteLine(s);
    }while (!endread);
}