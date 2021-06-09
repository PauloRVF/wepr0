using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wipro.core.Data.Context;
using wipro.core.Interface.Repository;
using wipro.core.Model;

namespace wipro.core.Data.Repository
{
    public class ProcessoRepository : IProcessoRepository
    {
        private readonly wpContext _context;

        public ProcessoRepository(wpContext context)
        {
            _context = context;
        }

        public Processo Create(Processo processo)
        {
            _context.InitTransaction();
            _context.Set<Processo>().Add(processo);
            _context.SendChanges();
            return processo;
        }

        public Processo GetLastProcesso()
        {
            var processo = _context.Set<Processo>().OrderByDescending(p => p.Id).Include(p => p.Moeda).FirstOrDefault();

            if (processo == null)
                throw new KeyNotFoundException("Não existe nenhum processo na fila");

            return processo;
        }

        public Processo RemoveLast()
        {
            var processo = GetLastProcesso();
            _context.InitTransaction();
            _context.Set<Processo>().Remove(processo);
            _context.SendChanges();

            return processo;
        }
    }
}
