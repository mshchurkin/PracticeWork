using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeWork.Models
{
    public class RouterRepository
    {
        private PracticeWorkDataModelContainer cont;

        public RouterRepository(PracticeWorkDataModelContainer _cont)
        {
            cont = _cont;
        }

        public IEnumerable<Router> Routers(int _id)
        {
            return cont.RouterSet.Where(c => _id == c.Model.Id);
        }
        public Router GetRouter(int _id)
        {
            return cont.RouterSet.Find(_id);
        }

        public void Add(string _name, int _ConnectionSpeed, int _ModelId)
        {
            Router r = new Router();
            r.Name = _name;
            r.ConnectionSpeed = _ConnectionSpeed;
            r.ModelId = _ModelId;
            cont.RouterSet.Add(r);
            cont.SaveChanges();
        }

        public void Edit(int _id, string _name, int _ConnectionSpeed)
        {
            Router r = cont.RouterSet.Find(_id);
            r.Name = _name;
            r.ConnectionSpeed = _ConnectionSpeed;
            cont.SaveChanges();
        }

        public void Delete(int _id)
        {
            Router r = cont.RouterSet.Find(_id);
            var c = from co in cont.ConnectionSet
                    where co.RouterId == r.Id
                    select co;
            foreach (var co1 in c)
            {
                cont.ConnectionSet.Remove(co1);
            }
            cont.RouterSet.Remove(r);
            cont.SaveChanges();
        }
    }
}