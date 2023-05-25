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
    public class ProcessoService : IProcessoService
    {
        private readonly IProcessoRepository _repository;
        private readonly IMoedaRepository _moedaRepository;
        private readonly IMapper _mapper;

        public ProcessoService(IProcessoRepository repository, IMapper mapper, IMoedaRepository moedaRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _moedaRepository = moedaRepository;
        }

        public ProcessoDTO Create(ProcessoDTO processo)
        {
            try
            {
                var moedaLocal = _mapper.Map<Processo>(processo);
                moedaLocal.MoedaId = _moedaRepository.GetMoedaBySimbolo(processo.Moeda).Id;

                var proc = _repository.Create(moedaLocal);
                return _mapper.Map<ProcessoDTO>(proc);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<ProcessoDTO> CreateAll(IEnumerable<ProcessoDTO> processos)
        {
            try
            {
                foreach(var processo in processos)
                {
                    Create(processo);
                }

                return processos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ProcessoDTO GetLastProcesso()
        {
            try
            {
                var proc = _repository.RemoveLast();
                return _mapper.Map<ProcessoDTO>(proc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
    }
}
