using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoWeb.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }
        public string Texto { get; set; }
        public bool Concluida { get; set; }

        #region Chaves Estrangeiras
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
        #endregion
    }
}