﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ExamCore.Model.Models
{
    public class User : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Please, provide full name.")]
        [StringLength(maximumLength: 50, MinimumLength = 2)]
        public string FullName { get; set; }
    }
}