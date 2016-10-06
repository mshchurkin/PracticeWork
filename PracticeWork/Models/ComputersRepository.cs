using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeWork.Models
{        
    public class ComputersRepository
    {
        private PracticeWorkDataModelContainer cont;

        public ComputersRepository (PracticeWorkDataModelContainer _cont)
        {
            cont = _cont;
        }
        public IEnumerable<Computer>Computers(int _id)
        {
            return cont.ComputerSet.Where(c=>_id==c.Model.Id);
        }
        public Computer GetComp(int _id)
        {
            return cont.ComputerSet.Find(_id);
        }
        
        public void Add(string _name, string _proccessor,int _RAM,int _Memory,int _ConnectionSpeed,int idm)
        {
                Computer c = new Computer();
                c.Name = _name;
                c.Processor = _proccessor;
                c.RAM =_RAM;
                c.Memory =_Memory;
                c.ConnectionSpeed =_ConnectionSpeed;
                c.ModelId = idm;
                cont.ComputerSet.Add(c);
                cont.SaveChanges();
        }
        
        public void Edit(int _id,string _name, string _proccessor,int _RAM,int _Memory,int _ConnectionSpeed)
        {
            Computer c = cont.ComputerSet.Find(_id);
            c.Name = _name;
            c.Processor = _proccessor;
            c.RAM =_RAM;
            c.Memory =_Memory;
            c.ConnectionSpeed =_ConnectionSpeed;
            cont.SaveChanges();
        }

        public void Delete(int _id)
        {
            Computer c = cont.ComputerSet.Find(_id);
            cont.ComputerSet.Remove(c);
            cont.SaveChanges();
        }
    }
}