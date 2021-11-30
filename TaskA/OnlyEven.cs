using System;
using System.Collections;
using System.Collections.Generic;

public class OnlyEven : IEnumerable<int>
{
    private List<int> numbers = new List<int>();

    public IEnumerator<int> GetEnumerator()
    {
        return numbers.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return numbers.GetEnumerator();
    }

    public OnlyEven(List<int> numbers)
    {
        foreach (var item in numbers)
        {
            if (item % 2 == 0)
            {
                this.numbers.Add(item);
            }
        }
    }

}