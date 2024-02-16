﻿using System.ComponentModel.DataAnnotations;

namespace WashingLaundary.Models
{
    public class Customer : BaseModel
    {
    
          public string Name { get; set; }

          public string Address { get; set; }

          public string Phone { get; set; }

          public string City { get; set; }

          public string State { get; set; }


    }
}
