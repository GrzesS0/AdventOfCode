using System;
using System.IO;
namespace Z_3
{
    class Program
    {
        static int z3a()
        {
            int a = 0,b = 0;
            int[] c = new int[12];
            StreamReader sr = new StreamReader("plik.txt");
            while (!sr.EndOfStream) {
                string d = sr.ReadLine();
                for (int i = 0; i < 12; i++) if (d[i] == '1') c[i]++; else c[i]--;
            }
            for (int i = 0; i < 12; i++)
            {
                if (c[i]>0)a += (int) Math.Pow(2, 11-i);
                if (c[i] < 0) b += (int)Math.Pow(2, 11 - i);
            }
                sr.Close();
            return a * b;
        }
        
        static int z3b1(string[] t, int index, char s) {
            if (t.Length == 1)
            {
                int a = 0;
                for (int i = 0; i < 12; i++)
                {
                    if (t[0][i] == '1') a += (int)Math.Pow(2, 11 - i);
                }
                return a;
            }
            int ile = 0, Ile = 0, Index = 0;
            char z;
            for (int i = 0; i < t.Length; i++) if (t[i][index] == s) { ile++; Ile++; } else ile--;
            if(s=='1'){ 
                if (ile >= 0) z = s;
                else {z = '0'; } 
            }
            else
            {
                if (ile <= 0) z = s;
                else { z = '1'; }
            }
            if (s == '1') { if (Ile < t.Length - Ile) Ile = t.Length - Ile; }else if (Ile > t.Length - Ile) Ile = t.Length - Ile;
            string[] T = new string[Ile];
            for (int i = 0; i < t.Length; i++) if (t[i][index] == z) { T[Index] = t[i]; Index++; }
            return z3b1(T,index+1,s);
        }
        static int z3b()
        {
            int a = 0, b = 0;
            string[] c = new string[1000];
            StreamReader sr = new StreamReader("plik.txt");
            for (int i = 0; i < 1000; i++) c[i] = sr.ReadLine();
            a = z3b1(c,0,'1');
            b = z3b1(c, 0,'0');
            sr.Close();
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("z3a:    " + z3a());
            Console.WriteLine("z3b:    " + z3b());
        }
    }
}
