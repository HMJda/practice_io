using System;
using System.IO;
class ReadText
{
    static void Main()
    {
        FileStream fs;
        try
        {
            fs = new FileStream("Alpha.txt", FileMode.Open);
        }
        catch (IOException)
        {
            Console.WriteLine("파일을 열 수 없습니다.");
            return;
        }
        StreamReader r = new StreamReader(fs);
        string s;
        int i = 1;
        while ((s = r.ReadLine()) != null)
        {
            Console.WriteLine(i + ":" + s);
            i++;
        }
        r.Close();
    }
}