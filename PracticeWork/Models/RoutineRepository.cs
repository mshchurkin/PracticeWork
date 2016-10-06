using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeWork.Models
{
    public class RoutineRepository
        {
         private PracticeWorkDataModelContainer cont;

        public RoutineRepository(PracticeWorkDataModelContainer _cont)
        {
            cont = _cont;
        }

        public IEnumerable<Routine> Routines(int _idq)
        {
            return cont.RoutineSet.Where(c => PracticeWork.ModelIDKeeper.Keeper == c.ModelId).Where(c=>_idq==c.QueueId);
        }
        public IEnumerable<Routine> RoutineSelector()
        {
            return cont.RoutineSet.Where(c => PracticeWork.ModelIDKeeper.Keeper == c.ModelId);
        }
        public Routine GetRoutine(int _id)
        {
            return cont.RoutineSet.Find(_id);
        }

        public void Add(string _name, string _function, int _ModelId, int QueueId)
        {
            Routine r = new Routine();
            r.Name = _name;
            r.Function = _function;
            r.ModelId = _ModelId;
            r.QueueId=QueueId;
            r.Queue = cont.QueueSet.Find(QueueId);
            r.Queue.NumberInQueue++;
            cont.RoutineSet.Add(r);
            cont.SaveChanges();
        }

        public void Edit(int _id, string _name, string _function)
        {
            Routine r = cont.RoutineSet.Find(_id);
            r.Name = _name;
            r.Function=_function;
            cont.SaveChanges();
        }

        public void Delete(int _id)
        {
            Routine r = cont.RoutineSet.Find(_id);
            r.Queue.NumberInQueue--;
            cont.RoutineSet.Remove(r);
            cont.SaveChanges();
        }
    }
}