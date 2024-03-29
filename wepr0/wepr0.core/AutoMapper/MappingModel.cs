﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wepr0.core.Data.Context;
using Wepr0.core.Data.Repository;
using Wepr0.core.DTO;
using Wepr0.core.Interface.Repository;
using Wepr0.core.Model;

namespace Wepr0.core.AutoMapper
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
