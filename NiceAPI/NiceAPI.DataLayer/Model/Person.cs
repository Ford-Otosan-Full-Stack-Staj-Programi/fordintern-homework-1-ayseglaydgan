﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FluentValidation;
using NiceAPI.BaseClass;
namespace NiceAPI.DataLayer
{
    public class Person : ModelBase
    {
        [Required]
        [StringLength(20, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 2)]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? AddressLine { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Province { get; set; }
        [NotMapped]
        public string FullName
        {
            get { return FirstName + LastName; }
        }

    }

    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.LastName).Length(2, 20).WithMessage("Not Enough Char fro LastName");
        }
    }

}

