using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wipro.core.Data.Context;
using wipro.core.Data.Repository;
using wipro.core.DTO;
using wipro.core.Interface.Repository;
using wipro.core.Model;

namespace wipro.core.AutoMapper
{
    public class MappingModel : Profile
    {
        private readonly IMoedaRepository _moedaRepository;

        public MappingModel(IMoedaRepository moedaRepository)
        {
            _moedaRepository = moedaRepository;
        }

        public MappingModel()
        {
            CreateMap<Moeda, MoedaDTO>();
            CreateMap<MoedaDTO, Moeda>();

            CreateMap<Processo, ProcessoDTO>().ForMember(p => p.Moeda, map => map.MapFrom(src => $"{src.Moeda.Simbolo}"));
            CreateMap<ProcessoDTO, Processo>().ForMember(p => p.Moeda, opt => opt.Ignore());
                
                
                
                //.ForMember(p => p.MoedaId, map => map.MapFrom(src => src.Moeda.))
                //
        }        

    }
}
