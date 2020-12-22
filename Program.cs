using System;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string path = @"D:\PIG.txt";
            string path1 = @"D:\WORK\Дубовец МК\PIG.txt";
            string path2 = @"D:\WORK\Дубовец МК\FirstApp\PIG.txt";
            string path3 = @"D:\WORK\Дубовец МК\FirstApp\OPEN ME.txt";

            FileStream file = new FileStream(path, FileMode.Append);
            FileInfo fileinf = new FileInfo(path);
            if (fileinf.Exists)
            {
                Console.WriteLine("Файл существует");
                Console.WriteLine("Имя файла : {0}", fileinf.Name);
                Console.WriteLine("Полное имя файла : {0}", fileinf.DirectoryName);
            }
            else 
            {
                Console.WriteLine("Файл не существует");
            }
            Console.WriteLine("Введите текст");
            text = Console.ReadLine();
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(text);
            writer.Close();
            StreamReader reader = new StreamReader(path);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            fileinf.MoveTo(path1);
            fileinf.CopyTo(path2);
            File.Delete(path2);
            FileStream file1 = new FileStream(path3, FileMode.Create);
            Console.WriteLine("Проверь :"+path3);
            StreamWriter writer1 = new StreamWriter(file1);
            writer1.WriteLine("Файл PIG.txt не существует в текущей папке");
            writer1.Close();
            StreamReader reader1 = new StreamReader(path3);
            Console.ReadLine();
            Console.WriteLine(reader1.ReadToEnd());
            reader1.Close();
            Console.ReadKey();
    

        }
    }
}
