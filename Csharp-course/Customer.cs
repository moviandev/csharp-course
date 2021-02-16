using System.Collections.Generic;

namespace Csharp_course
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id) 
            : this() => Id = id;

        public Customer(int id, string name)
            : this(id) => Name = name;
    }
}
