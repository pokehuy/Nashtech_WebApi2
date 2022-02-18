using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi2.Models
{
    public class PersonModel
    {
        public Guid Id {get; private set; } = Guid.NewGuid();
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTime DateOfBirth {get; set;}
        public string Gender {get; set;}
        public string BirthPlace {get; set;}
    }
}