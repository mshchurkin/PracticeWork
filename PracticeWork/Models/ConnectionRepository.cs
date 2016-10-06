using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeWork.Models
{
    public class ConnectionRepository
    {
        private PracticeWorkDataModelContainer cont;

        public ConnectionRepository(PracticeWorkDataModelContainer _cont)
        {
            cont = _cont;
        }

        public IEnumerable<Connection> Connections(int _idr)
        {
            return cont.ConnectionSet.Where(c => PracticeWork.ModelIDKeeper.Keeper == c.ModelId).Where(c=>_idr==c.RouterId);
        }

        public IEnumerable<Connection>ConnectionSelector()
        {
            return cont.ConnectionSet.Where(c => PracticeWork.ModelIDKeeper.Keeper == c.ModelId);
        }
        public Connection GetConnection(int _id)
        {
            return cont.ConnectionSet.Find(_id);
        }

        public void Add(string _name, string _description, string _D1, string _D2, int _ModelId, int _RouterId)
        {
            Connection c = new Connection();
            c.Name = _name;
            c.Description = _description;
            c.ModelId = _ModelId;
            c.RouterId=_RouterId;
            c.D1 = _D1;
            c.D2 = _D2;
            cont.ConnectionSet.Add(c);
            cont.SaveChanges();
        }

        public void Edit(int _id, string _name, string _description, string _D1, string _D2)
        {
            Connection c = cont.ConnectionSet.Find(_id);
            c.Name = _name;
            c.Description=_description;
            c.D1 = _D1;
            c.D2 = _D2;
            cont.SaveChanges();
        }

        public void Delete(int _id)
        {
            Connection c = cont.ConnectionSet.Find(_id);
            cont.ConnectionSet.Remove(c);
            cont.SaveChanges();
        }
    }
}