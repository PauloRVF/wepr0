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
    public class MoedaRepository : IMoedaRepository
    {
        private readonly wpContext _context;

        public MoedaRepository(wpContext context)
        {
            _context = context;
        }

        public Moeda Create(Moeda moeda)
        {
            _context.InitTransaction();
            _context.Set<Moeda>().Add(moeda);
            _context.SendChanges();
            return moeda;
        }

        public List<Moeda> GetAllRegisters()
        {
            return _context.Set<Moeda>().ToList();
        }

        public Moeda GetMoedaById(int IdMoeda)
        {
            return _context.Set<Moeda>().Find(IdMoeda);
        }

        public Moeda GetMoedaBySimbolo(string SimboloMoeda)
        {
            var moeda = _context.Set<Moeda>().Where(m => m.Simbolo == SimboloMoeda).FirstOrDefault();

            if (moeda == null)
                throw new KeyNotFoundException($"Simbolo de moeda {SimboloMoeda} não corresponde a nenhum item conhecido.");

            return moeda;
        }
    }
}
