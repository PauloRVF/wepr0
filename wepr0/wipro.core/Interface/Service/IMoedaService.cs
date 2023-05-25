using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wepr0.core.DTO;
using Wepr0.core.Model;

namespace Wepr0.core.Interface.Service
{
    public interface IMoedaService
    {
        List<MoedaDTO> GetAllRegisters();
        MoedaDTO GetMoedaBySimbolo(string SimboloMoeda);
        MoedaDTO GetMoedaById(int IdMoeda);
        MoedaDTO Create(MoedaDTO moeda);
    }
}
