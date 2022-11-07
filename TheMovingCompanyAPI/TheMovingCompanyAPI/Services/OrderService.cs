using TheMovingCompanyAPI.Controllers;
using TheMovingCompanyAPI.Entities;
using TheMovingCompanyAPI.Models;

namespace TheMovingCompanyAPI.Services
{
    public class OrderService : IOrderService
    {

        private readonly List<Order> _orders = new(){
                new Order
                {
                    OrderId = 1,
                    CustomerId = 1,
                    FromAdress = "123 Main St",
                    ToAdress = "456 Main St",
                    Note = "This is a note",
                    Date = DateTime.Now,
                },
                new Order
                {
                    OrderId = 2,
                    CustomerId = 1,
                    FromAdress = "123 Second St",
                    ToAdress = "456 Second St",
                    Note = "This is a note",
                    Date = DateTime.Now.AddDays(-1),
                },
                new Order
                {
                    OrderId = 3,
                    CustomerId = 2,
                    FromAdress = "123 Third St",
                    ToAdress = "456 Third St",
                    Note = "This is a note",
                    Date= DateTime.Now.AddDays(-2),
                },
                new Order
                {
                    OrderId = 4,
                    CustomerId = 3,
                    FromAdress = "123 Last St",
                    ToAdress = "456 Last St",
                    Note = "This is a note",
                    Date = DateTime.Now.AddDays(-3),
                }
            };
        private readonly List<Service> _services = new()
            {
                new Service
                {
                    OrderId = 1,
                    ServiceType = "Moving",
                    Date = DateTime.Now.AddDays(2),
                },
                new Service
                {
                    OrderId = 1,
                    ServiceType = "Packing",
                    Date = DateTime.Now.AddDays(1),
                },
                new Service
                {
                    OrderId = 2,
                    ServiceType = "Moving",
                    Date = DateTime.Now.AddDays(1),
                },
                new Service
                {
                    OrderId = 3,
                    ServiceType = "Cleaning",
                    Date = DateTime.Now.AddDays(3),
                },
                new Service
                {
                    OrderId = 3,
                    ServiceType = "Moving",
                    Date = DateTime.Now.AddDays(1),
                },
                new Service
                {
                    OrderId = 3,
                    ServiceType = "Packing",
                    Date = DateTime.Now.AddDays(1),
                },
                new Service
                {
                    OrderId = 4,
                    ServiceType = "Moving",
                    Date = DateTime.Now.AddDays(4),
                }
            };
        private readonly List<Customer> _customers = new()
        {
                new Customer
                {
                    CustomerId = 1,
                    Name = "John Smith",
                    Email = "john.smith@gmail.com",
                    PhoneNumber = "+90 76772648"
                },
                new Customer
                {
                    CustomerId = 2,
                    Name = "John Andrews",
                    Email = "john.andrews@gmail.com",
                    PhoneNumber = "+90 76772648"
                },
                new Customer
                {
                    CustomerId = 3,
                    Name = "John Kelly",
                    Email = "john.kelly@gmail.com",
                    PhoneNumber = "+90 76772648"
                }
            };

        private int NextOrderId = 5;
        private readonly ILogger<OrderService> _logger;

        public OrderService(ILogger<OrderService> logger)
        {
            _logger = logger;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _orders;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _customers;
        }

        public IEnumerable<Service> GetServices()
        {
            return _services;
        }

        public void ProccessCreateOrderRequest(OrderRequest orderRequest)
        {
            CreateOrder(orderRequest.Order);
            CreateCustomer(orderRequest.Customer);
            orderRequest.Services.ForEach(service =>
            {
                CreateService(service);
            });
        }

        public void ProccessUpdateOrderRequest(OrderRequest orderRequest)
        {
            UpdateOrder(orderRequest.Order);
            UpdateCustomer(orderRequest.Customer);

            orderRequest.Services.ForEach(service =>
            {
                UpdateService(service);
            });
        }

        public void ProccessDeleteOrderRequest(int orderId)
        {
            DeleteOrder(orderId);
            DeleteCustomer(orderId);
            DeleteService(orderId);
        }

        private void CreateOrder(Order order)
        {
            order.OrderId = NextOrderId;
            NextOrderId++;
            _orders.Add(order);
        }

        private void CreateService(Service service)
        {
            _services.Add(service);
        }

        private void CreateCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        private void UpdateOrder(Order order)
        {
            var orderToUpdate = _orders.Find(o => o.OrderId == order.OrderId);
            DeleteOrder(order.OrderId);
            CreateOrder(order);
        }

        private void UpdateCustomer(Customer customer)
        {
            var customerToUpdate = _customers.Find(o => o.CustomerId == customer.CustomerId);
            DeleteCustomer(customer.CustomerId);
            CreateCustomer(customer);
        }

        private void UpdateService(Service service)
        {
            var serviceToUpdate = _services.Find(s => s.OrderId == service.OrderId);
            DeleteService(service.OrderId);
            CreateService(service);
        }

        private void DeleteOrder(int orderId)
        {
            var order = _orders.Find(o => o.OrderId == orderId);
            _orders.Remove(order);
        }

        private void DeleteCustomer(int customerId)
        {
            var customer = _customers.Find(s => s.CustomerId == customerId);
            _customers.Remove(customer);
        }

        private void DeleteService(int orderId)
        {
            var service = _services.Find(s => s.OrderId == orderId);
            _services.Remove(service);
        }
    }
}
