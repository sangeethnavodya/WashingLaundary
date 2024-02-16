using System.ComponentModel.DataAnnotations;

namespace WashingLaundary.Dtos.NewFolder
{
    public class ClothesGetDto
    {
        

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public string Brand { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Customer { get; set; }
    }
}
