using API.Controllers.dtos;
using API.Interfaces;
using API.model;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class CustomerController : BaseApiController
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpPost]
        public List<Customer> GetCustomers([FromBody] CustomersToReceiveDto dto)
        {
            return _customerService.SortCustomersByName(dto.Clientes);
        }

        [HttpPost("{id}")]
        public ActionResult<Customer> GetCustomerById(int id, [FromBody] CustomersToReceiveDto dto)
        {
            var customer = _customerService.GetCustomerById(id, dto.Clientes);
            if (customer == null) return NotFound($"Customer {id} not found");

            return customer;
        }

        [HttpPost("salary")]

        public ActionResult<CustomerSalaryPercentageToReturnDto> GetCustomerSalary([FromBody] CustomersToReceiveDto dto, [FromQuery] string cpf, [FromQuery] decimal percentage = 30M)
        {
            if (percentage <= 0) return BadRequest("percentage must be greater than 0");

            if (string.IsNullOrEmpty(cpf)) return BadRequest();

            var customer = _customerService.GetCustomerByCPF(cpf, dto.Clientes);

            if (customer == null) return NotFound($"Customer not found for cpf: {cpf}");

            var percentOfSalary = _customerService.GetPercentageOfSalary(customer.Salario, percentage);

            return new CustomerSalaryPercentageToReturnDto
            {
                Cpf = cpf,
                OriginalSalary = customer.Salario.ToString("0.00"),
                Percentage = $"{percentage.ToString("0.00")}%",
                percentOfSalary = percentOfSalary.ToString("0.00")
            };
        }
    }

}