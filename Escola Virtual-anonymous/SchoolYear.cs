using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_Virtual_anonymous
{
    public class SchoolYear
    {
        public string Year { get; set; }

        public List<Classes> Classes { get; set; } = new List<Classes>();
    }
}
