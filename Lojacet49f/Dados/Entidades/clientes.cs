using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lojacet49f.Dados.Entidades
{
    public class clientes
    {
        public int Id { set; get; }

        [Display(Name = "Nome")]
        public string NomeCliente { get; set; }

        [Display(Name = "Apelido")]
        public string ApelidoCliente { get; set; }
    }
}
