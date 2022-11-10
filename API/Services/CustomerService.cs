
using API.Interfaces;
using API.model;

namespace API.Services
{
    public class CustomerService : ICustomerService
    {
        public CustomerService() { }

        public Customer GetCustomerByCPF(string cpf, List<Customer> customers)
        {
            return customers.Where(c => c.Cpf == cpf).FirstOrDefault();
        }

        public Customer GetCustomerById(int id, List<Customer> customers)
        {
            Customer customer = customers.Where(c => c.Id == id).FirstOrDefault();

            return customer;
        }

        public decimal GetPercentageOfSalary(decimal salary, decimal percentage)
        {
            return (salary / 100) * percentage;
        }

        public List<Customer> SortCustomersByName(List<Customer> customers)
        {
            return customers.OrderBy(c => c.Nome).ToList<Customer>();
        }
    }
}