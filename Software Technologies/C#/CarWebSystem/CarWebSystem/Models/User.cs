
using System.Collections.Generic;
using CarWebSystem.Data;
using Microsoft.AspNetCore.Identity;

namespace CarWebSystem.Models
{
    
    public class User : IdentityUser
    {
        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
