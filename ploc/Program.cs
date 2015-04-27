using System;
using System.IO;

namespace ploc
{
    class Program
    {
        static void process_py_file(string file_path)
        {
            Console.WriteLine("process {0}", file_path);
        }

        static void process_files(string dir_path)
        {
            Console.WriteLine("process files in {0}", dir_path);

            foreach(string dir in Directory.EnumerateDirectories(dir_path))
            {
                process_files(dir);
            }

            foreach(string file in Directory.EnumerateFiles(dir_path))
            {
                if (!file.EndsWith(".py"))
                {
                    Console.WriteLine("ignore file: {0}", file);
                }
                process_py_file(file);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to ploc!");
            process_files(Directory.GetCurrentDirectory());
        }
    }
}
