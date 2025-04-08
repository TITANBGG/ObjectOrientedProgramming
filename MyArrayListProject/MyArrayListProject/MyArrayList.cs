using System;

public class MyArrayList
{
    private object[] items;
    private int count;
    private int capacity;

    public MyArrayList()
    {
        capacity = 4;
        items = new object[capacity];
        count = 0;
    }

    public void Add(object item)
    {
        EnsureCapacity();
        items[count++] = item;
    }

    public void Insert(int index, object item)
    {
        if (index < 0 || index > count)
            throw new ArgumentOutOfRangeException("Geçersiz indeks.");

        EnsureCapacity();

        for (int i = count; i > index; i--)
            items[i] = items[i - 1];

        items[index] = item;
        count++;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= count)
            throw new ArgumentOutOfRangeException("Geçersiz indeks.");

        for (int i = index; i < count - 1; i++)
            items[i] = items[i + 1];

        items[count - 1] = null;
        count--;
    }

    public object Get(int index)
    {
        if (index < 0 || index >= count)
            throw new ArgumentOutOfRangeException("Geçersiz indeks.");

        return items[index];
    }

    public int Count
    {
        get { return count; }
    }

    public override string ToString()
    {
        if (count == 0)
            return string.Empty;

        string result = items[0]?.ToString();

        for (int i = 1; i < count; i++)
            result += ", " + items[i]?.ToString();

        return result;
    }

    private void EnsureCapacity()
    {
        if (count >= capacity)
        {
            capacity *= 2;
            object[] newItems = new object[capacity];
            for (int i = 0; i < count; i++)
                newItems[i] = items[i];

            items = newItems;
        }
    }
}
