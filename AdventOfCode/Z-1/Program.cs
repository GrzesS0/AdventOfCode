using System;
using System.IO;
namespace AdventCode
{
    class Program
    {
        static int z1a()
        {
            int ile = 0,index=0;
            StreamReader sr = new StreamReader("z1a.txt"); 
            while (!sr.EndOfStream) { sr.ReadLine(); ile++; }
            int[] T = new int[ile];
            ile = 0;
            sr = new StreamReader("z1a.txt");
            while (!sr.EndOfStream) { T[index] = Convert.ToInt32(sr.ReadLine()); index++; }
            for (int i = 1; i < index; i++) {
                if (T[i - 1] < T[i]) ile++;
            }
            sr.Close();
            return ile;
        }
        static int z1b()
        {
            int ile = 0, index = 0;
            StreamReader sr = new StreamReader("z1a.txt");
            while (!sr.EndOfStream) { sr.ReadLine(); ile++; }
            int[] T = new int[ile];
            ile = 0;
            sr = new StreamReader("z1a.txt");
            while (!sr.EndOfStream) { T[index] = Convert.ToInt32(sr.ReadLine()); index++; }
            for (int i = 0; i < index-2; i++)
            {
                T[i] = T[i] + T[i + 1] + T[i + 2];
            }
            for (int i = 1; i < index-2; i++)
            {
                if (T[i - 1] < T[i]) ile++;
            }
            sr.Close();
            return ile;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Z1a "+z1a());
            Console.WriteLine("Z1b " + z1b());
        }
    }
}
