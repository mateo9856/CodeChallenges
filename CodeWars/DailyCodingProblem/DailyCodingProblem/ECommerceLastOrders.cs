using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    public class ECommerceLastOrders
    {
        List<Order> ordersLog;
        public void RecordToLog(int orderId)
        {

        }

        public void EnumerateAdd()
        {
            for(int i = 1; i <= 10; i++)
            {
                ordersLog.Add(new Order(i, i.ToString()));
            }
        }

        public ECommerceLastOrders()
        {
            ordersLog = new List<Order>();
            EnumerateAdd();
        }

        public Order GetLast(int i)
        {
            int n = ordersLog.Count;

            while (n - i > n)
                i--;

            return ordersLog[n - i];
        }

    }

    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Order(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

}
