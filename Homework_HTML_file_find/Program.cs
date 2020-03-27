using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Homework_HTML_file_find
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написати програму, яка шукає в вказаному каталозі HTML-файли та виводить їх список на екран в нумерованому вигляді. 
             Після цього програма пропонує на вибір одну з наступних дій:
                    Видалення обраного файла
                    Переіменування обраного файла
	                Редагування  обраного файла */

            string path = "D:\\Folder";
            
            var allFilenames = Directory.EnumerateFiles(path).Select(p => Path.GetFileName(p));
            Console.WriteLine("ALL FILES ON DISK D =>>>>");
            Console.WriteLine("======================================");
            foreach (var item in allFilenames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================");
           
            // Get all filenames that have a .txt extension, excluding the extension
            var candidates = allFilenames.Where(fn => Path.GetExtension(fn) == ".html")
                                         .Select(fn => Path.GetFileNameWithoutExtension(fn));

            Console.WriteLine(".HTML FILES ON DISK D =>>>>");
            foreach (var item in candidates)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================");

            Console.WriteLine("DELETE FILE WITH NAME \"One_txt.txt\"");
            string path1 = @"D:\Folder\One_txt.txt";
            FileInfo file = new FileInfo(path1);
            if (file.Exists)
            {
                file.Delete();
                Console.WriteLine($"{file.Name} deleted");
            }
            else
            {
                Console.WriteLine($"{file.Name} does not exists.");
            }

            Console.WriteLine("RENAME ALL FILE IN FOLDER");
            string path_ = @"D:\Folder\Two_txt.txt";
            string path2 = @"D:\Folder\MyTest.txt";
            try
            {
                if (!File.Exists(path_))
                {
                    // This statement ensures that the file is created,
                    // but the handle is not kept.
                    using (FileStream fs = File.Create(path_)) { }
                }

                // Ensure that the target does not exist.
                if (File.Exists(path2))
                    File.Delete(path2);

                // Move the file.
                File.Move(path_, path2);
                Console.WriteLine("{0} was moved to {1}.", path_, path2);

                // See if the original exists now.
                if (File.Exists(path_))
                {
                    Console.WriteLine("The original file still exists, which is unexpected.");
                }
                else
                {
                    Console.WriteLine("The original file no longer exists, which is expected.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

            Console.WriteLine("REMOVE TEXT IN FILE");
            string path3 = @"D:\Folder\MyTest.txt";

            Console.WriteLine("Enter text ...");
            object message = Console.ReadLine();
            try
            {
                using (StreamWriter sw = new StreamWriter(path3, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(message);
                    Console.WriteLine("Done!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
