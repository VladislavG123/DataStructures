namespace DataStructures.List;

public interface IListLinq<T> : IListExtended<T>
{
    T First(Func<T, bool> predicate);
    T FirstOrDefault(Func<T, bool> predicate);

    T Single(Func<T, bool> predicate);
    T SingleOrDefault(Func<T, bool> predicate);

    IListLinq<T> Where(Func<T, bool> predicate);
    bool Any(Func<T, bool> predicate);

    IListLinq<TResult> Select<TResult>(Func<T, TResult> map);
    IListLinq<TResult> SelectMany<TResult>(Func<T, IListLinq<TResult>> map);
}