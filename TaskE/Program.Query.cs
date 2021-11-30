using System;
using System.Linq;
using System.Collections.Generic;

public partial class Program
{
    private static List<Cat> ChooseCats(int minTailLength, int maxTailLength, int maxAge, List<Cat> cats)
    {
        List<Cat> cotici = new List<Cat>(from p in cats where p.TailLength >= minTailLength && p.TailLength <= maxTailLength && p.Age <= maxAge && p.IsBlack select p);
        return cotici;
    }
}