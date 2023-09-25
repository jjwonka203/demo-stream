// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Text;

string filepath = "D:/demo stream/docs/ghi.txt";

using (var stream = new FileStream (filepath, FileMode.Create, FileAccess.Write, FileShare.None)) {
    Encoding encoding = Encoding.UTF8;
    byte[] bom = encoding.GetPreamble();
    stream.Write(bom, 0, bom.Length);

    string s1 = "pham hung dung 21810310452 \n";
    string s2 = "duong van tai 21810310467";

    byte[] buffer = encoding.GetBytes(s1);
    stream.Write(buffer, 0, buffer.Length);

    buffer = encoding.GetBytes(s2);
    stream.Write(buffer, 0, buffer.Length);
}
