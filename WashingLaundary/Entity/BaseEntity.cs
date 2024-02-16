using System.ComponentModel.DataAnnotations;

namespace WashingLaundary.Entity
{
    public abstract class BaseEntity
    {
        [Key]
        public long ID{ get; set; }

        public DateTime CreatedAt { get; set; }=DateTime.Now;

        public DateTime UpdatedAt { get; set; }=DateTime.Now;

        public Boolean IsActive { get; set; }=true;

    }
}
