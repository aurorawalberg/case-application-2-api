using TheMovingCompanyAPI.Entities;
using TheMovingCompanyAPI.Helpers;

namespace TheMovingCompanyAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly ILogger<OrderService> _logger;
        private readonly DataContext _context;

        public OrderService(ILogger<OrderService> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers;
        }

        public IEnumerable<Service> GetServices()
        {
            return _context.Services;
        }

        public void CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order, int id)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(int orderId)
        {
            var order = GetOrder(orderId);

            _context.Orders.Remove(order);
            _context.SaveChanges();
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = GetCustomer(customerId);

            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public void CreateService(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
        }

        public void DeleteService(int serviceId)
        {
            var service = GetService(serviceId);

            _context.Services.Remove(service);
            _context.SaveChanges();
        }

        private Order GetOrder(int id)
        {
            var order = _context.Orders.Find(id);
            if (order == null) throw new KeyNotFoundException($"Order with id {id} not found");
            return order;
        }

        private Customer GetCustomer(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer == null) throw new KeyNotFoundException($"Customer with id {id} not found");
            return customer;
        }

        private Service GetService(int id)
        {
            var service = _context.Services.Find(id);
            if (service == null) throw new KeyNotFoundException($"Service with id {id} not found");
            return service;
        }
    }
}
