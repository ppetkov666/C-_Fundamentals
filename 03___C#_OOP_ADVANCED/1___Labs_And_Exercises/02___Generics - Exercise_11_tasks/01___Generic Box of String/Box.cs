using System;
public class Box<T>
{
    public T value;

    public Box(T value)
    {
        this.value = value;
    }
    public override string ToString()
    {
        return $"{this.value.GetType().FullName}: {this.value}";
    }
}



