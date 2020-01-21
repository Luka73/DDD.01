using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Project.Application.Models.Stock
{
    public class CreateStockModel
    {
        [Required]
        public string Name { get; set; }
    }
}
