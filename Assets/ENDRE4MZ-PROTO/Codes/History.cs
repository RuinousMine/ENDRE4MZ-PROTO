using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class History<T> : IEnumerable<T>, ICloneable
{
    private List<T> list = new List<T>();

    public int Count => list.Count;
    public int Index { get; set; }
    public T CurrentValue => list[Index];
    public bool EnableUndo => Index > 0;
    public bool EnableRedo => Index < list.Count - 1;

    public T this[int index]
    {
        get
        {
            return list[index];
        }
    }

    public History(T firstValue)
    {
        list.Add(firstValue);
        Index++;
    }

    public History() { }

    public void Push(T value)
    {
        if (Index < list.Count - 1)
        {
            list.RemoveRange(Index + 1, list.Count - 1 - Index);
        }
        list.Add(value);
        Index = list.Count - 1;
    }

    public T Back()
    {
        if (Index > 0)
        {
            Index--;
            return list[Index];
        }
        return default;
    }

    public T At(int index)
    {
        if (index < 0 || index >= list.Count)
        {
            return default;
        }
        this.Index = index;
        return list[index];
    }

    public T Forward()
    {
        if (Index < list.Count - 1)
        {
            Index++;
            return list[Index];
        }
        return default;
    }

    public T Peek()
    {
        if (Index > 0)
        {
            return list[Index - 1];
        }
        return default;
    }

    public void Clear()
    {
        list.Clear();
        Index = -1;
    }

    public IEnumerator GetEnumerator()
    {
        return list.GetEnumerator();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return list.GetEnumerator();
    }

    public object Clone()
    {
        var history = new History<T>();
        history.Index = Index;
        history.list = list.ToList();
        return history;
    }
}
