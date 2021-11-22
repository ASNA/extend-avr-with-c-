using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncHelper
{
    public class LogicRunner
    {
        AVRLogic.LogicFunctions lf = new AVRLogic.LogicFunctions();

        public void Run()
         {
            Task.WaitAll(f1(), f2(), f3());
        }

        async Task f1()
        {
            await Task.Run(() => lf.F1("async"));
        }

        async Task f2()
        {
            await Task.Run(() => lf.F2("async"));
        }

        async Task f3()
        {
            await Task.Run(() => lf.F3("async"));
        }


    }
}
