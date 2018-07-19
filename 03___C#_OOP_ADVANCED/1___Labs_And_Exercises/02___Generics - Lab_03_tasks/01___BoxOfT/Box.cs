using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Box<T>
{
    private readonly List<T> items;
    public int Count => this.items.Count;
    
    public Box()
    {
        this.items = new List<T>();
    }
    public void Add(T element)
    {
        items.Add(element);
    }
    public T Remove()
    {
        var element = items.Last();
        items.RemoveAt(this.items.Count - 1);
        return element;
    }
    
}

