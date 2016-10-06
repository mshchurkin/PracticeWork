using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeWork.Models
{
    public class ServerRepository
    {
        private PracticeWorkDataModelContainer cont;

        public ServerRepository(PracticeWorkDataModelContainer _cont)
        {
            cont = _cont;
        }

        public IEnumerable<Server> Servers(int _id)
        {
            return cont.ServerSet.Where(c => _id == c.Model.Id);
        }
        public IEnumerable<Server> ServerSelector(int _r, int _m, int _cs)
        {
            return cont.ServerSet.Where(c => _r <= c.RAM).Where(c => _m <= c.Memory).Where(c => _cs <= c.ConnectionSpeed).Where(c => PracticeWork.ModelIDKeeper.Keeper == c.ModelId);
        }
        public Server GetServer(int _id)
        {
            return cont.ServerSet.Find(_id);
        }

        public void Add(string _name, int _RAM, int _Memory, int _ConnectionSpeed, int _ModelId)
        {
            Server s = new Server();
            s.Name = _name;
            s.RAM = _RAM;
            s.Memory = _Memory;
            s.ConnectionSpeed = _ConnectionSpeed;
            s.ModelId = _ModelId;
            cont.ServerSet.Add(s);
            cont.SaveChanges();
        }

        public void Edit(int _id, string _name, int _RAM, int _Memory, int _ConnectionSpeed)
        {
            Server s = cont.ServerSet.Find(_id);
            s.Name = _name;
            s.RAM = _RAM;
            s.Memory = _Memory;
            s.ConnectionSpeed = _ConnectionSpeed;
            cont.SaveChanges();
        }

        public void Delete(int _id)
        {
            Server s = cont.ServerSet.Find(_id);
            cont.ServerSet.Remove(s);
            cont.SaveChanges();
        }
    }
}