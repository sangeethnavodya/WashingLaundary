namespace WashingLaundary.Entity
{
    public class Customer  : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        //relationship

        public ICollection<Clothes> Clothes { get; set; }


    }
}
