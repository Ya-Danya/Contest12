using System;
using System.IO;
using static System.Math;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string[] strings = File.ReadAllLines("input.txt");
        List<int> tshirts = new List<int>();
        foreach (var item in strings[0].Split(" "))
        {
            tshirts.Add(int.Parse(item));
        }
        List<int> trousers = new List<int>();
        foreach (var item in strings[1].Split(" "))
        {
            trousers.Add(int.Parse(item));
        }
        int max1 = -1;
        int max2 = -1;
        int mindelta = int.MaxValue;
        int u = 0;
        if (tshirts[0] > trousers[0])
        {
            u = tshirts[0];
        }
        else
        {
            u = trousers[0];
        }
        
        for (int a = u; a < tshirts.Count; a++)
        {
            for (int j = 0; j < trousers.Count; j++)
            {
                if (Abs(tshirts[a] - trousers[j]) < mindelta)
                {
                    mindelta = Abs(tshirts[a] - trousers[j]);
                    max1 = tshirts[a];
                    max2 = trousers[j];
                }
            }
        }
        

        File.WriteAllText("output.txt", max1.ToString() + " " + max2.ToString());
    }
}