using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaCrypto.Models
{
    public class Moedas
    {
        public int MoedasId { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }

        [NotMapped]
        public bool CheckboxMarcado { get; set; }
    }
}
