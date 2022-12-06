using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;

internal class Program
{
    static void FindWord(ref string v, ref string temp)
    {
        string b = "";
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] == ' ')
            {
                v = v.Remove(i, 1);
                break;
            }
            else
            {
                b += v[i];
                v = v.Remove(i, 1);
                i--;
            }
        }
        temp = b;
    }
    class Svetofor
    {
        public void Svet(int n, string all)
        {
            List<string> strings = new List<string>();
            while(true)
            {
                if(all==""||all==" ")
                {
                    break;
                }
                string temp = "";
                FindWord(ref all, ref temp);
                strings.Add(temp);
            }

            for(int i = 0; i != n; i++)
            {

                foreach (string s in strings)
                {
                    Console.Write(s + " ");

                }
                Console.WriteLine();


                string temp = strings[strings.Count-1];


                for (int y = strings.Count - 1; y != 0; y--)
                {
                    strings[y] = strings[y - 1];
                }
                strings[0] = temp;

            }
        }
    }
    static void Main()
    {
        Svetofor a = new Svetofor();
        a.Svet(4, "Green Yellow Red");
    }


}
