

using SignalR.DataAccessLayer.Context;
using SignalRProjectRestaurant.DataAccessLayer.Abstract;

namespace SignalRProjectRestaurant.API.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        private readonly ProjectContext _projectContext;
        public GenericRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public void Create(T entity)    
        {
            _projectContext.Add(entity);
            _projectContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _projectContext.Remove(entity);
            _projectContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _projectContext.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
           return _projectContext.Set<T>().ToList();
        }

        public void Update(T entity)
        {
           _projectContext.Update(entity);
            _projectContext.SaveChanges();
        }
    }
}
