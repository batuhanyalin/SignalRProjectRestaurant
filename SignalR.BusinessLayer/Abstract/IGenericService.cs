namespace SignalRProjectRestaurant.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TCreate(T entity);
        void TUpdate(T entity);  
        void TDelete(T entity);
        T TGetById(int id);
        List<T> TGetAll(); 
    }
}
