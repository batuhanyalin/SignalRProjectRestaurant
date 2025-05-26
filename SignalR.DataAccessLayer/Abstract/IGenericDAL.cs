namespace SignalRProjectRestaurant.DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        T GetById(int id);
        List<T> GetListAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
