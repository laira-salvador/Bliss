using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bliss_Domain.Entities
{
    public class Bank : Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
