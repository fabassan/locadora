﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaLoca.BusinnesLogic.Model;

namespace Passatempo.LogicaNegocio.Repository
{
    public class FilmeRepository : Repository<Filme>
    {
        public FilmeRepository(SistemaLocaDBContext dbContext_)
            : base(dbContext_)
        {
            
        }
        
        public List<Filme> getFilmesPorTitulo(string titulo)
        {
            //return base._dbSet.Where(f => f.Titulo.StartsWith(titulo)).ToList<Filme>();
            return new List<Filme>(from f in _dbSet where f.Titulo.StartsWith(titulo) select f);
        }
    }
}