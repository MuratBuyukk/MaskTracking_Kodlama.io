using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public int BirthYear { get; set; }
        public long NationalIdentity { get; set; }
    }
}
