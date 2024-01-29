using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntity.Entities
{
    public class Departments
    {
        public int Id { get; set; }

        public int Building { get; set; }

        public string Name { get; set; }

        public decimal Financing { get; set; }

        public int FacultyId { get; set; }

        public Faculties Faculty { get; set; }
    }
}
