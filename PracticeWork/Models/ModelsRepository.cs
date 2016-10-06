using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeWork.Models
{
    public class ModelsRepository
    {
        private PracticeWorkDataModelContainer cont;

        public ModelsRepository (PracticeWorkDataModelContainer _cont )
        {
            cont = _cont;
        }

        public IEnumerable<Model>Models()
        {
            return cont.ModelSet.OrderBy(c => c.Id);
        }
        public Model GetModel(int _id)
        {
            return cont.ModelSet.Find(_id);
        }
        
        public void Add(string _name, string _description)
        {
            Model m = new Model();
            m.Name = _name;
            m.Description = _description;
            cont.ModelSet.Add(m);
            cont.SaveChanges();
        }
        
        public void Edit(int _id, string _name, string _description)
        {
            Model m = cont.ModelSet.Find(_id);
            m.Name = _name;
            m.Description = _description;
            cont.SaveChanges();
        }

        public void Delete(int _id)
        {
            Model t = cont.ModelSet.Find(_id);
            var serv = from se in cont.ServerSet
                       where se.ModelId == t.Id
                       select se;
            foreach (var se1 in serv)
            {
                cont.ServerSet.Remove(se1);
            }
            var comp = from co in cont.ComputerSet
                       where co.ModelId == t.Id
                       select co;
            foreach (var co1 in comp)
            {
                cont.ComputerSet.Remove(co1);
            }
            var qu = from co in cont.QueueSet
                     where co.ModelId == t.Id
                     select co;
            foreach (var co1 in qu)
            {
                cont.QueueSet.Remove(co1);
            }
            var d = from co in cont.DeviceSet
                    where co.ModelId == t.Id
                    select co;
            foreach (var co1 in d)
            {
                cont.DeviceSet.Remove(co1);
            }
            var c = from co in cont.ConnectionSet
                    where co.ModelId == t.Id
                    select co;
            foreach (var co1 in c)
            {
                cont.ConnectionSet.Remove(co1);
            }
            var r = from co in cont.RouterSet
                    where co.ModelId == t.Id
                    select co;
            foreach (var co1 in r)
            {
                cont.RouterSet.Remove(co1);
            }
            var ru = from co in cont.RoutineSet
                     where co.ModelId == t.Id
                     select co;
            foreach (var co1 in ru)
            {
                cont.RoutineSet.Remove(co1);
            }
            cont.ModelSet.Remove(t);
            cont.SaveChanges();
        }
    }
}