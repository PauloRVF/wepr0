using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wipro.core.AutoMapper;
using wipro.core.Data.Repository;
using wipro.core.Interface.Repository;
using wipro.core.Interface.Service;
using wipro.core.Service;

namespace wipro.core
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection svCollection)
        {
            //Services
            svCollection.AddScoped<IMoedaService, MoedaService>();
            svCollection.AddScoped<IProcessoService, ProcessoService>();

            //Repositories
            svCollection.AddScoped<IMoedaRepository, MoedaRepository>();
            svCollection.AddScoped<IProcessoRepository, ProcessoRepository>();

            svCollection.AddAutoMapper(x => x.AddProfile(new MappingModel()));
        }
    }
}
