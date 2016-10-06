using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeWork.Models
{
    public class DataManager
    {
        private PracticeWorkDataModelContainer cont;
        public ModelsRepository MR;
        public ComputersRepository CR;
        public ServerRepository SR;
        public DeviceRepository DR;
        public RouterRepository RR;
        public QueueRepository QR;
        public RoutineRepository RER;
        public ConnectionRepository CNR;
        
        public DataManager()
        {
            cont = new PracticeWorkDataModelContainer();
            MR = new ModelsRepository(cont);
            CR = new ComputersRepository(cont);
            SR = new ServerRepository(cont);
            DR = new DeviceRepository(cont);
            RR = new RouterRepository(cont);
            QR = new QueueRepository(cont);
            RER= new RoutineRepository(cont);
            CNR = new ConnectionRepository(cont);
        }
    }
}