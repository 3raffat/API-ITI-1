namespace API_ITI_1.Models.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(int Id, T entity);
        void Delete(int Id, T entity);
        List<T> View();
        T FindById(int Id);
        T FindByName(string Name);

    }
}
