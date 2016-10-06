using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeWork.Models;

namespace PracticeWork.Controllers
{
    public class ControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["PracticeWorkDataModelContainer"].ConnectionString;
            return Activator.CreateInstance(controllerType, new DataManager()) as IController;
        }

    }

    }
