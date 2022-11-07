using TheMovingCompanyAPI.Entities;

namespace TheMovingCompanyAPI.MockData
{
    public class MockOrderData
    {
        public readonly List<Order> _orders = new(){
                new Order
                {
                    Id = 1,
                    CustomerId = 1,
                    FromAdress = "123 Main St",
                    ToAdress = "456 Main St",
                    Note = "This is a note",
                    Date = DateTime.Now,
                },
                new Order
                {
                    Id = 2,
                    CustomerId = 2,
                    FromAdress = "123 Second St",
                    ToAdress = "456 Second St",
                    Note = "This is a note",
                    Date = DateTime.Now.AddDays(-1),
                },
                new Order
                {
                    Id = 3,
                    CustomerId = 3,
                    FromAdress = "123 Third St",
                    ToAdress = "456 Third St",
                    Note = "This is a note",
                    Date= DateTime.Now.AddDays(-2),
                },
                new Order
                {
                    Id = 4,
                    CustomerId = 4,
                    FromAdress = "123 Last St",
                    ToAdress = "456 Last St",
                    Note = "This is a note",
                    Date = DateTime.Now.AddDays(-3),
                }
            };
        public readonly List<Service> _services = new()
            {
                new Service
                {
                    Id = 1,
                    OrderId = 1,
                    ServiceType = "Moving",
                    Date = DateTime.Now.AddDays(2),
                },
                new Service
                {
                    Id = 2,
                    OrderId = 1,
                    ServiceType = "Packing",
                    Date = DateTime.Now.AddDays(1),
                },
                new Service
                {
                    Id = 3,
                    OrderId = 2,
                    ServiceType = "Moving",
                    Date = DateTime.Now.AddDays(1),
                },
                new Service
                {
                    Id = 4,
                    OrderId = 3,
                    ServiceType = "Cleaning",
                    Date = DateTime.Now.AddDays(3),
                },
                new Service
                {
                    Id = 5,
                    OrderId = 3,
                    ServiceType = "Moving",
                    Date = DateTime.Now.AddDays(1),
                },
                new Service
                {
                    Id = 6,
                    OrderId = 3,
                    ServiceType = "Packing",
                    Date = DateTime.Now.AddDays(1),
                },
                new Service
                {
                    Id = 7,
                    OrderId = 4,
                    ServiceType = "Moving",
                    Date = DateTime.Now.AddDays(4),
                }
            };
        public readonly List<Customer> _customers = new()
        {
                new Customer
                {
                    Id = 1,
                    Name = "John Smith",
                    Email = "john.smith@gmail.com",
                    PhoneNumber = "+90 76124648"
                },
                new Customer
                {
                    Id = 2,
                    Name = "John Andrews",
                    Email = "john.andrews@gmail.com",
                    PhoneNumber = "+90 76372648"
                },
                new Customer
                {
                    Id = 3,
                    Name = "John Kelly",
                    Email = "john.kelly@gmail.com",
                    PhoneNumber = "+90 76762648"
                },
                new Customer
                {
                    Id = 4,
                    Name = "Jhonny Appleseed",
                    Email = "jhonny.appleseed@gmail.com",
                    PhoneNumber = "+90 76732648"
                }
            };

        public List<Customer> GetCustomers()
        {
            return _customers;
        }

        public List<Order> GetOrders()
        {
            return _orders;
        }

        public List<Service> GetServices()
        {
            return _services;
        }
    }
}
