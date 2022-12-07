using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAlunos.DataModels
{
    internal class Cursos
    {
        public int id { get; set; }
        public string curso { get; set; }
        public virtual Alunos alunos { get; set; }
    }
}
