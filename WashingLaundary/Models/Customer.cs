using System.ComponentModel.DataAnnotations;

namespace WashingLaundary.Models
{
    public class Customer
    {
          [Key]
        public int Id { get; set; }
        public string Name { get; set; }

          public string Address { get; set; }

          public string Phone { get; set; }

          public string City { get; set; }

          public string State { get; set; }


    }
}
