using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace carserviceapp.Models
{
    static class AppDB
    {
        private static readonly string dbName = "AppDB.XML";
        public static int LastOrderId { get; private set; }
        public static int LastServiceId { get; private set; }

        static AppDB()
        {
            if(File.Exists(dbName) == false)
            {
                XmlSerializer xmlWriter = new XmlSerializer(typeof(DbData));
                using (var fs = new FileStream(dbName, FileMode.Create))
                {
                    xmlWriter.Serialize(fs, new DbData { Services = new List<Service>() { new Service("Teset 1", 234.5m) } });
                }
            }
        }

        public static string GetDescription<T>(this T enumerationValue) where T : struct
        {
            var type = enumerationValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException($"{nameof(enumerationValue)} must be of Enum type", nameof(enumerationValue));
            }
            var memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            return enumerationValue.ToString();
        }

        public static string[] GetStatusDescriptions()
        {
            List<string> descr = new List<string>();
            var values = typeof(Status).GetEnumValues();
            foreach (var val in values)
            {
                descr.Add(((Status)val).GetDescription());
            }
            return descr.ToArray();
        }

        private static DbData ReadXML()
        {
            XmlSerializer xmlWriter = new XmlSerializer(typeof(DbData));
            using (var fs = new FileStream(dbName, FileMode.Open))
            {
                var dbData = (xmlWriter.Deserialize(fs) as DbData);
                LastOrderId = dbData.Orders.Count > 0 ? dbData.Orders.Max(o => o.Id) : 0;
                LastServiceId = dbData.Services.Count > 0 ? dbData.Services.Max(d => d.Id) : 0;
                return dbData;
            }
        }

        //ORDERS
        public static List<Order> GetOrders()
        {
            return ReadXML().Orders;
        }
        public static void AddOrder(Order order)
        {
            //read
            var data = ReadXML();

            //process
            order.Id = ++LastOrderId;
            data.Orders.Add(order);

            //write
            XmlSerializer xmlWriter = new XmlSerializer(typeof(DbData));
            using (var fs = new FileStream(dbName, FileMode.Create))
            {
                xmlWriter.Serialize(fs, data);
            }
        }
        public static void RemoveOrder(int id)
        {
            //read
            var data = ReadXML();

            //process
            data.Orders.Remove(data.Orders.First(o => o.Id == id));

            //write
            XmlSerializer xmlWriter = new XmlSerializer(typeof(DbData));
            using (var fs = new FileStream(dbName, FileMode.Create))
            {
                xmlWriter.Serialize(fs, data);
            }
        }
        public static void UpdateOrderStatus(Order order)
        {
            //read
            var data = ReadXML();

            //process
            data.Orders[data.Orders.FindIndex(o => o.Id == order.Id)].Status = order.Status;

            //write
            XmlSerializer xmlWriter = new XmlSerializer(typeof(DbData));
            using (var fs = new FileStream(dbName, FileMode.Create))
            {
                xmlWriter.Serialize(fs, data);
            }
        }

        //SERVICES
        public static List<Service> GetServices()
        {
            return ReadXML().Services;
        }
        public static void AddService(Service service)
        {
            //read
            var data = ReadXML();

            //process
            service.Id = ++LastServiceId;
            data.Services.Add(service);

            //write
            XmlSerializer xmlWriter = new XmlSerializer(typeof(DbData));
            using (var fs = new FileStream(dbName, FileMode.Create))
            {
                xmlWriter.Serialize(fs, data);
            }
        }
        public static void RemoveService(int id)
        {
            //read
            var data = ReadXML();

            //process
            data.Services.Remove(data.Services.First(s => s.Id == id));

            //write
            XmlSerializer xmlWriter = new XmlSerializer(typeof(DbData));
            using (var fs = new FileStream(dbName, FileMode.Create))
            {
                xmlWriter.Serialize(fs, data);
            }
        }
        public static void UpdateService(Service service)
        {
            //read
            var data = ReadXML();

            //process
            data.Services[data.Services.FindIndex(s => s.Id == service.Id)] = service;

            //write
            XmlSerializer xmlWriter = new XmlSerializer(typeof(DbData));
            using (var fs = new FileStream(dbName, FileMode.Create))
            {
                xmlWriter.Serialize(fs, data);
            }
        }

    }
}
