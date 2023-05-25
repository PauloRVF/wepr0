using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wepr0.core.Model;

namespace Wepr0.core.Interface.Repository
{
    public interface IProcessoRepository
    {
        Processo GetLastProcesso();
        Processo Create(Processo processo);
        Processo RemoveLast();
    }
}
