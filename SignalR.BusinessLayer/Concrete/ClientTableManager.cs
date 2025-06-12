using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities.Concrete;
using SignalRProjectRestaurant.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class ClientTableManager : IClientTableService
    {
        private readonly IClientTableDAL _ClientTableDAL;

        public ClientTableManager(IClientTableDAL ClientTableDAL)
        {
            _ClientTableDAL = ClientTableDAL;
        }

        public int TClientTableCount()
        {
            return _ClientTableDAL.ClientTableCount();
        }

        public void TCreate(ClientTable entity)
        {
            _ClientTableDAL.Create(entity);
        }

        public void TDelete(ClientTable entity)
        {
            _ClientTableDAL.Delete(entity);
        }

        public List<ClientTable> TGetAll()
        {
            return _ClientTableDAL.GetListAll();
        }

        public ClientTable TGetById(int id)
        {
            return _ClientTableDAL.GetById(id);
        }

        public void TUpdate(ClientTable entity)
        {
            _ClientTableDAL.Update(entity);
        }
    }
}
