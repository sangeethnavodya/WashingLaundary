namespace WashingLaundary.Entity
{
    public class Clothes : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public string Brand { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Image { get; set; }

        public string Description { get; set; }


        //relationship
        public long CustomerID { get; set; }

        public Customer Customer { get; set; }


    }
}
