using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntity.Entities
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
    
        public ICollection<Groups > Groups { get; set; }
    
    }
}
