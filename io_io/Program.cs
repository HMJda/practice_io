using System;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream(@"C:\Temp\vs.png", FileMode.Open))
            {
                int size = (int)fs.Length;
                byte[] buff = new byte[size];
                // 이미지를 10번에 걸쳐 나누어 읽음
                for (int i = 0; i < 10; i++)
                {
                    int n = fs.Read(buff, 0, size / 10);
                    //....
                    Console.WriteLine(n);
                }
            }
        }
    }
}
