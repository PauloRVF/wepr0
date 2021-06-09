using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wipro.core.DTO;
using wipro.core.Model;

namespace wipro.core.Interface.Service
{
    public interface IMoedaService
    {
        List<MoedaDTO> GetAllRegisters();
        MoedaDTO GetMoedaBySimbolo(string SimboloMoeda);
        MoedaDTO GetMoedaById(int IdMoeda);
        MoedaDTO Create(MoedaDTO moeda);
    }
}
