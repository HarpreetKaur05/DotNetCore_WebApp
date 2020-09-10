using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Controller;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.StructureMap
{   
    public class StructureMappingService : IMessagingService
    {
        public string GetMessage()
        {
            var str = "Implementation of DI with Lamer";
            return str;
        }

    }
}
