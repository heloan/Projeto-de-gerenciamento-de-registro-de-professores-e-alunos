﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univap.Programacao3.Projeto.Model
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdProfessor { get; set; }
        public int IdTurma { get; set; }
    }
}
