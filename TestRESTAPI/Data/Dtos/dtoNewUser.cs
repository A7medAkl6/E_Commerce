﻿using System.ComponentModel.DataAnnotations;

namespace TestRESTAPI.Data.Dtos
{
    public class dtoNewUser
    {
        [Required]
        public string userName { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string email { get; set; }

        public string? phoneNumber { get; set; }
    }
}
