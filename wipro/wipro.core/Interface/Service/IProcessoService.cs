using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wipro.core.DTO;
using wipro.core.Model;

namespace wipro.core.Interface.Service
{
    public interface IProcessoService
    {
        ProcessoDTO GetLastProcesso();
        ProcessoDTO Create(ProcessoDTO processo);
        IEnumerable<ProcessoDTO> CreateAll(IEnumerable<ProcessoDTO> processos);
    }
}
