using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeWork.Models
{
    public class DeviceRepository
    {
        private PracticeWorkDataModelContainer cont;

        public DeviceRepository(PracticeWorkDataModelContainer _cont)
        {
            cont = _cont;
        }

        public IEnumerable<Device> Devices(int _id)
        {
            return cont.DeviceSet.Where(c => _id == c.Model.Id);
        }
        public Device GetDevice(int _id)
        {
            return cont.DeviceSet.Find(_id);
        }

        public void Add(string _name,  int _RAM, int _Memory, int _ConnectionSpeed, int _ModelId, string _description, int _videoMemory)
        {
            Device d = new Device();
            d.Name = _name;
            d.VideoMemory = _videoMemory;
            d.RAM = _RAM;
            d.Memory = _Memory;
            d.ConnectionSpeed = _ConnectionSpeed;
            d.ModelId = _ModelId;
            d.Description = _description;
            d.HaveQueue = false;
            cont.DeviceSet.Add(d);
            cont.SaveChanges();
        }

        public void Edit(int _id, string _name, int _videoMemory, int _RAM, int _Memory, int _ConnectionSpeed, int _ModelId, string _description)
        {
            Device d = cont.DeviceSet.Find(_id);
            d.Name = _name;
            d.VideoMemory = _videoMemory;
            d.RAM = _RAM;
            d.Memory = _Memory;
            d.ConnectionSpeed = _ConnectionSpeed;
            d.Description = _description;
            cont.SaveChanges();
        }

        public void Delete(int _id)
        {
            Device d = cont.DeviceSet.Find(_id);
            Queue qd = cont.QueueSet.Find(d.Queue.Id);
            cont.QueueSet.Remove(qd);
            cont.DeviceSet.Remove(d);
            cont.SaveChanges();
        }
    }
}