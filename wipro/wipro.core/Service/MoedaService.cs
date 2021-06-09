using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wipro.core.DTO;
using wipro.core.Interface.Repository;
using wipro.core.Interface.Service;
using wipro.core.Model;

namespace wipro.core.Service
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
