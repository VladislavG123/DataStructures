namespace DataStructures.List;

public interface IList<T>
{
    public int Count { get; } 
    public int Capacity { get; } 
    public T this[int key] { get; set; }
    
    void Add(T item);
    T ElementAt(int index);
    void SetValue(int index, T value);

    T[] ToArray();
}