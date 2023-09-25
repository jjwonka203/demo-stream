// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string filepath_src = "D:/demo stream/docs/doc.txt";
string filepath_des = "D:/demo stream/docs/doc r ghi.txt";

int SIZEBUFFER = 5;
using (var streamwrite = File.OpenWrite(filepath_des))
using (var streamread = File.OpenRead(filepath_src)) {
    byte[] buffer = new byte[SIZEBUFFER];
    bool endread = false;
    do {
        int numberRead = streamread.Read(buffer, 0, SIZEBUFFER);
        if (numberRead == 0) endread = true;
        else {
            streamwrite.Write(buffer, 0, numberRead);
        }
    }while (!endread);
}