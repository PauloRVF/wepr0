using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wepr0.core.DTO;
using wepr0.core.Interface.Repository;
using wepr0.core.Interface.Service;
using wepr0.core.Model;

namespace wepr0.core.Service
{
    public class MoedaService : IMoedaService
    {
        private readonly IMoedaRepository _repository;
        private readonly IMapper _mapper;

        public MoedaService(IMoedaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public MoedaDTO Create(MoedaDTO moeda)
        {
            var moe = _repository.Create(_mapper.Map<Moeda>(moeda));
            return _mapper.Map<MoedaDTO>(moe);
        }

        public List<MoedaDTO> GetAllRegisters()
        {
            var moe = _repository.GetAllRegisters();
            return _mapper.Map<List<MoedaDTO>>(moe);
        }

        public MoedaDTO GetMoedaById(int IdMoeda)
        {
            var moe = _repository.GetMoedaById(IdMoeda);
            return _mapper.Map<MoedaDTO>(moe);
        }

        public MoedaDTO GetMoedaBySimbolo(string SimboloMoeda)
        {
            var moe = _repository.GetMoedaBySimbolo(SimboloMoeda);
            return _mapper.Map<MoedaDTO>(moe);
        }
    }
}
