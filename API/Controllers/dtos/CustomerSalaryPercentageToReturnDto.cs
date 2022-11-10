using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers.dtos
{
    public class CustomerSalaryPercentageToReturnDto
    {
        public string Cpf { get; set; }
        public string OriginalSalary { get; set; }
        public string Percentage { get; set; }
        public string percentOfSalary { get; set; }

    }
}