using Ahsel.DataAccess.General;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahsel.DataAccess.DependencyInjection
{
    public static class Resolver
    {
        public static void Resolve(this IServiceCollection services)
        {
            services
                .AddSingleton<IGeneralDal, GeneralDal>();
        }
    }
}
