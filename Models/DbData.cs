using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carserviceapp.Models
{
    [Serializable]
    public class DbData
    {
        public List<Order> Orders { get; set; }
        public List<Service> Services { get; set; }

        public DbData() { }
    }
}
