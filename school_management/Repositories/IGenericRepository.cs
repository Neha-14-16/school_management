namespace school_management.Repositories
{
    public interface IGenericRepository<T>
    {
        void GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}