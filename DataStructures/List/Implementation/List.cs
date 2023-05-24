using System.Collections;

namespace DataStructures.List.Implementation;

public partial class List<T> : IEnumerable<T>
{
    public List()
    {
        Clear();
    }

    public List(params T[] array)
    {
        _array = array;
        Count = array.Length;
        Capacity = array.Length;
    }
    public IEnumerator<T> GetEnumerator()
    {
        return new ListEnumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    private void IncreaseCapacity(int newSize)
    {
        Capacity = newSize;
        var buffer = new T[Capacity];
        
        for (var i = 0; i < Count; i++)
        {
            buffer[i] = _array[i];
        }

        _array = buffer;
    }
    
    private class ListEnumerator : IEnumerator<T>
    {
        private List<T> _list;
        private int _position = -1;

        internal ListEnumerator(List<T> list)
        {
            _list = list;
        }

        public bool MoveNext()
        {
            return ++_position < _list.Count;
        }

        public void Reset()
        {
            _position = -1;
        }

        public T Current => _list[_position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _list.Clear();
        }
    }
}