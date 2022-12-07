using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAlunos.DataModels
{
    internal class Alunos
    {
        public int Id { get; set; }
        public string nome { get; set; }

        public virtual ICollection<Cursos> Cursos { get; set; }
    }
}
