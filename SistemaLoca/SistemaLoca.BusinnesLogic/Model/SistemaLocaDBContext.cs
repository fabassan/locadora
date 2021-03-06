﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using SistemaLoca.BusinnesLogic.Model.ControleAcervo;
using SistemaLoca.BusinnesLogic.Model.AtendimentoCliente;

namespace SistemaLoca.BusinnesLogic.Model
{
    public class SistemaLocaDBContext : DbContext
    {
        //Controle de Acervo

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<ItemFilme> ItensFilme { get; set; }
        //public DbSet<Genero> Generos { get; set; }
        //public DbSet<Midia> Midias { get; set; }
        //public DbSet<Distribuidora> Distribuidoras { get; set; }

        //Atendimento ao Cliente

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Titular> Titulares { get; set; }
    }
}
