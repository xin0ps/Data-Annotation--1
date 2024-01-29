using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntity.Entities
{
    public class Teachers
    {
        public int Id { get; set; }

        public bool Professor { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }


        public decimal Salary { get; set; }


    }
}
