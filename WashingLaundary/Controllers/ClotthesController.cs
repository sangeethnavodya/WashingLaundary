using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WashingLaundary.Context;
using WashingLaundary.Dtos.Customer;
using WashingLaundary.Dtos.NewFolder;
using WashingLaundary.Entity;

namespace WashingLaundary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClotthesController : ControllerBase
    {
        private ApplicationDbContext _context { get; }
        private IMapper _mapper { get; }

        public ClotthesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //Crud

        //Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateClothes([FromBody] ClothesCreateDto dto)
        {
            var newClothes = _mapper.Map<Clothes>(dto);
            await _context.Clothes.AddAsync(newClothes);
            await _context.SaveChangesAsync();
            return Ok(newClothes);
        }

    
        [HttpGet]
        [Route("GetClothesByCustomerId/{customerId}")]
        public IActionResult GetClothesByCustomerId(int customerId)
        {
            // Assuming Clothes entity has a navigation property for Customer
            var clothesList = _context.Clothes
                .Include(c => c.Customer)
                .Where(c => c.CustomerID == customerId)
                .Select(c => new ClothesGetDto
                {
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt,
                    Name = c.Name,
                    Type = c.Type,
                    Color = c.Color,
                    Size = c.Size,
                    Material = c.Material,
                    Brand = c.Brand,
                    Price = c.Price,
                    Quantity = c.Quantity,
                    Customer = c.Customer.Name // Assuming Customer has a Name property
                })
                .ToList();

            // You may want to add additional logic here based on your requirements.

            return Ok(clothesList);
        }



    }
}
