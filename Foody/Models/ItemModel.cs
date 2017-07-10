using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Foody.Models
{
    public class ItemModel
    {
        [Required]
        public string itemName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Category { get; set; }
        [Required]
        public int Price { get; set; }
    }
}