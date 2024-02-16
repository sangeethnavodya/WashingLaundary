using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        //Create Customer
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerCreateDto dto)
        {
            Customer newCustomer= _mapper.Map<Customer>(dto);
            await _context.Customers.AddAsync(newCustomer);
            await _context.SaveChangesAsync();
            return Ok(newCustomer);
        }

        //Get All Customers
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<CustomerGetDto>>> GetAllCustomers()
        {
            var customers = await _context.Customers.ToListAsync();
            var customersDto = _mapper.Map<IEnumerable<CustomerGetDto>>(customers);
            return Ok(customersDto);
        }



    }
}
