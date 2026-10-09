using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual_anonymous
{
    public class Classes
    {
        public string ClassName { get; set; }
        public string School_Year  { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
        public List<Subjects> Subjects { get; set; } = new List<Subjects>();
    }
}
