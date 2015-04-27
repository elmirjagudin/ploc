using System;
using System.IO;

namespace ploc
{
    class Program
    {
        static void process_files(string dir_path)
        {
            Console.WriteLine("process files in {0}", dir_path);

            foreach(string dir in Directory.EnumerateDirectories(dir_path))
            {
                process_files(dir);
            }

            foreach(string file in Directory.EnumerateFiles(dir_path))
            {
                Console.WriteLine("file: {0}", file);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to ploc!");
            process_files(Directory.GetCurrentDirectory());
        }
    }
}
