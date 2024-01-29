using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntity.Entities
{
    public class Groups
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public int DepartmentId { get; set; }
   
        public Departments Departments { get; set; }    

        public ICollection<Curators> Curators { get; set; }

        public ICollection<Students> Students { get; set; }

        public ICollection<Lectures> Lectures { get; set; }


    }
}
