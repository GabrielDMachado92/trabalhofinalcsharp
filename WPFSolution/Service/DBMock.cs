using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSolution.Models;

namespace WPFSolution.Service
{
    static class DBMock
    {

        public static List<Doador> DbDoadores { get; set; }

        public static List<Ong> DbOng { get; set; }

        public static List<Livro> DbLivro { get; set; }

    }
}
