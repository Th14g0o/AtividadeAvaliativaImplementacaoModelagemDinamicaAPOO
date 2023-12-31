﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto.DAL;
using Projeto.Models;

namespace Projeto.Servico
{
    public class ItemServico
    {
        public ItemDAL Dal = new ItemDAL();
        public List<ItemTema> Listar()
        {
            return Dal.Listar();
        }
        public ItemTema AcharPorId(long id)
        {
            return Dal.Achar(id);
        }
        public bool Gravar(ItemTema i)
        {
            return Dal.Gravar(i);
        }
        public bool Editar(ItemTema i)
        {
            return Dal.Editar(i);
        }
        public bool Excluir(ItemTema i)
        {
            return Dal.Excluir(i);
        }
    }
}