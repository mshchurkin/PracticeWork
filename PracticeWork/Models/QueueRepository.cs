using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeWork.Models
{
    public class QueueRepository
    {
         private PracticeWorkDataModelContainer cont;

        public QueueRepository(PracticeWorkDataModelContainer _cont)
        {
            cont = _cont;
        }

        public IEnumerable<Queue> Queues(int _id)
        {
            return cont.QueueSet.Where(c => _id == c.Model.Id);
        }
        public Server GetServer(int _id)
        {
            return cont.ServerSet.Find(_id);
        }

        public void Add(string _name, int _ConnectionSpeed, int _ModelId, int DeviceId)
        {
            Queue q = new Queue();
            q.Name = _name;
            q.ConnectionSpeed = _ConnectionSpeed;
            q.ModelId = _ModelId;
            q.NumberInQueue = 0;
            q.Device = cont.DeviceSet.Find(DeviceId);
            q.Device.HaveQueue = true;
            cont.QueueSet.Add(q);
            cont.SaveChanges();
        }

        public void Edit(int _id, string _name, int _ConnectionSpeed,int DeviceId)
        {
            Queue q = cont.QueueSet.Find(_id);
            q.Name = _name;
            q.ConnectionSpeed = _ConnectionSpeed;
            q.Device.HaveQueue = false;
            q.Device = cont.DeviceSet.Find(DeviceId);
            q.Device.HaveQueue = true;
            cont.SaveChanges();
        }

        public void Delete(int _id)
        {
            Queue q = cont.QueueSet.Find(_id);
            q.Device.HaveQueue = false;
            cont.QueueSet.Remove(q);
            cont.SaveChanges();
        }
    }
}