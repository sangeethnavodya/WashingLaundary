namespace WashingLaundary.Models
{
    public class Clothes : BaseModel
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public string Material { get; set; }

        public string Brand { get; set; }

        public string Price { get; set; }

        public string Quantity { get; set; }

        public string Description { get; set; }

        public Boolean IsDelievered { get; set; }

        public string status { get; set; }




        //relationship

        public long CustomerId { get; set; }
        public Customer customer { get; set; }

    }
}
