using System;
using System.IO;
namespace Z_4
{
    class Program
    {
        static int Z4a() {
            int a = 0, b = 0, index = 0,index2=0,index3 = 0;
            String x,y="";
            StreamReader sr = new StreamReader("plik.txt");
            x=sr.ReadLine();
            int[] c = new int[x.Length / 2];
            int[][][] d = new int[100][][];
            for (int i = 0; i < 100; i++) {
                d[i] = new int[5][];
                for (int j = 0; j < 5; j++) {
                    d[i][j] = new int[5];
                } 
            }
            for (int i = 0; i < x.Length; i++) {
                if (x[i] != ',') y += x[i];
                else
                {
                    c[index] = Convert.ToInt32(y);
                    y = "";
                    index++;
                }
            }
            c[index] = Convert.ToInt32(y);
            index = 0;
            while (!sr.EndOfStream) {
                x = sr.ReadLine();
                if (x == "") continue;
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] != ' ') y += x[i];
                        else
                        if(y!=""){
                            d[index][index2%5][index3] = Convert.ToInt32(y);
                            y = "";
                            index3++;
                        }
                    
                }
                d[index][index2%5][index3] = Convert.ToInt32(y);
                index3 = 0;
                y = "";
                index2++;
                index2 = index2 % 5;
                if(index2%5==0)index++;
            }
            sr.Close();
            for(int i = 0; i < c.Length; i++)
            {
                a = c[i];
                for(int j = 0; j < 100; j++)
                {
                    for(int k = 0; k < 5; k++)
                    {
                        for(int l = 0; l < 5; l++)
                        {
                            if (d[j][k][l] == a) d[j][k][l] = -1;
                        }
                    }
                }
                for (int j = 0; j < 100; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (d[j][k][0] + d[j][k][1] + d[j][k][2] + d[j][k][3] + d[j][k][4] == -5) { for (int m = 0; m < 5; m++) for (int n = 0; n < 5; n++) { if (d[j][m][n] != -1) b += d[j][m][n]; } return a * b; }
                        if (d[j][0][k] + d[j][1][k] + d[j][2][k] + d[j][3][k] + d[j][4][k] == -5) { for (int m = 0; m < 5; m++) for (int n = 0; n < 5; n++) { if (d[j][m][n] != -1) b += d[j][m][n]; } return a * b; }
                    }
                }
            }
            return a * b;
        }
        static int Z4b()
        {
            int a = 0, b = 0, index = 0, index2 = 0, index3 = 0,z=-1;
            String x, y = "";
            StreamReader sr = new StreamReader("plik.txt");
            x = sr.ReadLine();
            int[] c = new int[x.Length / 2];
            int[][][] d = new int[100][][];
            for (int i = 0; i < 100; i++)
            {
                d[i] = new int[5][];
                for (int j = 0; j < 5; j++)
                {
                    d[i][j] = new int[5];
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != ',') y += x[i];
                else
                {
                    c[index] = Convert.ToInt32(y);
                    y = "";
                    index++;
                }
            }
            c[index] = Convert.ToInt32(y);
            index = 0;
            while (!sr.EndOfStream)
            {
                x = sr.ReadLine();
                if (x == "") continue;
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] != ' ') y += x[i];
                    else
                    if (y != "")
                    {
                        d[index][index2 % 5][index3] = Convert.ToInt32(y);
                        y = "";
                        index3++;
                    }

                }
                d[index][index2 % 5][index3] = Convert.ToInt32(y);
                index3 = 0;
                y = "";
                index2++;
                index2 = index2 % 5;
                if (index2 % 5 == 0) index++;
            }
            sr.Close();
            for (int i = 0; i < c.Length; i++)
            {
                a = c[i];
                for (int j = 0; j < 100; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        for (int l = 0; l < 5; l++)
                        {
                            if (d[j][k][l] == a) d[j][k][l] = -1;
                        }
                    }
                }
                int ile = 0;
                for (int j = 0; j < 100; j++)
                {
                    bool e = true;
                    for (int k = 0; k < 5; k++)
                    {
                        if ((d[j][k][0] + d[j][k][1] + d[j][k][2] + d[j][k][3] + d[j][k][4] == -5) || (d[j][0][k] + d[j][1][k] + d[j][2][k] + d[j][3][k] + d[j][4][k] == -5)) { ile++; e = false; break; }
                    }
                    if(e)z = j;
                    e = true;
                }
                if (ile == 100) {
                    for (int m = 0; m < 5; m++) for (int n = 0; n < 5; n++) { if (d[z][m][n] != -1) b += d[z][m][n]; }
                    int j = z;
                    return a * b;
                }
            }
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Z4a     " + Z4a());
            Console.WriteLine("Z4b     " + Z4b());
        }
    }
}
