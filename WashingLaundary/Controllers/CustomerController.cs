using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WashingLaundary.Context;
using WashingLaundary.Dtos.Customer;
using WashingLaundary.Entity;

namespace WashingLaundary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private  ApplicationDbContext _context { get;}
        private IMapper _mapper { get; }

        public CustomerController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerCreateDto dto)
        {
            Customer newCustomer= _mapper.Map<Customer>(dto);
            await _context.Customers.AddAsync(newCustomer);
            await _context.SaveChangesAsync();
            return Ok(newCustomer);
        }


    }
}
