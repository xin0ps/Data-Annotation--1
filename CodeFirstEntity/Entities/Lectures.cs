using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntity.Entities
{
    public class Lectures
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public Subjects SubjectId { get; set; }

        public Teachers TeacherId { get; set; }

        public ICollection<Groups> Groups { get; set; }


    }
}
