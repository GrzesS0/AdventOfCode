using System;
using System.IO;
namespace Z_2
{
    class Program
    {
        static int Z2a(){
            int x=0, y=0;
            StreamReader sr = new StreamReader("plik.txt");
            while (!sr.EndOfStream)
            {
                String a = sr.ReadLine();
                switch (a[0])
                {
                    case 'f':x+=(Convert.ToInt32(a[a.Length-1]) - Convert.ToInt32('0'));
                        break;
                    case 'd': y += (Convert.ToInt32(a[a.Length - 1]) - Convert.ToInt32('0')); break;
                    case 'u': y -= (Convert.ToInt32(a[a.Length - 1]) - Convert.ToInt32('0')); break;
                    default: Console.WriteLine("błąd"); break;
                }
            }
            Console.WriteLine($"x {x} y {y}");
            sr.Close();
            return x * y;
}
        static int Z2b()
        {
            int x = 0, y = 0,z=0;
            StreamReader sr = new StreamReader("plik.txt");
            while (!sr.EndOfStream)
            {
                String a = sr.ReadLine();
                switch (a[0])
                {
                    case 'f':
                        x += (Convert.ToInt32(a[a.Length - 1]) - Convert.ToInt32('0'));
                        z += y * (Convert.ToInt32(a[a.Length - 1]) - Convert.ToInt32('0'));
                        break;
                    case 'd': y += (Convert.ToInt32(a[a.Length - 1]) - Convert.ToInt32('0')); break;
                    case 'u': y -= (Convert.ToInt32(a[a.Length - 1]) - Convert.ToInt32('0')); break;
                    default: Console.WriteLine("błąd"); break;
                }
            }
            Console.WriteLine($"x {x} y {y} z {z}");
            sr.Close();
            return x * z;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Z2a());
            Console.WriteLine(Z2b());
        }
    }
}
