using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsService1
{
    static class Program
    {
        private static readonly globaldeEntities Db = new globaldeEntities();
        static void Main()
        {

#if DEBUG
            var svc = new Service1();
            svc.OnNewExecution();
            Thread.Sleep(Timeout.Infinite);
#else

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }


    }
}
