using System;
using System.ComponentModel.DataAnnotations.Schema;
using NiceAPI.BaseClass;
namespace NiceAPI.DataLayer
{
    public class Person : ModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        [NotMapped]
        public string FullName
        {
            get { return FirstName + LastName; }
        }

    }
}

