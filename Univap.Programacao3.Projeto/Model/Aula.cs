using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univap.Programacao3.Projeto.Model
{
    public class Aula
    {
        public int Id { get; set; }
        public int IdDisciplina { get; set; }
        public int IdProfessor { get; set; }
        public DateTime Data { get; set; }
    }
}
