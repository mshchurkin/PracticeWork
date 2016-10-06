using PracticeWork.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeWork.Controllers
{
    public class ModelsController : Controller
    {
        private DataManager _DataManager;

        public ModelsController(DataManager _DM)
        {
            _DataManager = _DM;

        }

        public ActionResult ModelsCollection()
        {
            ViewData["ModelsCollection"] = _DataManager.MR.Models();
            return View();
        }

        public ActionResult Models(int _id)
        {
            PracticeWork.ModelIDKeeper.Keeper = _id;
            ViewData["ComputersCollection"] = _DataManager.CR.Computers(_id);
            ViewData["ServersCollection"] = _DataManager.SR.Servers(_id);
            ViewData["DevicesCollection"] = _DataManager.DR.Devices(_id);
            ViewData["RoutersCollection"] = _DataManager.RR.Routers(_id);
            ViewData["QueuesCollection"] = _DataManager.QR.Queues(_id);
            return View();
        }
        public ActionResult ModelBack()
        {
            return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
        }
        public ActionResult Routines(int _idq)
        {
            PracticeWork.ModelIDKeeper.QK = _idq;
            ViewData["RoutinesCollection"] = _DataManager.RER.Routines(_idq);
            return View();
        }
        public ActionResult Connections(int _idr)
        {
            PracticeWork.ModelIDKeeper.RK = _idr;
            ViewData["ConnectionsCollection"] = _DataManager.CNR.Connections(_idr);
            return View();
        }

        public ActionResult Delete(int _id)
        {
            _DataManager.MR.Delete(_id);
            return RedirectToAction("ModelsCollection");
        }
        public ActionResult DeleteComp(int _id)
        {
            _DataManager.CR.Delete(_id);
            return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
        }
        public ActionResult DeleteServ(int _id)
        {
            _DataManager.SR.Delete(_id);
            return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
        }

        public ActionResult DeleteDevice(int _id)
        {
            _DataManager.DR.Delete(_id);
            return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
        }

        public ActionResult DeleteRouter(int _id)
        {
            _DataManager.RR.Delete(_id);
            return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
        }
        public ActionResult DeleteQueue(int _id)
        {
            _DataManager.QR.Delete(_id);
            return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
        }
        public ActionResult DeleteRoutine(int _id)
        {
            _DataManager.RER.Delete(_id);
            return RedirectToAction("Routines", new { _idq = PracticeWork.ModelIDKeeper.QK });
        }
        public ActionResult DeleteConnection(int _id)
        {
            _DataManager.CNR.Delete(_id);
            return RedirectToAction("Connections", new { _idr = PracticeWork.ModelIDKeeper.RK });
        }
        [AcceptVerbs(HttpVerbs.Get)]

        public ActionResult Edit(int _id)
        {
            Model m = _DataManager.MR.GetModel(_id);
            ViewData.Model = m;

            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Edit(int id, string name, string description)
        {

            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (string.IsNullOrEmpty(description.Trim()))
                ModelState.AddModelError("Description", "Название указано не верно");
            if (ModelState.IsValid)
            {
                _DataManager.MR.Edit(id, name, description);
                return RedirectToAction("ModelsCollection");
            }
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult EditComp(int _id)
        {
            Computer c = _DataManager.CR.GetComp(_id);
            ViewData.Model = c;

            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult EditComp(int id, string name, string processor, string RAM, string Memory, string ConnectionSpeed)
        {
            int m = -1;
            int r = -1;
            int c = -1;
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (string.IsNullOrEmpty(processor.Trim()))
                ModelState.AddModelError("Processor", "Название указано не верно");
            if (Int32.TryParse(RAM, out r))
            {
                if (r <= 0)
                    ModelState.AddModelError("RAM", "Неправильно указан объем оперативной памяти");
            }
            else ModelState.AddModelError("RAM", "Неправильно указан объем оперативной памяти");

            if (Int32.TryParse(Memory, out m))
            {
                if (m <= 0)
                    ModelState.AddModelError("Memory", "Неправильно указан объем хранилища");
            }
            else ModelState.AddModelError("Memory", "Неправильно указан объем хранилища");
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            else ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");

            if (ModelState.IsValid)
            {
                _DataManager.CR.Edit(id, name, processor, r, m, c);
                return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
            }
            return View();
        }

        public ActionResult EditServer(int _id)
        {
            Server s = _DataManager.SR.GetServer(_id);
            ViewData.Model = s;
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult EditServer(int id, string name, string RAM, string Memory, string ConnectionSpeed)
        {
            int m = -1;
            int r = -1;
            int c = -1;
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (Int32.TryParse(RAM, out r))
            {
                if (r <= 0)
                    ModelState.AddModelError("RAM", "Неправильно указан объем оперативной памяти");
            }
            else ModelState.AddModelError("RAM", "Неправильно указан объем оперативной памяти");

            if (Int32.TryParse(Memory, out m))
            {
                if (m <= 0)
                    ModelState.AddModelError("Memory", "Неправильно указан объем хранилища");
            }
            else ModelState.AddModelError("Memory", "Неправильно указан объем хранилища");
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            else ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");

            if (ModelState.IsValid)
            {
                _DataManager.SR.Edit(id, name, r, m, c);
                return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
            }
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Add()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Add(string name, string description)
        {
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (string.IsNullOrEmpty(description.Trim()))
                ModelState.AddModelError("Description", "Название указано не верно");
            if (ModelState.IsValid)
            {
                _DataManager.MR.Add(name, description);
                return RedirectToAction("ModelsCollection");
            }
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult AddComp()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult AddComp(string name, string processor, string RAM, string Memory, string ConnectionSpeed)
        {
            int m = -1;
            int r = -1;
            int c = -1;
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (string.IsNullOrEmpty(processor.Trim()))
                ModelState.AddModelError("Processor", "Название указано не верно");
            if (Int32.TryParse(RAM, out r))
            {
                if (r <= 0)
                    ModelState.AddModelError("RAM", "Неправильно указан объем оперативной памяти");
            }
            else ModelState.AddModelError("RAM", "Неправильно указан объем оперативной памяти");

            if (Int32.TryParse(Memory, out m))
            {
                if (m <= 0)
                    ModelState.AddModelError("Memory", "Неправильно указан объем хранилища");
            }
            else ModelState.AddModelError("Memory", "Неправильно указан объем хранилища");
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            else ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");

            if (ModelState.IsValid)
            {
                _DataManager.CR.Add(name, processor, r, m, c, PracticeWork.ModelIDKeeper.Keeper);
                return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
            }
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult AddServer()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult AddServer(string name, string RAM, string Memory, string ConnectionSpeed)
        {
            int m = -1;
            int r = -1;
            int c = -1;
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (Int32.TryParse(RAM, out r))
            {
                if (r <= 0)
                    ModelState.AddModelError("RAM", "Неправильно указан объем оперативной памяти");
            }
            else ModelState.AddModelError("RAM", "Неправильно указан объем оперативной памяти");

            if (Int32.TryParse(Memory, out m))
            {
                if (m <= 0)
                    ModelState.AddModelError("Memory", "Неправильно указан объем хранилища");
            }
            else ModelState.AddModelError("Memory", "Неправильно указан объем хранилища");
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            else ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");

            if (ModelState.IsValid)
            {
                _DataManager.SR.Add(name, r, m, c, PracticeWork.ModelIDKeeper.Keeper);
                return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
            }
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult AddDevice()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult AddDevice(string name, string description, string RAM, string Memory, string ConnectionSpeed, string VideoMemory)
        {
            int m = -1;
            int r = -1;
            int c = -1;
            int v = -1;
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (string.IsNullOrEmpty(description.Trim()))
                ModelState.AddModelError("Description", "Название указано не верно");
            if (Int32.TryParse(RAM, out r))
            {
                if (r <= 0)
                    ModelState.AddModelError("RAM", "Неправильно указан объем оперативной памяти");
            }
            else r = 0;

            if (Int32.TryParse(Memory, out m))
            {
                if (m <= 0)
                    ModelState.AddModelError("Memory", "Неправильно указан объем хранилища");
            }
            else m = 0;
            if (Int32.TryParse(Memory, out v))
            {
                if (v <= 0)
                    ModelState.AddModelError("VideoMemory", "Неправильно указан объем видеопамяти");
            }
            else v = 0;
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            else ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");

            if (ModelState.IsValid)
            {
                _DataManager.DR.Add(name, r, m, c, PracticeWork.ModelIDKeeper.Keeper, description, v);
                return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
            }
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult EditDevice(int _id)
        {
            Device d = _DataManager.DR.GetDevice(_id);
            ViewData.Model = d;
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult EditDevice(int id, string name, string description, string RAM, string Memory, string ConnectionSpeed, string VideoMemory)
        {
            int m = -1;
            int r = -1;
            int c = -1;
            int v = -1;
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (string.IsNullOrEmpty(description.Trim()))
                ModelState.AddModelError("Description", "Название указано не верно");
            if (Int32.TryParse(RAM, out r))
            {
                if (r < 0)
                    ModelState.AddModelError("RAM", "Неправильно указан объем оперативной памяти");
            }
            else r = 0;

            if (Int32.TryParse(Memory, out m))
            {
                if (m < 0)
                    ModelState.AddModelError("Memory", "Неправильно указан объем хранилища");
            }
            else m = 0;
            if (Int32.TryParse(Memory, out v))
            {
                if (v < 0)
                    ModelState.AddModelError("VideoMemory", "Неправильно указан объем видеопамяти");
            }
            else v = 0;
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            else ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");

            if (ModelState.IsValid)
            {
                _DataManager.DR.Edit(id, name, v, r, m, c, PracticeWork.ModelIDKeeper.Keeper, description);
                return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
            }
            return View();
        }
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult AddRouter()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult AddRouter(string name, string ConnectionSpeed)
        {
            int c = -1;
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            else ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");

            if (ModelState.IsValid)
            {
                _DataManager.RR.Add(name, c, PracticeWork.ModelIDKeeper.Keeper);
                return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
            }
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult EditRouter(int _id)
        {
            Router r = _DataManager.RR.GetRouter(_id);
            ViewData.Model = r;

            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult EditRouter(int id, string name, string ConnectionSpeed)
        {
            int c = -1;
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            else ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");

            if (ModelState.IsValid)
            {
                _DataManager.RR.Edit(id, name, c);
                return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
            }
            return View();
        }
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult AddQueue()
        {
            List<SelectListItem> DeviceList = new List<SelectListItem>();

            foreach (Device d in _DataManager.DR.Devices(PracticeWork.ModelIDKeeper.Keeper).Where(d => d.HaveQueue == false))
                DeviceList.Add(new SelectListItem
                {
                    Text = d.Name,
                    Value = d.Id.ToString()
                });
            ViewBag.Device = DeviceList;
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult AddQueue(string name, string ConnectionSpeed, string Device)
        {
            int c = -1;
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            else ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            if (string.IsNullOrEmpty(Device.Trim()))
                ModelState.AddModelError("DeviceId", "Устройство не выбрано");
            if (ModelState.IsValid)
            {
                _DataManager.QR.Add(name, c, PracticeWork.ModelIDKeeper.Keeper, Int32.Parse(Device));
                return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
            }
            List<SelectListItem> DeviceList = new List<SelectListItem>();

            foreach (Device d in _DataManager.DR.Devices(PracticeWork.ModelIDKeeper.Keeper))
                DeviceList.Add(new SelectListItem
                {
                    Text = d.Name,
                    Value = d.Id.ToString()
                });

            ViewBag.Device = DeviceList;
            return View();
        }
        public ActionResult EditQueue(int _id)
        {
            int idd = 0;
            List<SelectListItem> DeviceList = new List<SelectListItem>();
            foreach (Device d in _DataManager.DR.Devices(PracticeWork.ModelIDKeeper.Keeper))
                if (d.HaveQueue == true)
                    if (d.Queue.Id == _id)
                        idd = d.Id;
            foreach (Device d in _DataManager.DR.Devices(PracticeWork.ModelIDKeeper.Keeper).Where(d => d.HaveQueue == false).Union((_DataManager.DR.Devices(PracticeWork.ModelIDKeeper.Keeper).Where(d => d.Id == idd))))
                DeviceList.Add(new SelectListItem
                {
                    Text = d.Name,
                    Value = d.Id.ToString()
                });
            ViewBag.Device = DeviceList;
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult EditQueue(int _id, string name, string ConnectionSpeed, string Device)
        {
            int c = -1;
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            else ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            if (string.IsNullOrEmpty(Device.Trim()))
                ModelState.AddModelError("DeviceId", "Устройство не выбрано");
            if (ModelState.IsValid)
            {
                _DataManager.QR.Edit(_id, name, c, Int32.Parse(Device));
                return RedirectToAction("Models", new { _id = PracticeWork.ModelIDKeeper.Keeper });
            }
            List<SelectListItem> DeviceList = new List<SelectListItem>();

            foreach (Device d in _DataManager.DR.Devices(PracticeWork.ModelIDKeeper.Keeper).Where(d => d.HaveQueue == false).Union((_DataManager.DR.Devices(PracticeWork.ModelIDKeeper.Keeper).Where(d => d.Queue.Device.Id == _id))))
                DeviceList.Add(new SelectListItem
                {
                    Text = d.Name,
                    Value = d.Id.ToString()
                });
            ViewBag.Device = DeviceList;
            return View();
        }
        public ActionResult AddRoutine()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult AddRoutine(string name, string function)
        {
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (string.IsNullOrEmpty(function.Trim()))
                ModelState.AddModelError("Function", "Описание функции не указано");
            if (ModelState.IsValid)
            {
                _DataManager.RER.Add(name, function, PracticeWork.ModelIDKeeper.Keeper, PracticeWork.ModelIDKeeper.QK);
                return RedirectToAction("Routines", new { _idq = PracticeWork.ModelIDKeeper.QK });
            }
            return View();
        }
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult EditRoutine(int _id)
        {
            Routine r = _DataManager.RER.GetRoutine(_id);
            ViewData.Model = r;
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditRoutine(int id, string name, string function)
        {
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (string.IsNullOrEmpty(function.Trim()))
                ModelState.AddModelError("Function", "Описание функции не указано");
            if (ModelState.IsValid)
            {
                _DataManager.RER.Edit(id, name, function);
                return RedirectToAction("Routines", new { _idq = PracticeWork.ModelIDKeeper.QK });
            }
            return View();
        }

        public ActionResult AddConnection()
        {
            List<SelectListItem> Clist = new List<SelectListItem>();
            foreach (Device d in _DataManager.DR.Devices(PracticeWork.ModelIDKeeper.Keeper).Where(d => d.ModelId == PracticeWork.ModelIDKeeper.Keeper))
                Clist.Add(new SelectListItem
                {
                    Text = d.Name,
                    Value = d.Name
                });
            foreach (Server s in _DataManager.SR.Servers(PracticeWork.ModelIDKeeper.Keeper).Where(s => s.ModelId == PracticeWork.ModelIDKeeper.Keeper))
                Clist.Add(new SelectListItem
                {
                    Text = s.Name,
                    Value = s.Name
                });
            foreach (Computer c in _DataManager.CR.Computers(PracticeWork.ModelIDKeeper.Keeper).Where(c => c.ModelId == PracticeWork.ModelIDKeeper.Keeper))
                Clist.Add(new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Name
                });
            foreach (Queue q in _DataManager.QR.Queues(PracticeWork.ModelIDKeeper.Keeper).Where(q => q.ModelId == PracticeWork.ModelIDKeeper.Keeper))
                Clist.Add(new SelectListItem
                {
                    Text = q.Name,
                    Value = q.Name
                });
            ViewBag.D1 = Clist;
            ViewBag.D2 = Clist;
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult AddConnection(string name, string description, string D1, string D2)
        {
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (string.IsNullOrEmpty(description.Trim()))
                ModelState.AddModelError("Description", "Описание функции не указано");
            if (string.IsNullOrEmpty(D1.Trim()))
                ModelState.AddModelError("D1", "Устройство 1 не выбрано");
            if (string.IsNullOrEmpty(D1.Trim()))
                ModelState.AddModelError("D2", "Устройство 2 не выбрано");
            if (ModelState.IsValid)
            {
                _DataManager.CNR.Add(name, description, D1, D2, PracticeWork.ModelIDKeeper.Keeper, PracticeWork.ModelIDKeeper.RK);
                return RedirectToAction("Connections", new { _idr = PracticeWork.ModelIDKeeper.RK });
            }
            return View();
        }
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult EditConnection(int _id)
        {
            Connection c = _DataManager.CNR.GetConnection(_id);
            ViewData.Model = c;
            List<SelectListItem> Clist = new List<SelectListItem>();
            foreach (Device d in _DataManager.DR.Devices(PracticeWork.ModelIDKeeper.Keeper).Where(d => d.ModelId == PracticeWork.ModelIDKeeper.Keeper))
                Clist.Add(new SelectListItem
                {
                    Text = d.Name,
                    Value = d.Name
                });
            foreach (Server s in _DataManager.SR.Servers(PracticeWork.ModelIDKeeper.Keeper).Where(s => s.ModelId == PracticeWork.ModelIDKeeper.Keeper))
                Clist.Add(new SelectListItem
                {
                    Text = s.Name,
                    Value = s.Name
                });
            foreach (Computer co in _DataManager.CR.Computers(PracticeWork.ModelIDKeeper.Keeper).Where(co => co.ModelId == PracticeWork.ModelIDKeeper.Keeper))
                Clist.Add(new SelectListItem
                {
                    Text = co.Name,
                    Value = co.Name
                });
            foreach (Queue q in _DataManager.QR.Queues(PracticeWork.ModelIDKeeper.Keeper).Where(q => q.ModelId == PracticeWork.ModelIDKeeper.Keeper))
                Clist.Add(new SelectListItem
                {
                    Text = q.Name,
                    Value = q.Name
                });
            ViewBag.D1 = Clist;
            ViewBag.D2 = Clist;
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditConnection(int _id, string name, string description, string D1, string D2)
        {
            if (string.IsNullOrEmpty(name.Trim()))
                ModelState.AddModelError("Name", "Название указано не верно");
            if (string.IsNullOrEmpty(description.Trim()))
                ModelState.AddModelError("Description", "Описание функции не указано");
            if (string.IsNullOrEmpty(D1.Trim()))
                ModelState.AddModelError("D1", "Устройство 1 не выбрано");
            if (string.IsNullOrEmpty(D1.Trim()))
                ModelState.AddModelError("D2", "Устройство 2 не выбрано");
            if (ModelState.IsValid)
            {
                _DataManager.CNR.Edit(_id, name, description, D1, D2);
                return RedirectToAction("Connections", new { _idr = PracticeWork.ModelIDKeeper.RK });
            }
            return View();
        }
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult SpeedSelector()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SpeedSelector(string ConnectionSpeed)
        {
            int c = 0;
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            return RedirectToAction("SpeedInfo", new { _cs = c });
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult SpeedInfo(int _cs)
        {
            Random rnd = new Random();
            Dictionary<string, int> dr = new Dictionary<string, int>();
            foreach (Device d in _DataManager.DR.Devices(PracticeWork.ModelIDKeeper.Keeper))
                if ((d.ModelId == PracticeWork.ModelIDKeeper.Keeper) && (d.ConnectionSpeed > _cs))
                {
                    if (dr.ContainsKey(d.Name))
                    {
                        dr.Add(d.Name + rnd.Next(10, 99).ToString(), d.ConnectionSpeed);
                    }
                    else
                        dr.Add(d.Name, d.ConnectionSpeed);
                }
            foreach (Server s in _DataManager.SR.Servers(PracticeWork.ModelIDKeeper.Keeper))
                if ((s.ModelId == PracticeWork.ModelIDKeeper.Keeper) && (s.ConnectionSpeed > _cs))
                {
                    if (dr.ContainsKey(s.Name))
                    {
                        dr.Add(s.Name + rnd.Next(10, 99).ToString(), s.ConnectionSpeed);
                    }
                    else
                        dr.Add(s.Name, s.ConnectionSpeed);
                }
            foreach (Computer co in _DataManager.CR.Computers(PracticeWork.ModelIDKeeper.Keeper))
                if ((co.ModelId == PracticeWork.ModelIDKeeper.Keeper) && (co.ConnectionSpeed > _cs))
                {
                    if (dr.ContainsKey(co.Name))
                    {
                        dr.Add(co.Name + rnd.Next(10, 99).ToString(), co.ConnectionSpeed);
                    }
                    else
                        dr.Add(co.Name, co.ConnectionSpeed);
                }
            foreach (Queue q in _DataManager.QR.Queues(PracticeWork.ModelIDKeeper.Keeper))
                if ((q.ModelId == PracticeWork.ModelIDKeeper.Keeper) && (q.ConnectionSpeed > _cs))
                {
                    if (dr.ContainsKey(q.Name))
                    {
                        dr.Add(q.Name + rnd.Next(10, 99).ToString(), q.ConnectionSpeed);
                    }
                    else
                        dr.Add(q.Name, q.ConnectionSpeed);
                }
            foreach (Router r in _DataManager.RR.Routers(PracticeWork.ModelIDKeeper.Keeper))
                if ((r.ModelId == PracticeWork.ModelIDKeeper.Keeper) && (r.ConnectionSpeed > _cs))
                {
                    if (dr.ContainsKey(r.Name))
                    {
                        dr.Add(r.Name + rnd.Next(10, 99).ToString(), r.ConnectionSpeed);
                    }
                    else
                        dr.Add(r.Name, r.ConnectionSpeed);
                }
            ViewBag.dr = dr;
            return View(ViewData);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SpeedInfo(string ConnectionSpeed)
        {
            int c = 0;
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            return RedirectToAction("SpeedInfo", new { _idm = PracticeWork.ModelIDKeeper.Keeper, _cs = c });
        }
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult ServerSelector()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ServerSelector(string RAM, string Memory, string ConnectionSpeed)
        {
            int c = 0;
            int r = 0;
            int m = 0;
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            if (Int32.TryParse(RAM, out r))
            {
                if (r <= 0)
                    ModelState.AddModelError("RAM", "Неправильно указан объем оперативной памяти");
            }
            if (Int32.TryParse(Memory, out m))
            {
                if (c <= 0)
                    ModelState.AddModelError("Memory", "Неправильно указан объем хранилища");
            }
            return RedirectToAction("ServerInfo", new { _cs = c, _rs = r, _ms = m });
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult ServerInfo(int _cs, int _rs, int _ms)
        {
            ViewData["ServersCollection"] = _DataManager.SR.ServerSelector(_rs, _ms, _cs);
            ModelIDKeeper.gridview.DataSource = _DataManager.SR.ServerSelector(_rs, _ms, _cs).ToList();
            return View(ViewData);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ServerInfo(string ConnectionSpeed)
        {
            int c = 0;
            if (Int32.TryParse(ConnectionSpeed, out c))
            {
                if (c <= 0)
                    ModelState.AddModelError("ConnectionSpeed", "Неправильно указана скорость подключения");
            }
            ModelIDKeeper.cs = c;
            return RedirectToAction("SpeedInfo", new { _idm = PracticeWork.ModelIDKeeper.Keeper, _cs = c });
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult AllRoutines()
        {
            ViewData["AllRoutines"] = _DataManager.RER.RoutineSelector();
            ModelIDKeeper.gridview.DataSource = _DataManager.RER.RoutineSelector().ToList();
            return View(ViewData);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AllRoutines(int ok)
        {
            ViewData["AllRoutines"] = _DataManager.RER.RoutineSelector();
            ModelIDKeeper.gridview.DataSource = _DataManager.RER.RoutineSelector().ToList();
            return View(ViewData);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult AllConnections()
        {
            ViewData["AllConnections"] = _DataManager.CNR.ConnectionSelector();
            ModelIDKeeper.gridview.DataSource = _DataManager.CNR.ConnectionSelector().ToList();
            return View(ViewData);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AllConnections(int _id)
        {
            ViewData["AllConnections"] = _DataManager.CNR.ConnectionSelector();
            ModelIDKeeper.gridview.DataSource = _DataManager.CNR.ConnectionSelector().ToList();
            return View(ViewData);
        }
        // GET: ExportData
        public ActionResult Excel()
        {
            GridView gridview = new GridView();
            gridview.DataSource = (from m in _DataManager.SR.Servers(ModelIDKeeper.Keeper)
                                       where (m.ConnectionSpeed >= ModelIDKeeper.cs)
                                       select new { Имя_устройства = m.Name, Скорость_соединения = m.ConnectionSpeed }).Union
                                       (from d in _DataManager.DR.Devices(ModelIDKeeper.Keeper)
                                        where (d.ConnectionSpeed >= ModelIDKeeper.cs)
                                        select new { Имя_устройства = d.Name, Скорость_соединения = d.ConnectionSpeed }).Union
                                       (from r in _DataManager.RR.Routers(ModelIDKeeper.Keeper)
                                        where (r.ConnectionSpeed >= ModelIDKeeper.cs)
                                        select new { Имя_устройства = r.Name, Скорость_соединения = r.ConnectionSpeed }).Union
                                       (from q in _DataManager.QR.Queues(ModelIDKeeper.Keeper)
                                        where (q.ConnectionSpeed >= ModelIDKeeper.cs)
                                        select new { Имя_устройства = q.Name, Скорость_соединения = q.ConnectionSpeed }).Union
                                       (from c in _DataManager.CR.Computers(ModelIDKeeper.Keeper)
                                        where (c.ConnectionSpeed >= ModelIDKeeper.cs)
                                        select new { Имя_устройства = c.Name, Скорость_соединения = c.ConnectionSpeed }).ToList();

            // instantiate the GridView control from System.Web.UI.WebControls namespace
            // set the data source

            gridview.DataBind();

            // Clear all the content from the current response
            Response.ClearContent();
            Response.Buffer = true;
            // set the header
            Response.AddHeader("content-disposition", "attachment; filename=check.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";
            System.Web.HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF8;
            System.Web.HttpContext.Current.Response.Charset = System.Text.Encoding.UTF8.WebName;
            // create HtmlTextWriter object with StringWriter

            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter htw = new HtmlTextWriter(sw))
                {
                    // render the GridView to the HtmlTextWriter
                    gridview.RenderControl(htw);
                    // Output the GridView content saved into StringWriter
                    Response.Output.Write(sw.ToString());
                    Response.Flush();
                    Response.End();
                }
            }
            return View();
        }
        // GET: ExportData
        public ActionResult ExcelServ()
        {
            // instantiate the GridView control from System.Web.UI.WebControls namespace
            // set the data source

            ModelIDKeeper.gridview.DataBind();

            // Clear all the content from the current response
            Response.ClearContent();
            Response.Buffer = true;
            // set the header
            Response.AddHeader("content-disposition", "attachment; filename=check.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";
            System.Web.HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF8;
            System.Web.HttpContext.Current.Response.Charset = System.Text.Encoding.UTF8.WebName;
            // create HtmlTextWriter object with StringWriter

            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter htw = new HtmlTextWriter(sw))
                {
                    // render the GridView to the HtmlTextWriter
                    ModelIDKeeper.gridview.RenderControl(htw);
                    // Output the GridView content saved into StringWriter
                    Response.Output.Write(sw.ToString());
                    Response.Flush();
                    Response.End();
                }
            }
            return View();
        }

        // GET: ExportData
        public ActionResult ExcelCon()
        {
            // instantiate the GridView control from System.Web.UI.WebControls namespace
            // set the data source

            ModelIDKeeper.gridview.DataBind();

            // Clear all the content from the current response
            Response.ClearContent();
            Response.Buffer = true;
            // set the header
            Response.AddHeader("content-disposition", "attachment; filename=check.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";
            System.Web.HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF8;
            System.Web.HttpContext.Current.Response.Charset = System.Text.Encoding.UTF8.WebName;
            // create HtmlTextWriter object with StringWriter

            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter htw = new HtmlTextWriter(sw))
                {
                    // render the GridView to the HtmlTextWriter
                    ModelIDKeeper.gridview.RenderControl(htw);
                    // Output the GridView content saved into StringWriter
                    Response.Output.Write(sw.ToString());
                    Response.Flush();
                    Response.End();
                }
            }
            return View();
        }
        public ActionResult ExcelRout()
        {
            // instantiate the GridView control from System.Web.UI.WebControls namespace
            // set the data source

            ModelIDKeeper.gridview.DataBind();

            // Clear all the content from the current response
            Response.ClearContent();
            Response.Buffer = true;
            // set the header
            Response.AddHeader("content-disposition", "attachment; filename=check.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";
            System.Web.HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF8;
            System.Web.HttpContext.Current.Response.Charset = System.Text.Encoding.UTF8.WebName;
            // create HtmlTextWriter object with StringWriter

            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter htw = new HtmlTextWriter(sw))
                {
                    // render the GridView to the HtmlTextWriter
                    ModelIDKeeper.gridview.RenderControl(htw);
                    // Output the GridView content saved into StringWriter
                    Response.Output.Write(sw.ToString());
                    Response.Flush();
                    Response.End();
                }
            }
            return View();
        }
    }
}