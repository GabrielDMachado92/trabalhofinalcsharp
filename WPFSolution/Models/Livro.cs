using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSolution.Models
{
    class Livro
    {

        public String Nome { get; set; }

        public int Edicao { get; set; }

        public Doador doador { get; set; }

        public Ong ong { get; set; }

    }
}
