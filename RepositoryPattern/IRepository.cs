namespace DesignPatternsC.RepositoryPattern
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> getAllAsync();
        Task<T> getByIdAsync(Guid id);
        Task addAsync(T item);
    }
}
