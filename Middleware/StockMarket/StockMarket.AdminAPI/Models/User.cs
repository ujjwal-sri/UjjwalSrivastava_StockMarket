﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.AdminAPI.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [StringLength(30)]
        public string UserID { get; set; }
        [Required]
        [StringLength(30)]
        public string Username { get; set; }
        [Required]
        [StringLength(30)]
        public string Password { get; set; }
        [Required]
        public string UserType { get; set; }
        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(13)]
        public string Mobile { get; set; }
        [Required]
        [StringLength(30)]
        public string Confirmed { get; set; }
    }
}
