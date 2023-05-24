namespace DataStructures.List;

public interface IListExtended<T> : IList<T>
{
    void AddRange(params T[] items);
    void AddRange(List<T> items);

    bool Contains(T item);
    void Clear();
    void Remove(T item);
    void InsertAt(int index, T item);
}