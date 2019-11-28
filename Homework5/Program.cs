using System;
using System.IO;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] files = Directory.GetFiles(@"C:\Users\Useress\source", "*.txt", SearchOption.AllDirectories);
            for (int i = 0; i < files.Length; i++)
            {
                //string str = Path.GetFileName(files[i]);
                FileStream fs = new FileStream("text.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                DateTime date = File.GetLastWriteTime(files[i]);
                sw.WriteLine(files[i] + " was created " + date);
                sw.Close();
            }
        }
    }
}