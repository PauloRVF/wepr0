using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wepr0.core.AutoMapper;
using wepr0.core.Data.Repository;
using wepr0.core.Interface.Repository;
using wepr0.core.Interface.Service;
using wepr0.core.Service;

namespace wepr0.core
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
