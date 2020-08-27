using StructureMap;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.StructureMap
{
    public class StructureMappingRegistry : Registry
    {
        public StructureMappingRegistry()
        {
            For<IMessagingService>().LifecycleIs(Lifecycles.Container)
                .Use<StructureMappingService>();
        }

    }
}
