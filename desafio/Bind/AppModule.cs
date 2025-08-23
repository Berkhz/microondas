using desafio.BLL;
using desafio.BLL.Interface;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio.Bind
{
    class AppModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITempo>().To<Tempo>();
            Bind<IPotencia>().To<Potencia>();
        }
    }
}
