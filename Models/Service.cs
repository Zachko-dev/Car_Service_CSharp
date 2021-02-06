using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carserviceapp.Models
{
    [Serializable]
    public class Service
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Назва послуги")]
        public string Label { get; set; }
        [DisplayName("Вартість")]
        public decimal Cost { get; set; }

        public Service(string label, decimal cost)
        {
            Label = label;
            Cost = cost;
        }

        public Service() { }

    }
}
