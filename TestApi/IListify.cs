using System;
using System.Collections;

namespace TestAPI
{
  public class Ilistify<T> : IList<T>
  {
    private readonly IList<T> _list = new List<T>();

    public object? this[int index] { get { return _list[index]; }
      set
      {
        this[index] = value;
      }
    }
    T IList<T>.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public bool IsFixedSize => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    public int Count => throw new NotImplementedException();

    public bool IsSynchronized => throw new NotImplementedException();

    public object SyncRoot => throw new NotImplementedException();

    public int Add(object? value)
    {
      throw new NotImplementedException();
    }
    public void Add(T item)
    {
      _list.Add(item);
    }
    

    public void Clear()
    {
      throw new NotImplementedException();
    }

    public bool Contains(object? value)
    {
      throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
      throw new NotImplementedException();
    }

    public void CopyTo(Array array, int index)
    {
      throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
      throw new NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
      throw new NotImplementedException();
    }

    public int IndexOf(object? value)
    {
      throw new NotImplementedException();
    }

    public int IndexOf(T item)
    {
      throw new NotImplementedException();
    }

    public void Insert(int index, object? value)
    {
      throw new NotImplementedException();
    }

    public void Insert(int index, T item)
    {
      throw new NotImplementedException();
    }

    public void Remove(object? value)
    {
      throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
      throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
      throw new NotImplementedException();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
      throw new NotImplementedException();
    }

  }
}
