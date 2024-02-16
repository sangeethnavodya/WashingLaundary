using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WashingLaundary.Data;
using WashingLaundary.Dtos.Customer;
using WashingLaundary.Models;

namespace WashingLaundary.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {

        private readonly CustomerDbContext _customerDbContext;

        private IMapper _mapper;
        public CustomerController(CustomerDbContext customerDbContext,IMapper mapper)

        {
            _customerDbContext = customerDbContext;
            _mapper = mapper;
        }




   
        //Add customer
        [HttpPost]
        [Route("CreateCustomer")]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerCreateDto dto)
        {
           
            var customer = _mapper.Map<Customer>(dto);
            await _customerDbContext.Customers.AddAsync(customer);
            await _customerDbContext.SaveChangesAsync();
            return Ok(customer);
        }

    
 
    }
}
