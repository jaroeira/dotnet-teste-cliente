using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.model;

namespace API.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> SortCustomersByName(List<Customer> customers);
        Customer GetCustomerById(int id, List<Customer> customers);
        Customer GetCustomerByCPF(String cpf, List<Customer> customers);
        Decimal GetPercentageOfSalary(Decimal salary, decimal percentage);
    }
}