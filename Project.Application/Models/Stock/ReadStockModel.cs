using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Project.Application.Models.Stock
{
    public class ReadStockModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CretedAt { get; set; }
        public int ProductCount { get; set; }
    }
}
