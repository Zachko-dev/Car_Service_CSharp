using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carserviceapp.Models
{
    public enum Status
    {
        [Description("В процесі")]
        InProgress,
        [Description("Заплановано")]
        ToDo, 
        [Description("Виконано")]
        Done
    }

    [Serializable]
    public class Order
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Назва замовлення")]
        public string Label { get; set; }
        [Browsable(false)]
        public List<Service> Services { get; set; }
        [DisplayName("Дата створення")]
        public DateTime CreationDateTime { get; set; }
        [Browsable(false)]
        public float OverPrice { get; set;}
        [DisplayName("Націнка")]
        public string OverPriceString => (OverPrice * 100) + "%";
        [Browsable(false)]
        public Status Status { get; set; }
        [DisplayName("Статус замовлення")]
        public string StatusString => Status.GetDescription();
        [DisplayName("Вартість замовлення")]
        public decimal GetTotalCost()
        {
            decimal sum = Services.Sum(s => s.Cost);
            return (sum + (sum*(decimal)OverPrice));
        }


        public Order(string label, float overPrice, List<Service> services)
        {
            this.Label = label;
            this.OverPrice = overPrice;
            this.CreationDateTime = DateTime.Now;
            this.Status = Status.ToDo;
            this.Services = services;
        }

        public Order() { }

    }
}
