using TheMovingCompanyAPI.Entities;
using TheMovingCompanyAPI.Models;

namespace TheMovingCompanyAPI.Services
{
    public interface IOrderService
    {

        public void ProccessCreateOrderRequest(OrderRequest orderRequest);
        public void ProccessUpdateOrderRequest(OrderRequest orderRequest);
        public void ProccessDeleteOrderRequest(int orderId);
        public IEnumerable<Order> GetOrders();
        public IEnumerable<Customer> GetCustomers();
        public IEnumerable<Service> GetServices();
    }
}
