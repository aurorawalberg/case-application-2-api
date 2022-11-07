using TheMovingCompanyAPI.Entities;
using TheMovingCompanyAPI.Models;

namespace TheMovingCompanyAPI.Services
{
    public interface IOrderService
    {

        public void CreateOrder(Order order);
        public void UpdateOrder(Order order);
        public void DeleteOrder(int orderId);
        public void DeleteCustomer(int customerId);
        public void CreateService(Service service);
        public void DeleteService(int serviceId);
        public IEnumerable<Order> GetOrders();
        public IEnumerable<Customer> GetCustomers();
        public IEnumerable<Service> GetServices();
    }
}
