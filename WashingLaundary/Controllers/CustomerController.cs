using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WashingLaundary.Data;
using WashingLaundary.Models;

namespace WashingLaundary.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class CustomerController : Controller
    {

        private readonly CustomerDbContext customerDbContext;
        public CustomerController(CustomerDbContext customerDbContext)
        {
            this.customerDbContext = customerDbContext;
        }



        //Get all customers
        [HttpGet]
        public async Task<IActionResult> GetAllCards()
        {
           var customer=customerDbContext.Customers.ToListAsync();
            return Ok(customer);
        }


        //Get single customer
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetCustomer([FromRoute] Guid id)
        {
            var customer = await customerDbContext.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        //Create customer
        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] Customer customer)
        {
            customer.Id = Guid.NewGuid();
            await customerDbContext.Customers.AddAsync(customer);
            await customerDbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCustomer), customer.Id, customer);
        }


        //Update customer
        [HttpPut("{id:guid}")]  
        public async Task<IActionResult> UpdateCustomer([FromRoute] Guid id, [FromBody] Customer customer)
        {
            var existingCustomer = await customerDbContext.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (existingCustomer == null)
            {
                return NotFound();
            }
            existingCustomer.Name = customer.Name;
            existingCustomer.Address = customer.Address;
            existingCustomer.Phone = customer.Phone;
            existingCustomer.City = customer.City;
            existingCustomer.State = customer.State;
            customerDbContext.Customers.Update(existingCustomer);
            await customerDbContext.SaveChangesAsync();
            return Ok();
        }

        //Delete customer
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteCustomer([FromRoute] Guid id)
        {
            var customer = await customerDbContext.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            customerDbContext.Customers.Remove(customer);
            await customerDbContext.SaveChangesAsync();
            return Ok();
        }   
    }
}
