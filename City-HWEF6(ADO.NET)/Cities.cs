using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City_HWEF6_ADO.NET_
{
    public class Cities
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NameCity { get; set; }
        public string CodeNumberCity { get; set; }
    }
}
