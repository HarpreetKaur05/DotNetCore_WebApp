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
            return "Hello from Structure Map!!!";
        }

    }
}
